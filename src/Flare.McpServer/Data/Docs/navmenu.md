# FlareNavMenu

Navigation menu with nested groups, links, and auto-expand for active routes.

```razor
<FlareNavMenu>
    <FlareNavLink Href="/" Icon="home" Title="Home" />
    <FlareNavGroup Title="Reports" Icon="analytics">
        <FlareNavLink Href="/reports/sales" Title="Sales" />
        <FlareNavLink Href="/reports/users" Title="Users" />
    </FlareNavGroup>
</FlareNavMenu>
```

## Key Parameters
- `Collapsed` - collapse the menu
- `Rail` - slim icon-only rail mode
- `Top` / `Bottom` - pinned content templates

## Sub-components
- `FlareNavGroup` - collapsible group with nested links
- `FlareNavLink` - individual navigation link with icon
