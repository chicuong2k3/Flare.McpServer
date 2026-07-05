# FlareChip (Chip)

**Category**: Display
**Tags**: chip, tag, label, filter, badge
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareChip.html](https://jrfrigat.github.io/Flare/api/FlareChip.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Chip/tag component for filtering, selection, or displaying categories with optional icons and close button.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Chip label content |
| `Label` | `string` | No | `` | Simple text label (alternative to ChildContent) |
| `Color` | `FlareColor` | No | `Default` | Chip color |
| `Variant` | `Variant` | No | `Filled` | Visual appearance |
| `Size` | `Size` | No | `Md` | Chip size |
| `Icon` | `string` | No | `` | Leading icon name |
| `Closeable` | `bool` | No | `false` | Show close/remove button |
| `Selected` | `bool` | No | `false` | Whether the chip is selected |
| `Disabled` | `bool` | No | `false` | Whether the chip is disabled |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClose` | `EventCallback` | Fired when the close button is clicked |
| `OnClick` | `EventCallback` | Fired when the chip is clicked |

## Examples

```razor
<FlareChip Color="FlareColor.Primary" Closeable="true">React</FlareChip>
```

```razor
<FlareChip Variant="Variant.Outlined" Icon="person">User</FlareChip>
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareChip.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Chip/FlareChip.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareChip.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Label` | `string?` | — | Text label. |
| `LeadingIcon` | `RenderFragment?` | — | Icon before label. |
| `Avatar` | `RenderFragment?` | — | Avatar at leading edge (overrides LeadingIcon). |
| `Color` | `FlareColor` | `Default` | Chip color. |
| `Variant` | `ChipVariant` | `Outlined` | Outlined, Filled, Elevated. |
| `Size` | `ChipSize` | `Md` | Size: Xs..Xl. |
| `Closeable` | `bool` | `false` | Show close (x) button. |
| `Selected` | `bool` | `false` | Selected/active state. `@bind-Selected`. |
| `Value` | `object?` | — | Value used by FlareChipGroup for identification. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback` | Fired when chip body clicked. |
| `OnClose` | `EventCallback` | Fired when close button clicked. |

```razor
<FlareChip Color="FlareColor.Primary" Closeable="true">React</FlareChip>
<FlareChip Variant="ChipVariant.Filled" LeadingIcon="@PersonIcon" Selected="true">Active</FlareChip>
```
