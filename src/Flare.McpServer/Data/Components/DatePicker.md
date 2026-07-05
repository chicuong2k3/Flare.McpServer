# FlareDatePicker (DatePicker)

**Category**: Inputs
**Tags**: datepicker, calendar, date, input, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDatePicker.html](https://jrfrigat.github.io/Flare/api/FlareDatePicker.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Date picker with calendar popup, min/max dates, and format options.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `DateTime?` | No | `` | Selected date |
| `ValueChanged` | `EventCallback<DateTime?>` | No | `` | Callback when date changes |
| `Label` | `string` | No | `` | Field label |
| `Min` | `DateTime?` | No | `` | Earliest selectable date |
| `Max` | `DateTime?` | No | `` | Latest selectable date |
| `Format` | `string` | No | `yyyy-MM-dd` | Display format |
| `Color` | `FlareColor` | No | `Default` | Color theme |
| `Disabled` | `bool` | No | `false` | Whether the picker is disabled |
| `Clearable` | `bool` | No | `false` | Show clear button |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnChange` | `EventCallback<DateTime?>` | Fired when date changes |

## Examples

```razor
<FlareDatePicker @bind-Value="_birthDate" Label="Birth Date" Min="@DateTime.Now.AddYears(-100)" Max="@DateTime.Now" />
```

---

> Inherits `FlareFieldBase` → Implements `IFlareField<DateOnly?>`  
> Source: [FlareDatePicker.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/DatePicker/FlareDatePicker.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareDatePicker.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `DateOnly?` | — | Selected date. `@bind-Value`. |
| `Label` | `string?` | — | Label (inherited). |
| `Placeholder` | `string?` | — | Placeholder (inherited). |
| `HelperText` | `string?` | — | Helper text (inherited). |
| `Disabled` | `bool` | `false` | Disable (inherited). |
| `Required` | `bool` | `false` | Required (inherited). |
| `Min` | `DateOnly?` | — | Earliest selectable date. |
| `Max` | `DateOnly?` | — | Latest selectable date. |
| `IsDateDisabled` | `Func<DateOnly,bool>?` | — | Disable specific dates. |
| `DateFormat` | `string?` | — | Display/parse format. null = culture default. |
| `Culture` | `CultureInfo?` | — | Calendar culture. Default = CurrentUICulture. |
| `AllowInput` | `bool` | `true` | Allow typing date directly. |
| `AllowPicker` | `bool` | `true` | Show calendar popup button. |
| `ShowTodayButton` | `bool` | — | Show Today button. |
| `ShowClearButton` | `bool` | — | Show Clear button. |
| `TodayText` | `string?` | — | Today button override text. |
| `ClearText` | `string?` | — | Clear button override text. |
| `Size` | `FieldSize` | `Md` | Control size. |
| `Typo` | `TypographyScale?` | — | Typography override. |
| `Variant` | `InputVariant` | `Default` | Filled/Outlined. |
| `For` | `Expression<Func<DateOnly?>>?` | — | EditContext binding. |
| `HasError` | `bool` | `false` | Force error visual state. |

```razor
<FlareDatePicker @bind-Value="_birthDate" Label="Birth Date"
    Min="@(new DateOnly(1900,1,1))" Max="@(DateOnly.FromDateTime(DateTime.Now))" />
```
