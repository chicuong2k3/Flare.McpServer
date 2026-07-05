# FlareAppBar

Top app bar with navigation toggle, title, actions, and sticky behavior.

```razor
<FlareAppBar Title="Dashboard" Sticky="true">
    <NavigationTemplate>
        <FlareButton Icon="menu" OnClick="ToggleDrawer" />
    </NavigationTemplate>
    <ActionsTemplate>
        <FlareButton Icon="notifications" />
        <FlareAvatar Src="/avatar.png" Size="Size.Sm" />
    </ActionsTemplate>
</FlareAppBar>
```

## Key Parameters
- `Title` - app bar title text
- `Sticky` - stick to top on scroll
- `Elevation` - shadow depth (0-6)
- `Color` - `FlareColor` for background

## Templates
- `NavigationTemplate` - menu toggle area (start)
- `ActionsTemplate` - action buttons (end)
- `TitleTemplate` - custom title content
