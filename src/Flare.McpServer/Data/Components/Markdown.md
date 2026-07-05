# FlareMarkdown (Markdown)

**Category**: Display
**Tags**: markdown, render, html, text, format
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareMarkdown.html](https://jrfrigat.github.io/Flare/api/FlareMarkdown.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Markdown renderer that converts markdown text to HTML with syntax highlighting.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Content` | `string` | Yes | `` | Markdown text to render |
| `HighlightCode` | `bool` | No | `true` | Syntax highlight code blocks |

## Examples

```razor
<FlareMarkdown Content="# Hello

**Bold text** and `code`." />
```

