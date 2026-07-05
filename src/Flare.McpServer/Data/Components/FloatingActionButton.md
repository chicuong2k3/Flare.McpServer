# FlareFloatingActionButton (FloatingActionButton)

**Category**: Buttons
**Tags**: button, fab, floating, action, material
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareFloatingActionButton.html](https://jrfrigat.github.io/Flare/api/FlareFloatingActionButton.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Material FAB - floating circular action button pinned to the viewport.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Icon` | `string` | Yes | `` | FAB icon |
| `Color` | `FlareColor` | No | `Primary` | FAB color |
| `Size` | `Size` | No | `Md` | FAB size |
| `Position` | `Placement` | No | `BottomEnd` | Screen position |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback` | Fired on click |

## Examples

```razor
<FlareFloatingActionButton Icon="add" Color="FlareColor.Primary" OnClick="Add" />
```

