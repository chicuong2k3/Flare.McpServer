# FlareIcon API

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
