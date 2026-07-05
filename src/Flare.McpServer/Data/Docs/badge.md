# FlareBadge API

> Inherits `FlareComponentBase`  
> Source: [FlareBadge.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Badge/FlareBadge.razor)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Badge content (count, text). |
| `Color` | `FlareColor` | `Default` | Badge color. |
| `Dot` | `bool` | `false` | Compact dot indicator. |
| `Anchor` | `BadgeAnchor?` | — | Anchor element edge. |
| `Origin` | `BadgeOrigin?` | — | Badge corner relative to anchor. |
| `Overlap` | `BadgeOverlap?` | — | Overlap shape matching anchor. |
| `Visible` | `bool` | `true` | Show/hide badge. |

```razor
<FlareBadge Color="FlareColor.Error">5</FlareBadge>
<FlareBadge Dot="true" Color="FlareColor.Success" />
```
