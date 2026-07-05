# FlarePagination

Page navigation with page size control.

```razor
<FlarePagination Total="100" @bind-PageIndex="_page" PageSize="10" ShowPageSize="true" />
```

## Key Parameters
- `Total` - total item count
- `PageIndex` / `@bind-PageIndex` - current page (0-based)
- `PageSize` - items per page
- `ShowPageSize` - page size selector
- `Color` - `FlareColor` accent
