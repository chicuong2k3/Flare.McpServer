# FlareProgress API

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
