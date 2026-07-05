# FlareGrid

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
