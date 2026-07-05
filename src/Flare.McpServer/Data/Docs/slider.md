# FlareSlider API

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
