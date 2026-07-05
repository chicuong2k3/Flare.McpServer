# FlareSplitter (Splitter)

**Category**: Layout
**Tags**: layout, splitter, resize, panels, divider
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSplitter.html](https://jrfrigat.github.io/Flare/api/FlareSplitter.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Resizable split panels with draggable divider, horizontal or vertical.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Split pane children |
| `Direction` | `SplitDirection` | No | `Horizontal` | Horizontal or Vertical |
| `Panel1MinSize` | `string` | No | `100px` | Min size for first panel |
| `Panel2MinSize` | `string` | No | `100px` | Min size for second panel |

## Examples

```razor
<FlareSplitter>
    <div>Panel 1</div>
    <div>Panel 2</div>
</FlareSplitter>
```

