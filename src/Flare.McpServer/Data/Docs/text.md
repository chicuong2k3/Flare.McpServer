# FlareText

Typography component with theme-aware type scales.

```razor
<FlareText Typo="TypographyScale.HeadlineMedium">Page Title</FlareText>
<FlareText Typo="TypographyScale.BodyMedium" Color="FlareColor.OnSurfaceVariant">
    Secondary body text
</FlareText>
<FlareText Typo="TypographyScale.LabelLarge" Truncate="true">
    Very long text that gets truncated with ellipsis...
</FlareText>
```

## Type Scales
- `DisplayLarge` through `DisplaySmall` - hero/dashboard headings
- `HeadlineLarge` through `HeadlineSmall` - page/section headings
- `TitleLarge` through `TitleSmall` - card/dialog titles
- `BodyLarge` through `BodySmall` - body text
- `LabelLarge` through `LabelSmall` - labels/captions

## Key Parameters
- `Typo` - `TypographyScale` preset
- `Color` - `FlareColor` for text color
- `Align` - text alignment
- `Truncate` - ellipsis overflow
- `Nowrap` - prevent wrapping
