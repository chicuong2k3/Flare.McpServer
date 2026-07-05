# FlareDrawer

Slide-out drawer from any screen edge with backdrop.

```razor
<FlareDrawer @bind-Visible="_open" Position="Placement.Left" Width="300px">
    <FlareNavMenu>
        <FlareNavLink Href="/" Title="Home" />
    </FlareNavMenu>
</FlareDrawer>
```

## Key Parameters
- `Visible` / `@bind-Visible` - open state
- `Position` - edge (Left, Right, Top, Bottom)
- `Width` - drawer width (CSS value)
- `Modal` - show backdrop
- `CloseOnOverlayClick` - dismiss on backdrop click
