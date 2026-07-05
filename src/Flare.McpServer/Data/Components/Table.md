# FlareTable (Table)

**Category**: DataDisplay
**Tags**: data, table, display, rows, columns
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTable.html](https://jrfrigat.github.io/Flare/api/FlareTable.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Simple read-only table with themed styling, less feature-rich than DataGrid.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Items` | `IEnumerable<TItem>` | Yes | `` | Table rows |
| `ChildContent` | `RenderFragment` | Yes | `` | Column definitions |
| `Hoverable` | `bool` | No | `false` | Highlight row on hover |
| `Striped` | `bool` | No | `false` | Alternate row colors |

## Examples

```razor
<FlareTable Items="_items" Striped="true">
    <FlareColumn Field="Name" Title="Name" />
    <FlareColumn Field="Value" Title="Value" />
</FlareTable>
```

