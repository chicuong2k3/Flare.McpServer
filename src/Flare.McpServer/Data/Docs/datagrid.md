# FlareDataGrid\<TItem\> API

> Inherits `FlareComponentBase`  
> Source: [FlareDataGrid.Bands.cs](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/DataGrid/FlareDataGrid.Bands.cs) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareDataGrid-1.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Items` | `IEnumerable<TItem>?` | — | In-memory data source. |
| `ItemsProvider` | `Func<DataGridRequest,Task<DataGridResult<TItem>>>?` | — | Server-side data provider. |
| `Columns` | `RenderFragment?` | — | `FlareColumn` child descriptors. |
| `CurrentPageIndex` | `int` | 0 | Zero-based current page. |
| `PageSize` | `int` | 10 | Rows per page. |
| `SelectionMode` | `DataGridSelectionMode` | `None` | None, Single, Multiple. |
| `SelectedItems` | `IEnumerable<TItem>?` | — | Selected items. `@bind-SelectedItems`. |
| `EditMode` | `DataGridEditMode` | `None` | None, Inline (row), Cell. |
| `FilterMode` | `DataGridFilterMode` | `Simple` | Simple text, Menu dropdowns, Both. |
| `QuickFilter` | `Func<TItem,bool>?` | — | Global predicate applied after column filters. |
| `SortByAsync` | method | — | Apply sort command programmatically. |
| `FilterByAsync` | method | — | Apply filter command programmatically. |
| `Dense` | `bool` | `false` | Compact row height. |
| `Bordered` | `bool` | `false` | Vertical borders between columns. |
| `Hoverable` | `bool` | `false` | Highlight row on hover. |
| `Striped` | `bool` | `false` | Alternating row colors. |
| `Height` | `string?` | — | CSS height. Works with or without virtualization. |
| `Virtual` | `bool` | `false` | Virtual scrolling (no pagination). |
| `VirtualItemSize` | `int?` | — | Row height px. null = auto-detect via ResizeObserver. |
| `OverscanCount` | `int?` | 20 | Extra rows above/below for smooth scroll. |
| `Grouping` | `RenderFragment?` | — | `DataGridGroup<TItem>` nested declarations. |
| `Aggregates` | `IEnumerable<AggregateDefinition<TItem>>?` | — | Footer row: Sum/Count/Average/Min/Max. |
| `Tree` | `DataGridTreeConfig<T>?` | — | Tree-grid config with ChildrenSelector. |
| `CellSelection` | `bool` | `false` | Excel-like cell-range selection + Ctrl+C/V. |
| `RowReorderable` | `bool` | `false` | Drag-and-drop row reorder. |
| `ReorderableColumns` | `bool` | `false` | Drag-and-drop column reorder. |
| `ShowColumnPicker` | `bool` | `false` | Built-in "Columns" toggle button. |
| `ShowPager` | `bool` | `true` | Show built-in pager below table. |
| `RowsPerPageOptions` | `int[]` | — | Page size choices. Empty = hide selector. |
| `PersistStateKey` | `string?` | — | localStorage key for sort/filter/column state. |
| `LoadingIndicator` | `DataGridLoadingIndicator` | `Circular` | How loading appears: ring, skeleton, text. |
| `RowDetailTemplate` | `RenderFragment<TItem>?` | — | Expandable detail row below each row. |
| `ToolbarContent` | `RenderFragment?` | — | Custom toolbar area above table. |
| `FooterContent` | `RenderFragment?` | — | Custom footer below table. |
| `EmptyStateContent` | `RenderFragment?` | — | Shown when no data rows. |
| `RowClick` | `EventCallback<TItem>` | — | Row click handler. |
| `RowClassFunc` | `Func<TItem,string?>?` | — | Extra CSS per row (conditional formatting). |
| `RowStyleFunc` | `Func<TItem,string?>?` | — | Inline style per row. |
| `PinnedTopRows` | `IEnumerable<TItem>?` | — | Frozen top rows. |
| `PinnedBottomRows` | `IEnumerable<TItem>?` | — | Frozen bottom rows. |

## Key Events

| Name | Description |
|------|-------------|
| `OnStateChanged` | Raised after any sort/filter/group/page change. |
| `OnSortChanged` | Raised with active sorts in apply order. |
| `OnFilterChanged` | Raised with full structured filter model. |
| `OnPageChanged` | Raised when page index changes. |
| `OnRowSaved` | Inline edit row saved. |
| `OnBatchSave` | Batch edit saved with all edited items. |
| `OnPaste` | Ctrl+V in cell-selection mode. |
| `OnRowReordered` | After drag-drop row reorder. |

## Sub-components

- `FlareColumn<TItem>` - column definition with Field, Title, Sortable, Filterable, Align
- `FlareColumnBand` - grouped header columns
- `FlareColumnRow` - multi-row headers
- `FlareDataGridPager<TItem>` - standalone pager
- `FlareDataGridQuickFilter<TItem>` - global search input
- `FlareDataGridFilterPresets<TItem>` - saved filter presets

## Usage

```razor
<FlareDataGrid Items="_people" Filterable="true" Sortable="true" Pageable="true" Striped="true">
    <FlareColumn Field="@nameof(Person.Name)" Title="Name" Sortable="true" />
    <FlareColumn Field="@nameof(Person.Age)" Title="Age" Align="ColumnAlign.End" />
    <FlareColumn Field="@nameof(Person.Email)" Title="Email" />
</FlareDataGrid>
```
