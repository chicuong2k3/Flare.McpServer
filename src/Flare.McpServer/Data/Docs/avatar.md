# FlareAvatar API

> Inherits `FlareComponentBase`  
> Source: [FlareAvatar.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Avatar/FlareAvatar.razor)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Initials or icon content (when no Src). |
| `Src` | `string?` | — | Image URL. |
| `Alt` | `string?` | — | Alt text. |
| `Size` | `AvatarSize` | `Md` | Size: Xs..Xl. |
| `Shape` | `AvatarShape` | `Circle` | Circle or Square. |
| `Color` | `FlareColor` | `Default` | Background color for initials fallback. |
| `Icon` | `string?` | — | Material icon when no Src or ChildContent. |

```razor
<FlareAvatar Src="/user.jpg" Alt="User" />
<FlareAvatar Color="FlareColor.Primary" Size="AvatarSize.Lg">JD</FlareAvatar>
<FlareAvatar Icon="person" Shape="AvatarShape.Square" />
```
