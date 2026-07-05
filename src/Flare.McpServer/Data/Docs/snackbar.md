# FlareSnackbarProvider

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
