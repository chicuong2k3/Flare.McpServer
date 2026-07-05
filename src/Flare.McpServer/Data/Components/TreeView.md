# FlareTreeView (TreeView)

**Category**: DataDisplay
**Tags**: data, tree, hierarchy, folder, expand, collapse
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTreeView.html](https://jrfrigat.github.io/Flare/api/FlareTreeView.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Hierarchical tree view with expand/collapse, checkboxes, drag-and-drop, and lazy loading.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Items` | `IEnumerable<TItem>` | Yes | `` | Tree data |
| `ChildrenSelector` | `Func<TItem, IEnumerable<TItem>>` | Yes | `` | Get child items |
| `Selectable` | `bool` | No | `false` | Enable node selection |
| `Draggable` | `bool` | No | `false` | Enable drag and drop |

## Examples

```razor
<FlareTreeView Items="_treeData" ChildrenSelector="item => item.Children" Selectable="true" />
```

