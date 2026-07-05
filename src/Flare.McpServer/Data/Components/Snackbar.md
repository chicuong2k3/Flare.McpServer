# FlareSnackbarProvider (Snackbar)

**Category**: Feedback
**Tags**: notification, toast, snackbar, message, feedback, alert
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSnackbar.html](https://jrfrigat.github.io/Flare/api/FlareSnackbar.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Snackbar notification system. Use ISnackbarService to show notifications programmatically.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `MaxDisplayed` | `int` | No | `5` | Maximum concurrent snackbars |
| `Position` | `Placement` | No | `BottomEnd` | Position of snackbars |
| `Timeout` | `int` | No | `5000` | Auto-dismiss timeout in ms (0 = sticky) |

## Examples

```razor
<FlareSnackbarProvider />
```

```razor
Snackbar.Show("Record deleted", SnackbarSeverity.Success);
```

```razor
Snackbar.Show("Error occurred", SnackbarSeverity.Error, icon: "error");
```

---

Snackbar notification system. Place the provider once in your layout and use `ISnackbarService` to show notifications.

```razor
<!-- In MainLayout.razor -->
<FlareSnackbarProvider />

@inject ISnackbarService Snackbar

Snackbar.Show("Record saved", SnackbarSeverity.Success);
Snackbar.Show("Error occurred", SnackbarSeverity.Error, icon: "error");
```

## Severity Levels
- `SnackbarSeverity.Info`
- `SnackbarSeverity.Success`
- `SnackbarSeverity.Warning`
- `SnackbarSeverity.Error`

## Key Parameters
- `MaxDisplayed` - max concurrent notifications
- `Position` - Placement (default BottomEnd)
- `Timeout` - auto-dismiss in ms (0 = sticky)
