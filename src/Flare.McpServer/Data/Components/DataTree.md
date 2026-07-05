# FlareDataTree (DataTree)

**Category**: DataDisplay
**Tags**: tree, data, hierarchy, folder
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDataTree.html](https://jrfrigat.github.io/Flare/api/FlareDataTree.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Tree view for arbitrary data with lazy loading, checkboxes, and icons.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Items` | `IEnumerable<TItem>` | Yes | `` | Root nodes |
| `ChildrenSelector` | `Func<TItem, IEnumerable<TItem>>` | Yes | `` | Get children |
| `ItemTemplate` | `RenderFragment<TItem>` | No | `` | Node template |

## Examples

```razor
<FlareDataTree Items="_nodes" ChildrenSelector="n => n.Children"><ItemTemplate>@context.Name</ItemTemplate></FlareDataTree>
```

