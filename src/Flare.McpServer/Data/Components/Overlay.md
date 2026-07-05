# FlareOverlay (Overlay)

**Category**: Overlays
**Tags**: overlay, backdrop, cover, mask
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareOverlay.html](https://jrfrigat.github.io/Flare/api/FlareOverlay.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Semi-transparent backdrop used behind dialogs, drawers, and menus.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Visible` | `bool` | No | `false` | Overlay visibility |
| `Opacity` | `double` | No | `0.5` | Background opacity (0-1) |
| `ChildContent` | `RenderFragment` | No | `` | Content rendered on top |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback` | Fired when overlay is clicked |

## Examples

```razor
<FlareOverlay Visible="true"><FlareProgress Type="ProgressType.Circular" /></FlareOverlay>
```

