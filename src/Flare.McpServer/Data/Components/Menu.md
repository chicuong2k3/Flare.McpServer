# FlareMenu (Menu)

**Category**: Navigation
**Tags**: menu, dropdown, context menu, navigation
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareMenu.html](https://jrfrigat.github.io/Flare/api/FlareMenu.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Dropdown menu component with items, groups, submenus, and keyboard navigation.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | MenuItem children |
| `Open` | `bool` | No | `false` | Gets or sets menu open state |
| `OpenChanged` | `EventCallback<bool>` | No | `` | Callback when open state changes |
| `Position` | `Placement` | No | `BottomStart` | Menu position relative to anchor |

## Sub-Components

- `FlareMenuItem`
- `FlareMenuGroup`
- `FlareSubMenu`

## Examples

```razor
<FlareMenu>
    <FlareMenuItem OnClick="Edit">Edit</FlareMenuItem>
    <FlareMenuItem OnClick="Copy">Copy</FlareMenuItem>
    <FlareSubMenu Title="Share">
        <FlareMenuItem>Email</FlareMenuItem>
        <FlareMenuItem>Link</FlareMenuItem>
    </FlareSubMenu>
</FlareMenu>
```

---

Dropdown menu with items, groups, and submenus.

```razor
<FlareMenu>
    <FlareMenuItem OnClick="Edit">Edit</FlareMenuItem>
    <FlareMenuItem OnClick="Share">Share</FlareMenuItem>
    <FlareMenuGroup Title="More">
        <FlareMenuItem>Export</FlareMenuItem>
        <FlareMenuItem>Import</FlareMenuItem>
    </FlareMenuGroup>
</FlareMenu>
```

## Key Parameters
- `Open` / `@bind-Open` - menu visibility
- `Position` - Placement relative to anchor
