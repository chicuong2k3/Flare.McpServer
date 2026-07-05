# FlareText API

> Inherits `FlareComponentBase`  
> Source: [FlareText.cs](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Text/FlareText.cs)

Renders a semantic HTML element (h1-h5, p) styled with the active theme's type scale.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Text content. |
| `Typo` | `TypographyScale?` | `BodyMedium` | Type scale preset. |
| `Color` | `FlareColor` | `Default` | Text color. |
| `Align` | `TextAlign` | `Default` | Text alignment. |
| `Weight` | `FontWeight` | `Default` | Font weight override. |
| `Truncate` | `bool` | `false` | Ellipsis overflow. |
| `Nowrap` | `bool` | `false` | Prevent wrapping. |

```razor
<FlareText Typo="TypographyScale.HeadlineMedium">Page Title</FlareText>
<FlareText Typo="TypographyScale.BodyMedium" Color="FlareColor.OnSurfaceVariant">Secondary text</FlareText>
<FlareText Typo="TypographyScale.LabelLarge" Truncate="true">Long truncated text…</FlareText>
```
