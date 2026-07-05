# FlareAvatar

Avatar for user images, initials, or icons with status indicator.

```razor
<FlareAvatar Src="/images/user.png" Alt="User" />
<FlareAvatar Color="FlareColor.Primary">JD</FlareAvatar>
<FlareAvatar Online="true" Src="/images/user.png" Size="Size.Lg" />
```

## Key Parameters
- `Src` - image URL
- `Color` - `FlareColor` for initials background
- `Size` - Xs to Xl
- `Shape` - Circle or Square
- `Online` - bool? green dot indicator
