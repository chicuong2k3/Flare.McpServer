# FlareStack (Stack)

**Category**: Layout
**Tags**: layout, stack, flex, container, spacing
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareStack.html](https://jrfrigat.github.io/Flare/api/FlareStack.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Flexbox layout component for horizontal or vertical stacking with spacing.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Stack children |
| `Direction` | `StackDirection` | No | `Vertical` | Horizontal or vertical |
| `Spacing` | `string` | No | `0` | Spacing between items (CSS value) |
| `Justify` | `FlexJustify` | No | `Start` | Main axis alignment |
| `Align` | `FlexAlign` | No | `Start` | Cross axis alignment |
| `Wrap` | `bool` | No | `false` | Allow wrapping |

## Examples

```razor
<FlareStack Direction="StackDirection.Vertical" Spacing="1rem">
    <FlareText>Item 1</FlareText>
    <FlareText>Item 2</FlareText>
</FlareStack>
```

```razor
<FlareStack Direction="StackDirection.Horizontal" Spacing="0.5rem" Align="FlexAlign.Center">
    <FlareButton>Save</FlareButton>
    <FlareButton Variant="ButtonVariant.Outlined">Cancel</FlareButton>
</FlareStack>
```

---

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
