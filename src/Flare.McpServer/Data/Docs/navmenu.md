# FlareNavMenu API

> Inherits `FlareComponentBase`  
> Source: [FlareNavMenu.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Nav/FlareNavMenu.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareNavMenu.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Nav items: FlareNavLink, FlareNavGroup. |
| `Header` | `RenderFragment?` | — | Pinned top area. Enables framed layout. |
| `Footer` | `RenderFragment?` | — | Pinned bottom area. |
| `Mode` | `NavMenuMode?` | — | Full or Rail presentation. Overrides Rail. |
| `Rail` | `bool` | `false` | Mini-rail: icons only, text hidden. Auto with `DrawerVariant.Mini`. |
| `HideScrollbar` | `bool` | `false` | Scroll but hide scrollbar. |
| `AriaLabel` | `string?` | — | Accessible nav landmark label. |

## Sub-components

| Component | Description |
|-----------|-------------|
| `FlareNavLink` | Link with Href, Icon, Title, Badge. Active matching via `NavMatchMode`. |
| `FlareNavGroup` | Collapsible group with Title, Icon. Nests FlareNavLink children. Auto-expands when child active. |

```razor
<FlareNavMenu>
    <FlareNavLink Href="/" Icon="home" Title="Home" />
    <FlareNavGroup Title="Reports" Icon="analytics">
        <FlareNavLink Href="/reports/sales" Title="Sales" />
        <FlareNavLink Href="/reports/users" Title="Users" />
    </FlareNavGroup>
    <Footer>
        <FlareNavLink Href="/settings" Icon="settings" Title="Settings" />
    </Footer>
</FlareNavMenu>
```
