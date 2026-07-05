# FlareColorPicker (ColorPicker)

**Category**: Inputs
**Tags**: colorpicker, color, picker, input, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareColorPicker.html](https://jrfrigat.github.io/Flare/api/FlareColorPicker.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Color picker with preset swatches, custom hex input, and RGB sliders.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string` | No | `` | Selected color hex value |
| `ValueChanged` | `EventCallback<string>` | No | `` | Callback when color changes |
| `Label` | `string` | No | `` | Field label |
| `Presets` | `string[]` | No | `` | Preset color swatches |
| `ShowInput` | `bool` | No | `true` | Show hex text input |
| `ShowSliders` | `bool` | No | `true` | Show RGB sliders |

## Examples

```razor
<FlareColorPicker @bind-Value="_color" Label="Brand Color" />
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareColorPicker.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/ColorPicker/FlareColorPicker.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareColorPicker.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `string?` | — | Selected hex color (#RRGGBB or #RRGGBBAA). `@bind-Value`. |
| `Label` | `string?` | — | Label for trigger button (non-inline). |
| `Inline` | `bool` | `false` | Always shown inline; otherwise popover trigger. |
| `Disabled` | `bool` | `false` | Disable picker. |
| `Format` | `ColorFormat` | `Hex` | Output format: Hex, Rgb, Hsl. |
| `Presets` | `IEnumerable<string>?` | — | Preset swatches shown at bottom. |
| `ShowEyeDropper` | `bool` | `false` | Eyedropper button (Chrome/Edge only). |
| `For` | `Expression<Func<string>>?` | — | EditContext binding. |

```razor
<FlareColorPicker @bind-Value="_color" Label="Brand Color" Presets="_palette" />
<FlareColorPicker @bind-Value="_bg" Inline="true" />
```
