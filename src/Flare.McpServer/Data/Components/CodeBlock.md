# FlareCodeBlock (CodeBlock)

**Category**: Display
**Tags**: code, syntax, highlight, editor, display
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareCodeBlock.html](https://jrfrigat.github.io/Flare/api/FlareCodeBlock.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Syntax-highlighted code block with line numbers, copy button, and language detection.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Code` | `string` | Yes | `` | Source code text |
| `Language` | `string` | No | `` | Programming language (csharp, js, html, etc.) |
| `ShowLineNumbers` | `bool` | No | `true` | Show line numbers |
| `ShowCopy` | `bool` | No | `true` | Show copy button |

## Examples

```razor
<FlareCodeBlock Code="@code" Language="csharp" ShowLineNumbers="true" />
```

