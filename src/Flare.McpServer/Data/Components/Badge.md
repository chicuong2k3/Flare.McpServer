# FlareBadge (Badge)

**Category**: Display
**Tags**: badge, indicator, notification, count, status, label
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareBadge.html](https://jrfrigat.github.io/Flare/api/FlareBadge.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Badge component for displaying counts, status indicators, or labels.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Badge content (often a number) |
| `Color` | `FlareColor` | No | `Default` | Badge color |
| `Position` | `BadgePosition` | No | `TopEnd` | Position when used on an element |
| `Dot` | `bool` | No | `false` | Show as a small dot without content |
| `Visible` | `bool` | No | `true` | Whether the badge is visible |

## Examples

```razor
<FlareBadge Color="FlareColor.Error">5</FlareBadge>
```

```razor
<FlareBadge Dot="true" Color="FlareColor.Success" />
```

---

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
