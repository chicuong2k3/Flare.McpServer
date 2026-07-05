# FlareIcon (Icon)

**Category**: Display
**Tags**: icon, material, symbol, visual
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareIcon.html](https://jrfrigat.github.io/Flare/api/FlareIcon.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Material Symbols icon component with configurable size, fill, weight, and grade.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Name` | `string` | Yes | `` | Material icon name (e.g. 'search', 'delete') |
| `Size` | `Size` | No | `Md` | Icon size |
| `Color` | `FlareColor` | No | `Default` | Icon color |
| `Fill` | `bool` | No | `false` | Use filled icon variant |
| `Weight` | `int` | No | `400` | Icon weight (100-700) |
| `Grade` | `int` | No | `0` | Icon grade (-50 to 200) |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback<MouseEventArgs>` | Fired when the icon is clicked |

## Examples

```razor
<FlareIcon Name="search" />
```

```razor
<FlareIcon Name="favorite" Color="FlareColor.Error" Fill="true" />
```

```razor
<FlareIcon Name="settings" Size="Size.Lg" OnClick="OpenSettings" />
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareIcon.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Icon/FlareIcon.razor)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Name` | `string?` | — | Material icon name or FlareIcons constant. |
| `Icon` | `RenderFragment?` | — | Custom SVG icon content (overrides Name). |
| `Size` | `FlareSize?` | — | Size preset. |
| `Color` | `FlareColor` | `Default` | Icon color. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback<MouseEventArgs>` | Click handler. |

```razor
<FlareIcon Name="search" />
<FlareIcon Name="favorite" Color="FlareColor.Error" />
<FlareIcon Name="@FlareIcons.Home" Size="FlareSize.Lg" />
```
