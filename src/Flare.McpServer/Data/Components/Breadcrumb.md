# FlareBreadcrumb (Breadcrumb)

**Category**: Navigation
**Tags**: breadcrumb, navigation, trail, path, hierarchy
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareBreadcrumb.html](https://jrfrigat.github.io/Flare/api/FlareBreadcrumb.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Breadcrumb navigation trail showing the current page's location in the hierarchy.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Items` | `IEnumerable<BreadcrumbItem>` | Yes | `` | Breadcrumb trail items |
| `SeparatorTemplate` | `RenderFragment` | No | `` | Custom separator between items |

## Examples

```razor
<FlareBreadcrumb Items="_breadcrumbs" />
```

---

Navigation trail showing location in hierarchy.

```razor
<FlareBreadcrumb Items="_breadcrumbs" />
```

## Key Parameters
- `Items` - `IEnumerable<BreadcrumbItem>` trail items
