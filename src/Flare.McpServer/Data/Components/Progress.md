# FlareProgress (Progress)

**Category**: Feedback
**Tags**: progress, loading, indicator, bar, circular
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareProgress.html](https://jrfrigat.github.io/Flare/api/FlareProgress.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Progress indicator with linear and circular variants, determinate and indeterminate modes.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `double` | No | `0` | Progress value (0-100) |
| `Min` | `double` | No | `0` | Minimum value |
| `Max` | `double` | No | `100` | Maximum value |
| `Type` | `ProgressType` | No | `Linear` | Linear or circular style |
| `Color` | `FlareColor` | No | `Default` | Color of the progress bar |
| `Indeterminate` | `bool` | No | `false` | Show indeterminate animation |
| `ShowValue` | `bool` | No | `false` | Show percentage text |
| `Size` | `Size` | No | `Md` | Size of the progress indicator |

## Examples

```razor
<FlareProgress Value="70" Color="FlareColor.Success" />
```

```razor
<FlareProgress Type="ProgressType.Circular" Indeterminate="true" Size="Size.Lg" />
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareProgress.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Progress/FlareProgress.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareProgress.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `double?` | — | 0-100 percentage. null = indeterminate. |
| `Variant` | `ProgressVariant` | `Linear` | Linear, Circular, Buffer, Query. |
| `Color` | `FlareColor` | `Default` | Semantic color. |
| `Size` | `int` | `40` | Pixel size for Circular variant. |
| `Thickness` | `int` | `0` | Track thickness px for linear. 0 = theme default (4px). |
| `BufferValue` | `double` | `0` | Secondary buffer fill (Variant=Buffer only). |
| `Wavy` | `bool` | `false` | Animated sine wave indicator (determinate linear only). |

```razor
<FlareProgress Value="70" Color="FlareColor.Success" />
<FlareProgress Variant="ProgressVariant.Circular" Value="null" Size="48" /> <!-- indeterminate spinner -->
<FlareProgress Variant="ProgressVariant.Buffer" Value="45" BufferValue="75" />
```
