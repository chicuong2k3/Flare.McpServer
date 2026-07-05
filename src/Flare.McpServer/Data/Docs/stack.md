# FlareStack

Flexbox layout for horizontal or vertical stacking with spacing.

```razor
<FlareStack Direction="StackDirection.Vertical" Spacing="1rem">
    <FlareText>Item 1</FlareText>
    <FlareText>Item 2</FlareText>
</FlareStack>

<FlareStack Direction="StackDirection.Horizontal" Spacing="0.5rem" Align="FlexAlign.Center">
    <FlareButton>Save</FlareButton>
    <FlareButton Variant="ButtonVariant.Outlined">Cancel</FlareButton>
</FlareStack>
```

## Key Parameters
- `Direction` - Vertical or Horizontal
- `Spacing` - gap between items (CSS value)
- `Justify` - main axis alignment
- `Align` - cross axis alignment
- `Wrap` - allow wrapping
