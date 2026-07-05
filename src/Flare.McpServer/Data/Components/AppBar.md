# FlareAppBar (AppBar)

**Category**: Navigation
**Tags**: header, appbar, navigation, toolbar, topbar
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareAppBar.html](https://jrfrigat.github.io/Flare/api/FlareAppBar.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Top app bar with navigation toggle, title, actions, and sticky/scroll behavior.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | App bar content |
| `Title` | `string` | No | `` | Title text |
| `TitleTemplate` | `RenderFragment` | No | `` | Custom title content |
| `ActionsTemplate` | `RenderFragment` | No | `` | Action buttons area |
| `NavigationTemplate` | `RenderFragment` | No | `` | Navigation/menu toggle area |
| `Sticky` | `bool` | No | `false` | Stick to top on scroll |
| `Elevation` | `int` | No | `2` | Shadow elevation (0-6) |
| `Color` | `FlareColor` | No | `Default` | App bar color |

## Examples

```razor
<FlareAppBar Title="Dashboard" Sticky="true">
    <NavigationTemplate>
        <FlareButton Icon="menu" OnClick="ToggleDrawer" />
    </NavigationTemplate>
    <ActionsTemplate>
        <FlareButton Icon="notifications" />
        <FlareAvatar Src="/avatar.png" />
    </ActionsTemplate>
</FlareAppBar>
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareAppBar.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/AppBar/FlareAppBar.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareAppBar.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Title` | `string?` | — | Plain-text title. |
| `TitleContent` | `RenderFragment?` | — | Custom title area content. |
| `Leading` | `RenderFragment?` | — | Left edge content (menu toggle). |
| `Trailing` | `RenderFragment?` | — | Right edge content (actions). |
| `Elevation` | `int` | `4` | Shadow level 0-5. |
| `Dense` | `bool` | `false` | Reduced height. |
| `Sticky` | `bool` | `false` | Stick to top of viewport. |
| `AriaLabel` | `string?` | — | Header landmark label. |

```razor
<FlareAppBar Title="Dashboard" Sticky="true">
    <Leading><FlareButton Icon="menu" OnClick="ToggleDrawer" /></Leading>
    <Trailing>
        <FlareButton Icon="notifications" />
        <FlareAvatar Src="/avatar.png" Size="AvatarSize.Sm" />
    </Trailing>
</FlareAppBar>
```
