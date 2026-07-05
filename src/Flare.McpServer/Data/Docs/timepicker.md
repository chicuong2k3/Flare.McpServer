# FlareTimePicker

Time picker with 12h/24h support.

```razor
<FlareTimePicker @bind-Value="_startTime" Label="Start Time" Use24Hour="true" />
```

## Key Parameters
- `Value` / `@bind-Value` - selected `TimeSpan?`
- `Use24Hour` - 24-hour format
- `Color` - `FlareColor`
