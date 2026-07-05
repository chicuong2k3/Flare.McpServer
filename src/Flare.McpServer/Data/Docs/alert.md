# FlareAlert

Alert for important messages with severity levels and dismissible support.

```razor
<FlareAlert Severity="Severity.Success">Operation completed!</FlareAlert>
<FlareAlert Severity="Severity.Error" Title="Error" Dismissible="true">Something went wrong.</FlareAlert>
```

## Severity Levels
- `Severity.Info`, `Severity.Success`, `Severity.Warning`, `Severity.Error`

## Key Parameters
- `Title` - optional heading
- `Icon` - custom icon (auto-selected by severity)
- `Dismissible` - show close button
- `Outlined` - outlined style
