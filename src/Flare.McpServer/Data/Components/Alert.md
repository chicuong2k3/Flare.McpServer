# FlareAlert (Alert)

**Category**: Feedback
**Tags**: alert, message, notification, feedback, banner, warning
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareAlert.html](https://jrfrigat.github.io/Flare/api/FlareAlert.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Alert component for displaying important messages with severity levels, icons, and dismissible support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Alert message content |
| `Severity` | `Severity` | No | `Info` | Severity level |
| `Title` | `string` | No | `` | Alert title/heading |
| `Icon` | `string` | No | `` | Custom icon (auto-selected by severity if not set) |
| `Dismissible` | `bool` | No | `false` | Show close button |
| `Outlined` | `bool` | No | `false` | Use outlined style |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClose` | `EventCallback` | Fired when the alert is dismissed |

## Examples

```razor
<FlareAlert Severity="Severity.Success">Operation completed successfully!</FlareAlert>
```

```razor
<FlareAlert Severity="Severity.Error" Title="Error" Dismissible="true">Something went wrong.</FlareAlert>
```

---

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
