# FlareAvatar (Avatar)

**Category**: Display
**Tags**: avatar, profile, image, user, initials, icon
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareAvatar.html](https://jrfrigat.github.io/Flare/api/FlareAvatar.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Avatar component for user profile images, initials, or icons with grouping support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Initials or icon content |
| `Src` | `string` | No | `` | Image source URL |
| `Alt` | `string` | No | `` | Alt text for the image |
| `Size` | `Size` | No | `Md` | Avatar size |
| `Color` | `FlareColor` | No | `Default` | Background color for initials |
| `Shape` | `AvatarShape` | No | `Circle` | Circle or square shape |
| `Online` | `bool?` | No | `` | Show online/offline status indicator |

## Examples

```razor
<FlareAvatar Src="/images/user.png" Alt="User" />
```

```razor
<FlareAvatar Color="FlareColor.Primary">JD</FlareAvatar>
```

```razor
<FlareAvatar Online="true" Src="/images/user.png" Size="Size.Lg" />
```

---

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
