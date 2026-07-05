# FlareMenu

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
