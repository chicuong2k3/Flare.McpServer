# FlareSlider

Slider for selecting numeric values with MD3 Expressive + Fluent support. Supports single-value and range modes, vertical orientation, step indicators, and value bubble.

```razor
<FlareSlider @bind-Value="_volume" Min="0" Max="100" />
<FlareSlider @bind-Value="_progress" Color="FlareColor.Primary" ShowValueLabel="true" />
<FlareSlider @bind-Value="_range" Min="0" Max="1000" Step="50" Size="Size.Lg" />
```

## Key Parameters
- `Value` / `@bind-Value` - current value
- `Min`, `Max`, `Step` - range configuration
- `Color` - `FlareColor` for the track
- `Size` - Xs, Sm, Md, Lg, Xl
- `ShowValueLabel` - floating value bubble
- `Vertical` - render as vertical slider
- `Disabled` - disable interaction

## Range Mode
When used with two values, enables dual-handle range selection.
