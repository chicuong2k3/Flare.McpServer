# FlareSlider (Slider)

**Category**: Inputs
**Tags**: input, slider, range, number, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSlider.html](https://jrfrigat.github.io/Flare/api/FlareSlider.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Slider for selecting a numeric value or range with MD3 Expressive + Fluent support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `int` | No | `0` | Gets or sets the slider value |
| `ValueChanged` | `EventCallback<int>` | No | `` | Callback when value changes |
| `Min` | `int` | No | `0` | Minimum value |
| `Max` | `int` | No | `100` | Maximum value |
| `Step` | `int` | No | `1` | Step increment |
| `Color` | `FlareColor` | No | `Default` | Color of the slider track |
| `Size` | `Size` | No | `Md` | Size of the slider |
| `Disabled` | `bool` | No | `false` | Whether the slider is disabled |
| `ShowValueLabel` | `bool` | No | `false` | Show the current value bubble |
| `Vertical` | `bool` | No | `false` | Render as vertical slider |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnChange` | `EventCallback<int>` | Fired when the value changes |

## Examples

```razor
<FlareSlider @bind-Value="_volume" Min="0" Max="100" />
```

```razor
<FlareSlider @bind-Value="_progress" Color="FlareColor.Primary" ShowValueLabel="true" />
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareSlider.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Slider/FlareSlider.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareSlider.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `double` | 0 | Current value. Range mode: lower bound. `@bind-Value`. |
| `ValueEnd` | `double` | — | Upper bound (range mode only). `@bind-ValueEnd`. |
| `Min` | `double` | 0 | Minimum value. |
| `Max` | `double` | 100 | Maximum value. |
| `Step` | `double` | 1 | Increment step. |
| `Color` | `FlareColor` | `Default` | Accent color of active track and handle. |
| `Size` | `SliderSize` | `Xs` | Track thickness: Xs-Xl (16/24/40/56/96dp). |
| `Label` | `string?` | — | Label above slider. |
| `HelperText` | `string?` | — | Helper text below. |
| `ErrorText` | `string?` | — | Error message. |
| `Disabled` | `bool` | `false` | Disable slider. |
| `Vertical` | `bool` | `false` | Vertical orientation. |
| `Range` | `bool` | `false` | Two-handle range mode. |
| `Indicator` | `bool` | `false` | Floating value indicator above handle. |
| `ShowValue` | `bool` | `false` | Current value shown next to label. |
| `Init` | `double?` | — | Fill start anchor (single mode). Ignored in range. |
| `StartIcon` | `string?` | — | Material icon before track. |
| `EndIcon` | `string?` | — | Material icon after track. |
| `Marks` | `Dictionary<double,string>?` | — | Labeled tick marks. |
| `Stepper` | `bool` | `false` | Step indicator dots along track. |
| `Format` | `string?` | — | Format string for displayed value(s). |
| `For` | `Expression<Func<TValue>>?` | — | EditContext binding. |
| `AriaLabel` | `string?` | — | Accessible label when no Label. |

```razor
<FlareSlider @bind-Value="_volume" Min="0" Max="100" />
<FlareSlider @bind-Value="_rangeLow" @bind-ValueEnd="_rangeHigh" Range="true" Min="0" Max="1000" />
<FlareSlider @bind-Value="_v" Color="FlareColor.Primary" Indicator="true" StartIcon="volume_mute" EndIcon="volume_up" />
```
