# FlareAppBar API

> Inherits `FlareComponentBase`  
> Source: [FlareAppBar.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/AppBar/FlareAppBar.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareAppBar.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Title` | `string?` | — | Plain-text title. |
| `TitleContent` | `RenderFragment?` | — | Custom title area content. |
| `Leading` | `RenderFragment?` | — | Left edge content (menu toggle). |
| `Trailing` | `RenderFragment?` | — | Right edge content (actions). |
| `Elevation` | `int` | `4` | Shadow level 0-5. |
| `Dense` | `bool` | `false` | Reduced height. |
| `Sticky` | `bool` | `false` | Stick to top of viewport. |
| `AriaLabel` | `string?` | — | Header landmark label. |

```razor
<FlareAppBar Title="Dashboard" Sticky="true">
    <Leading><FlareButton Icon="menu" OnClick="ToggleDrawer" /></Leading>
    <Trailing>
        <FlareButton Icon="notifications" />
        <FlareAvatar Src="/avatar.png" Size="AvatarSize.Sm" />
    </Trailing>
</FlareAppBar>
```
