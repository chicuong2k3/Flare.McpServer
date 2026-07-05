# FlareDatePicker

Date picker with calendar popup and min/max range.

```razor
<FlareDatePicker @bind-Value="_birthDate" Label="Birth Date"
    Min="@DateTime.Now.AddYears(-100)" Max="@DateTime.Now" />
```

## Key Parameters
- `Value` / `@bind-Value` - selected `DateTime?`
- `Min` / `Max` - date range limits
- `Format` - display format (default yyyy-MM-dd)
- `Color` - `FlareColor`
- `Clearable` - clear button
