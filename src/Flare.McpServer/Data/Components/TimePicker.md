# FlareTimePicker (TimePicker)

**Category**: Inputs
**Tags**: timepicker, time, clock, input, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTimePicker.html](https://jrfrigat.github.io/Flare/api/FlareTimePicker.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Time picker with clock dial or text input, AM/PM support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `TimeSpan?` | No | `` | Selected time |
| `ValueChanged` | `EventCallback<TimeSpan?>` | No | `` | Callback when time changes |
| `Label` | `string` | No | `` | Field label |
| `Use24Hour` | `bool` | No | `false` | Use 24-hour format |
| `Color` | `FlareColor` | No | `Default` | Color theme |
| `Disabled` | `bool` | No | `false` | Whether the picker is disabled |

## Examples

```razor
<FlareTimePicker @bind-Value="_startTime" Label="Start Time" Use24Hour="true" />
```

---

> Inherits `FlareFieldBase` → Implements `IFlareField<TimeOnly?>`  
> Source: [FlareTimePicker.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/TimePicker/FlareTimePicker.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareTimePicker.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `TimeOnly?` | — | Selected time. `@bind-Value`. |
| `Label` | `string?` | — | Label (inherited). |
| `HelperText` | `string?` | — | Helper text (inherited). |
| `Disabled` | `bool` | `false` | Disable (inherited). |
| `Required` | `bool` | `false` | Required (inherited). |
| `PopupVariant` | `TimePickerVariant` | `Dial` | Popup style: Dial (analog clock) or Dropdown columns. |
| `Use24Hour` | `bool?` | — | 12h/24h. null = auto from culture. |
| `MinuteStep` | `int` | `1` | Minute increment in dropdown. |
| `Headline` | `string?` | — | Headline in popup. |
| `OkText` | `string?` | — | Confirm button text. |
| `CancelText` | `string?` | — | Cancel button text. |
| `Size` | `FieldSize` | `Md` | Control size. |
| `Typo` | `TypographyScale?` | — | Typography override. |
| `Variant` | `InputVariant` | `Default` | Filled/Outlined. |
| `For` | `Expression<Func<TimeOnly?>>?` | — | EditContext binding. |

```razor
<FlareTimePicker @bind-Value="_startTime" Label="Start" Use24Hour="true" />
```
