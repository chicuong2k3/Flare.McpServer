# FlareToolbar (Toolbar)

**Category**: Navigation
**Tags**: toolbar, actions, buttons, bar
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareToolbar.html](https://jrfrigat.github.io/Flare/api/FlareToolbar.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Horizontal toolbar with groups of buttons, separators, and icons.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Toolbar items |

## Examples

```razor
<FlareToolbar>
    <FlareButton Icon="undo" />
    <FlareButton Icon="redo" />
    <FlareDivider Vertical="true" />
    <FlareButton Icon="save" />
</FlareToolbar>
```

