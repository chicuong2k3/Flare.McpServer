# FlareChip API

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
