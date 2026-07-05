# FlareMenuBar (MenuBar)

**Category**: Navigation
**Tags**: menubar, menu, desktop, toolbar
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareMenuBar.html](https://jrfrigat.github.io/Flare/api/FlareMenuBar.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Horizontal menu bar with drop-down menus, similar to desktop application menus.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | MenuBar items |

## Examples

```razor
<FlareMenuBar>
    <FlareMenuItem>File</FlareMenuItem>
    <FlareMenuItem>Edit</FlareMenuItem>
    <FlareMenuItem>View</FlareMenuItem>
</FlareMenuBar>
```

