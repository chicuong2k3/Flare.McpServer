# FlarePaper (Paper)

**Category**: DataDisplay
**Tags**: paper, surface, panel, elevation
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlarePaper.html](https://jrfrigat.github.io/Flare/api/FlarePaper.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Elevated surface panel with shadow and optional outline.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Paper content |
| `Elevation` | `int` | No | `1` | Shadow depth 0-6 |
| `Outlined` | `bool` | No | `false` | Outlined style |

## Examples

```razor
<FlarePaper Elevation="3" Outlined="true"><FlareText>Content</FlareText></FlarePaper>
```

