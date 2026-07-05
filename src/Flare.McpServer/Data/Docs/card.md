# FlareCard

Card container with header, content, actions, footer, and media sections.

```razor
<FlareCard>
    <FlareCardHeader>
        <FlareText Typo="TypographyScale.HeadlineMedium">Title</FlareText>
    </FlareCardHeader>
    <FlareCardContent>
        <FlareText Typo="TypographyScale.BodyMedium">Content here</FlareText>
    </FlareCardContent>
    <FlareCardActions>
        <FlareButton Variant="ButtonVariant.Filled">Action</FlareButton>
    </FlareCardActions>
</FlareCard>
```

## Key Parameters
- `Elevation` - shadow depth (0-6)
- `Outlined` - use outlined border style
- `OnClick` - make entire card clickable

## Sub-components
- `FlareCardHeader` - top section (title area)
- `FlareCardContent` - main body content
- `FlareCardActions` - action buttons area
- `FlareCardFooter` - bottom section
- `FlareCardMedia` - image/media embed
