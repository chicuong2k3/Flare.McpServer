import { readFileSync, writeFileSync, readdirSync, unlinkSync, existsSync, mkdirSync, rmSync } from 'fs';
import { join, dirname } from 'path';
import { fileURLToPath } from 'url';

const __dirname = dirname(fileURLToPath(import.meta.url));
const componentsDir = join(__dirname, '..', 'src', 'Flare.McpServer', 'Data', 'Components');
const outputDir = join(componentsDir, 'converted');
const docsDir = join(__dirname, '..', 'src', 'Flare.McpServer', 'Data', 'Docs');

if (existsSync(outputDir)) {
  rmSync(outputDir, { recursive: true });
}
mkdirSync(outputDir, { recursive: true });

function escapeMd(text) {
  if (!text) return '';
  return String(text).replace(/[|\\]/g, '\\$&');
}

function convertToMarkdown(component) {
  const lines = [];

  // Title
  lines.push(`# ${component.displayName} (${component.name})`);
  lines.push('');

  // Metadata
  lines.push(`**Category**: ${component.category}`);
  lines.push(`**Tags**: ${(component.tags || []).join(', ')}`);
  if (component.apiUrl) lines.push(`**API Reference**: [${component.apiUrl}](${component.apiUrl})`);
  if (component.docUrl) lines.push(`**Documentation**: [${component.docUrl}](${component.docUrl})`);
  lines.push('');

  // Description
  if (component.description) {
    lines.push('## Description');
    lines.push('');
    lines.push(component.description);
    lines.push('');
  }

  // Parameters table
  if (component.parameters && component.parameters.length > 0) {
    lines.push('## Parameters');
    lines.push('');
    // Filter out inherited base component params that are always present
    const displayParams = component.parameters.filter(p => {
      const inherited = ['AdditionalAttributes', 'Class', 'Style', 'ComponentCssClass',
        'Theme', 'ThemeService'];
      return !inherited.includes(p.name);
    });

    if (displayParams.length > 0) {
      lines.push('| Name | Type | Required | Default | Description |');
      lines.push('|------|------|----------|---------|-------------|');
      for (const p of displayParams) {
        lines.push(`| \`${escapeMd(p.name)}\` | \`${escapeMd(p.type)}\` | ${p.required ? 'Yes' : 'No'} | \`${escapeMd(p.default || '')}\` | ${escapeMd(p.description)} |`);
      }
      lines.push('');
    }

    // Inherited params
    const inheritedParams = component.parameters.filter(p => {
      const inherited = ['AdditionalAttributes', 'Class', 'Style', 'ComponentCssClass',
        'Theme', 'ThemeService'];
      return inherited.includes(p.name);
    });
    if (inheritedParams.length > 0) {
      lines.push('### Inherited from FlareComponentBase');
      lines.push('');
      lines.push('| Name | Type | Description |');
      lines.push('|------|------|-------------|');
      for (const p of inheritedParams) {
        lines.push(`| \`${escapeMd(p.name)}\` | \`${escapeMd(p.type)}\` | ${escapeMd(p.description)} |`);
      }
      lines.push('');
    }
  }

  // Events table
  if (component.events && component.events.length > 0) {
    lines.push('## Events');
    lines.push('');
    lines.push('| Name | Type | Description |');
    lines.push('|------|------|-------------|');
    for (const e of component.events) {
      lines.push(`| \`${escapeMd(e.name)}\` | \`${escapeMd(e.type)}\` | ${escapeMd(e.description)} |`);
    }
    lines.push('');
  }

  // Sub-components
  if (component.subComponents && component.subComponents.length > 0) {
    lines.push('## Sub-Components');
    lines.push('');
    for (const sub of component.subComponents) {
      lines.push(`- \`${escapeMd(sub)}\``);
    }
    lines.push('');
  }

  // Examples
  if (component.examples && component.examples.length > 0) {
    lines.push('## Examples');
    lines.push('');
    for (const ex of component.examples) {
      lines.push('```razor');
      lines.push(ex);
      lines.push('```');
      lines.push('');
    }
  }

  // Append existing docs if available
  const existingDocPath = join(docsDir, `${component.name.toLowerCase()}.md`);
  if (existsSync(existingDocPath)) {
    const existingDoc = readFileSync(existingDocPath, 'utf-8');
    // Remove the title line from existing doc to avoid duplication
    const existingLines = existingDoc.split('\n');
    // Skip the first heading line if it starts with #
    let contentStart = 0;
    if (existingLines[0] && existingLines[0].startsWith('# ')) {
      contentStart = 1;
      // Skip any empty lines after the heading
      while (contentStart < existingLines.length && existingLines[contentStart].trim() === '') {
        contentStart++;
      }
    }
    const docContent = existingLines.slice(contentStart).join('\n').trim();
    if (docContent) {
      lines.push('---');
      lines.push('');
      lines.push(docContent);
    }
  }

  return lines.join('\n') + '\n';
}

// Read all JSON files
const jsonFiles = readdirSync(componentsDir).filter(f => f.endsWith('.json'));
const objects = [];

for (const file of jsonFiles) {
  try {
    const json = readFileSync(join(componentsDir, file), 'utf-8');
    const obj = JSON.parse(json);
    objects.push(obj);
  } catch (e) {
    console.error(`Error parsing ${file}:`, e.message);
  }
}

// Sort by name
objects.sort((a, b) => a.name.localeCompare(b.name, 'en', { sensitivity: 'base' }));

// Build categories list
const categories = [...new Set(objects.map(o => o.category))].sort((a, b) =>
  a.localeCompare(b, 'en', { sensitivity: 'base' }));

// Build index JSON
const indexData = {
  components: objects.map(o => ({
    name: o.name,
    category: o.category,
    description: o.description,
    displayName: o.displayName,
    tags: o.tags || [],
    file: `${o.name}.md`
  })),
  categories
};

writeFileSync(join(outputDir, '_index.json'), JSON.stringify(indexData, null, 2), 'utf-8');
console.log(`Generated _index.json with ${indexData.components.length} components`);

// Generate markdown files
let mdCount = 0;
for (const obj of objects) {
  const md = convertToMarkdown(obj);
  const outPath = join(outputDir, `${obj.name}.md`);
  writeFileSync(outPath, md, 'utf-8');
  mdCount++;
}

console.log(`Generated ${mdCount} markdown files in ${outputDir}`);
console.log(`Categories: ${categories.join(', ')}`);
