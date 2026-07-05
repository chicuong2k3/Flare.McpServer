# FlareSelect

Dropdown select component with search, clear, and item templates.

```razor
<FlareSelect @bind-Value="_role" Label="Role" Items="_roles" />
<FlareSelect @bind-Value="_color" Label="Color" Items="_colors" Searchable="true" Clearable="true" />
```

## Key Parameters
- `Items` - collection of selectable values (required)
- `Value` / `@bind-Value` - two-way selection binding
- `Searchable` - enable text search/filter
- `Clearable` - show clear/reset button
- `ItemTemplate` - custom rendering for dropdown items
- `ValueTemplate` - custom rendering for selected value
- `Label`, `Placeholder`, `Color`, `Variant` - standard field params
