# FlareToolPanel (ToolPanel)

**Category**: IDE
**Tags**: tool, panel, dock, ide, sidebar
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareToolPanel.html](https://jrfrigat.github.io/Flare/api/FlareToolPanel.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Dockable tool panel for IDE layouts like Solution Explorer. Separate package: Flare.Components.IDE.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Panel content |
| `Title` | `string` | No | `` | Panel title |
| `Position` | `Placement` | No | `Right` | Docking position |

## Examples

```razor
<FlareToolPanel Title="Solution Explorer" Position="Placement.Right">
    <FlareTreeView Items="_files" />
</FlareToolPanel>
```

