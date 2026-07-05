# FlarePagination (Pagination)

**Category**: Navigation
**Tags**: pagination, page, navigation, pager
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlarePagination.html](https://jrfrigat.github.io/Flare/api/FlarePagination.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Pagination component with page buttons, ellipsis, first/last navigation, and page size control.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Total` | `int` | Yes | `0` | Total number of items |
| `PageIndex` | `int` | No | `0` | Current page (0-based) |
| `PageIndexChanged` | `EventCallback<int>` | No | `` | Callback when page changes |
| `PageSize` | `int` | No | `10` | Items per page |
| `ShowPageSize` | `bool` | No | `false` | Show page size selector |
| `Color` | `FlareColor` | No | `Default` | Color accent |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnPageChanged` | `EventCallback<int>` | Fired when the page changes |

## Examples

```razor
<FlarePagination Total="100" @bind-PageIndex="_page" PageSize="10" ShowPageSize="true" />
```

---

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
