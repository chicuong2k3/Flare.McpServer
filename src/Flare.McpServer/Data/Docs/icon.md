# FlareIcon

Material Symbols icon with configurable size, fill, weight, and grade.

```razor
<FlareIcon Name="search" />
<FlareIcon Name="favorite" Color="FlareColor.Error" Fill="true" />
<FlareIcon Name="settings" Size="Size.Lg" OnClick="OpenSettings" />
```

## Key Parameters
- `Name` - Material icon name (required)
- `Size` - Xs to Xl
- `Color` - `FlareColor`
- `Fill` - use filled style
- `Weight` - 100-700
- `Grade` - -50 to 200
