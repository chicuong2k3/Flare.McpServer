# FlareProgress

Progress indicator with linear and circular variants, determinate and indeterminate modes.

```razor
<FlareProgress Value="70" Color="FlareColor.Success" />
<FlareProgress Type="ProgressType.Circular" Indeterminate="true" Size="Size.Lg" />
<FlareProgress Value="45" ShowValue="true" />
```

## Key Parameters
- `Value` - progress value (0-100)
- `Type` - Linear or Circular
- `Color` - `FlareColor` for the fill
- `Indeterminate` - animated unknown progress
- `ShowValue` - display percentage text
- `Size` - Xs to Xl
