# FlareToggleButton (ToggleButton)

**Category**: Buttons
**Tags**: button, toggle, select, toolbar
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareToggleButton.html](https://jrfrigat.github.io/Flare/api/FlareToggleButton.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Button that toggles between selected and unselected states.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Selected` | `bool` | No | `false` | Toggle state |
| `SelectedChanged` | `EventCallback<bool>` | No | `` | Callback on toggle |
| `Icon` | `string` | No | `` | Button icon |
| `ChildContent` | `RenderFragment` | No | `` | Button label |

## Examples

```razor
<FlareToggleButton @bind-Selected="_bold" Icon="format_bold" />
```

