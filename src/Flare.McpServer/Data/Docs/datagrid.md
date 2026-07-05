# FlareDataGrid

Advanced data grid with sorting, filtering, paging, grouping, virtualization, column resize, row selection, inline editing, and CSV export.

```razor
<FlareDataGrid Items="_people" Filterable="true" Sortable="true" Pageable="true">
    <FlareColumn Field="@nameof(Person.Name)" Title="Name" />
    <FlareColumn Field="@nameof(Person.Age)" Title="Age" Align="ColumnAlign.End" />
    <FlareColumn Field="@nameof(Person.Email)" Title="Email" />
</FlareDataGrid>
```

## Key Parameters
- `Items` - collection of data items (required)
- `Filterable` - per-column filter inputs
- `Sortable` - click-to-sort columns
- `Pageable` - pagination with configurable PageSize
- `Virtualize` - row virtualization for large datasets
- `Groupable` - drag-to-group columns
- `Selectable` - row selection with checkboxes
- `EditMode` - Inline or Batch editing
- `Resizable`, `Reorderable` - column manipulation

## Sub-components
- `FlareColumn` - define table columns
- `FlareColumnBand` - grouped column headers
- `FlareColumnRow` - multi-row headers
