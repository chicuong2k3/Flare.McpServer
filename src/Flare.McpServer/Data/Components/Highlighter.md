# FlareHighlighter (Highlighter)

**Category**: Display
**Tags**: highlight, search, text, mark
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareHighlighter.html](https://jrfrigat.github.io/Flare/api/FlareHighlighter.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Highlights matching text within a string with a colored background.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Text` | `string` | Yes | `` | Full text to display |
| `Query` | `string` | Yes | `` | Search term to highlight |
| `Color` | `FlareColor` | No | `Warning` | Highlight color |

## Examples

```razor
<FlareHighlighter Text="Hello World" Query="World" Color="FlareColor.Warning" />
```

