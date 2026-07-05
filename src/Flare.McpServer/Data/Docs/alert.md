# FlareAlert API

> Inherits `FlareComponentBase`  
> Source: [FlareAlert.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Alert/FlareAlert.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareAlert.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Body content rendered below title. |
| `Title` | `string?` | — | Bold title above body. |
| `Severity` | `AlertSeverity` | `Info` | Severity level controlling color and icon. |
| `Variant` | `AlertVariant` | `Filled` | Visual display: Filled, Outlined, Text. |
| `Icon` | `RenderFragment?` | — | Custom icon (overrides severity default). |
| `NoIcon` | `bool` | `false` | Hides leading icon entirely. |
| `Dismissible` | `bool` | `false` | Show close button. |
| `AnimateDismiss` | `bool` | `true` | Fade-out + slide-up animation on dismiss. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClose` | `EventCallback` | Fired when close button clicked. |
| `OnDismiss` | `EventCallback` | Fired when alert dismissed. |

```razor
<FlareAlert Severity="AlertSeverity.Success">Operation completed!</FlareAlert>
<FlareAlert Severity="AlertSeverity.Error" Title="Error" Dismissible="true">Something went wrong.</FlareAlert>
```
