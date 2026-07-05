# FlareSwitch (Switch)

**Category**: Inputs
**Tags**: input, switch, toggle, boolean, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSwitch.html](https://jrfrigat.github.io/Flare/api/FlareSwitch.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Toggle switch component for boolean values with label support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `bool` | No | `false` | Gets or sets the toggle state |
| `ValueChanged` | `EventCallback<bool>` | No | `` | Callback when toggle state changes |
| `Label` | `string` | No | `` | Label text next to the switch |
| `Color` | `FlareColor` | No | `Default` | Color of the switch |
| `Disabled` | `bool` | No | `false` | Whether the switch is disabled |

## Examples

```razor
<FlareSwitch @bind-Value="_darkMode" Label="Dark Mode" Color="FlareColor.Primary" />
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareSwitch.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Switch/FlareSwitch.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareSwitch.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `bool` | `false` | On/off state. `@bind-Value`. |
| `Label` | `string?` | — | Label next to switch. |
| `LabelPlacement` | `LabelPlacement` | `End` | End (after), Start (before). |
| `Color` | `FlareColor` | `Primary` | Accent color of selected track. |
| `Size` | `SwitchSize` | `Md` | Sm or Md (52x32dp). |
| `Disabled` | `bool` | `false` | Disable switch. |
| `SelectedIcon` | `RenderFragment?` | — | Icon on handle when ON. |
| `UnselectedIcon` | `RenderFragment?` | — | Icon on handle when OFF. |
| `ErrorText` | `string?` | — | Custom error message. |
| `For` | `Expression<Func<bool>>?` | — | EditContext binding. |

```razor
<FlareSwitch @bind-Value="_darkMode" Label="Dark Mode" Color="FlareColor.Primary" />
```
