# FlareSpeedDial (SpeedDial)

**Category**: Buttons
**Tags**: speeddial, fab, actions, expand
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSpeedDial.html](https://jrfrigat.github.io/Flare/api/FlareSpeedDial.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Speed dial component that expands into multiple action buttons on click.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Icon` | `string` | No | `add` | Main button icon |
| `ChildContent` | `RenderFragment` | Yes | `` | SpeedDialAction children |
| `Position` | `Placement` | No | `BottomEnd` | Screen position |

## Sub-Components

- `FlareSpeedDialAction`

## Examples

```razor
<FlareSpeedDial>
    <FlareSpeedDialAction Icon="edit" OnClick="Edit" />
    <FlareSpeedDialAction Icon="delete" OnClick="Delete" />
</FlareSpeedDial>
```

