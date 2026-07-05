# FlareGrid (Grid)

**Category**: Layout
**Tags**: layout, grid, columns, responsive, flex
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareGrid.html](https://jrfrigat.github.io/Flare/api/FlareGrid.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

CSS grid layout component with responsive column spans and gutters.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Grid children (FlareCol) |
| `Columns` | `int` | No | `12` | Number of grid columns |
| `Gap` | `string` | No | `` | Gap between grid items (CSS value) |
| `Justify` | `GridJustify` | No | `Start` | Horizontal alignment |
| `Align` | `GridAlign` | No | `Start` | Vertical alignment |

## Sub-Components

- `FlareCol`

## Examples

```razor
<FlareGrid Columns="12" Gap="1rem">
    <FlareCol Span="6" SpanMd="4">Column 1</FlareCol>
    <FlareCol Span="6" SpanMd="8">Column 2</FlareCol>
</FlareGrid>
```

---

CSS grid layout with responsive column spans.

```razor
<FlareGrid Columns="12" Gap="1rem">
    <FlareCol Span="6" SpanMd="4">Left column</FlareCol>
    <FlareCol Span="6" SpanMd="8">Right column</FlareCol>
</FlareGrid>
```

## Key Parameters
- `Columns` - grid column count (default 12)
- `Gap` - spacing between cells
- `Justify` - horizontal alignment
- `Align` - vertical alignment

## FlareCol Parameters
- `Span` - column width (1-12)
- `SpanSm`, `SpanMd`, `SpanLg`, `SpanXl` - responsive spans
