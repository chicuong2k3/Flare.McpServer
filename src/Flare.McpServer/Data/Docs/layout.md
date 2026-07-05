# FlareGrid / FlareStack API

> Inherit `FlareComponentBase`

## FlareGrid

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | `FlareCol` children. |
| `Columns` | `int` | `12` | Grid column count. |
| `Gap` | `FlareSpacing?` | — | Gap between items. |

## FlareCol

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Span` | `int?` | — | Column span. |
| `SpanSm`/`SpanMd`/`SpanLg`/`SpanXl` | `int?` | — | Responsive span overrides. |
| `Offset` | `int?` | — | Column offset. |

## FlareStack

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Stack children. |
| `Direction` | `string` | `"Vertical"` | Vertical or Horizontal. |
| `Spacing` | `FlareSpacing?` | — | Gap between children. |
| `Align` | `FlareAlignItems?` | — | Cross-axis alignment. |
| `Justify` | `FlareJustifyContent?` | — | Main-axis alignment. |

## FlareSpacer

Fills remaining space in a flex container. No parameters.

```razor
<FlareGrid Gap="FlareSpacing.Md">
    <FlareCol Span="6" SpanMd="4">Left</FlareCol>
    <FlareCol Span="6" SpanMd="8">Right</FlareCol>
</FlareGrid>

<FlareStack Spacing="FlareSpacing.Sm" Align="FlareAlignItems.Center">
    <FlareText>Start</FlareText>
    <FlareSpacer />
    <FlareButton>End</FlareButton>
</FlareStack>
```
