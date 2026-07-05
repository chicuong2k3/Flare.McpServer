# FlareDrawer (Drawer)

**Category**: Overlays
**Tags**: drawer, sidebar, panel, overlay, navigation, slide
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDrawer.html](https://jrfrigat.github.io/Flare/api/FlareDrawer.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Slide-out drawer panel from any screen edge for navigation or content.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Drawer content |
| `Visible` | `bool` | No | `false` | Gets or sets drawer open state |
| `VisibleChanged` | `EventCallback<bool>` | No | `` | Callback when open state changes |
| `Position` | `Placement` | No | `Left` | Edge the drawer slides from |
| `Width` | `string` | No | `280px` | Drawer width (CSS value) |
| `Modal` | `bool` | No | `true` | Show backdrop behind the drawer |
| `CloseOnOverlayClick` | `bool` | No | `true` | Close when clicking backdrop |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnOpen` | `EventCallback` | Fired when the drawer opens |
| `OnClose` | `EventCallback` | Fired when the drawer closes |

## Examples

```razor
<FlareDrawer @bind-Visible="_open" Position="Placement.Left" Width="300px">
    <FlareNavMenu>
        <FlareNavLink Href="/" Title="Home" />
    </FlareNavMenu>
</FlareDrawer>
```

---

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
