# FlareRadio / FlareRadioGroup

Radio button group for single selection.

```razor
<FlareRadioGroup @bind-Value="_option">
    <FlareRadio Value="apple" Label="Apple" />
    <FlareRadio Value="orange" Label="Orange" />
    <FlareRadio Value="banana" Label="Banana" />
</FlareRadioGroup>
```

## Key Parameters
- `Value` - selected value binding (on group)
- `Label` - radio label text
- `Color` - `FlareColor`
