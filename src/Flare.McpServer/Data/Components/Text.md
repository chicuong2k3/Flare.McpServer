# FlareText (Text)

**Category**: Display
**Tags**: text, typography, title, heading, paragraph
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareText.html](https://jrfrigat.github.io/Flare/api/FlareText.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Typography component for rendering text with theme-aware type scales and colors.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Text content |
| `Typo` | `TypographyScale` | No | `BodyMedium` | Typography scale preset |
| `Color` | `FlareColor` | No | `Default` | Text color |
| `Align` | `TextAlign` | No | `Start` | Text alignment |
| `Truncate` | `bool` | No | `false` | Truncate overflow with ellipsis |
| `Nowrap` | `bool` | No | `false` | Prevent text wrapping |

## Examples

```razor
<FlareText Typo="TypographyScale.HeadlineMedium">Page Title</FlareText>
```

```razor
<FlareText Typo="TypographyScale.BodyMedium" Color="FlareColor.OnSurfaceVariant">Secondary text</FlareText>
```

---

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
