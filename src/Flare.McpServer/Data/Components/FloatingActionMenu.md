# FlareFloatingActionMenu (FloatingActionMenu)

**Category**: Buttons
**Tags**: fab, menu, floating, speed-dial, actions
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareFloatingActionMenu.html](https://jrfrigat.github.io/Flare/api/FlareFloatingActionMenu.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

FAB that expands into a radial or vertical menu of action items.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Icon` | `string` | No | `add` | Main FAB icon |
| `Color` | `FlareColor` | No | `Primary` | FAB color |
| `ChildContent` | `RenderFragment` | Yes | `` | Menu items |
| `Position` | `Placement` | No | `BottomEnd` | Screen position |

## Sub-Components

- `FlareFloatingActionMenuItem`

## Examples

```razor
<FlareFloatingActionMenu Icon="add" Color="FlareColor.Primary">
    <FlareFloatingActionMenuItem Icon="person" OnClick="AddUser" />
    <FlareFloatingActionMenuItem Icon="group" OnClick="AddGroup" />
</FlareFloatingActionMenu>
```

