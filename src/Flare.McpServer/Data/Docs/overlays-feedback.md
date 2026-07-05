# FlareSnackbarProvider API

> Source: [FlareSnackbarProvider.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Snackbar/FlareSnackbarProvider.razor)

Place once in layout. Use `ISnackbarService` to show notifications.

```csharp
@inject ISnackbarService Snackbar

Snackbar.Show("Record saved", SnackbarSeverity.Success);
Snackbar.Show("Error occurred", SnackbarSeverity.Error, icon: "error");
```

# FlareTooltip API

> Source: [FlareTooltip.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Tooltip/FlareTooltip.razor)

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Text` | `string` | — | Tooltip text. |
| `Placement` | `TooltipPlacement` | `Top` | Position relative to anchor. |
| `Delay` | `int` | `400` | Show delay ms. |
| `ChildContent` | `RenderFragment` | — | Anchor element. |

```razor
<FlareTooltip Text="Copy" Placement="TooltipPlacement.Top">
    <FlareButton Icon="content_copy" />
</FlareTooltip>
```

# FlarePopover API

> Source: [FlarePopover.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Popover/FlarePopover.razor)

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Open` | `bool` | `false` | `@bind-Open`. |
| `Placement` | `PopoverPlacement` | `Bottom` | Position. |
| `Trigger` | `PopoverTrigger` | `Click` | Click or Hover. |
| `ChildContent` | `RenderFragment?` | — | Trigger + content. |

# FlareMenu API

> Source: [FlareMenu.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Menu/FlareMenu.razor)

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | FlareMenuItem children. |
| `Open` | `bool` | `false` | `@bind-Open`. |
| `Anchor` | `MenuAnchor` | `BottomStart` | Position. |

Sub-components: `FlareMenuItem` (OnClick, Icon, Label), `FlareMenuGroup` (Title), `FlareSubMenu` (nested).

# FlareDrawer API

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Drawer content. |
| `Open` | `bool` | `false` | `@bind-Open`. |
| `Anchor` | `DrawerAnchor` | `Left` | Screen edge. |
| `Variant` | `DrawerVariant` | `Temporary` | Temporary, Persistent, Mini. |
| `Width` | `string?` | — | CSS width. |

# FlarePagination API

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Total` | `int` | `0` | Total items. |
| `PageIndex` | `int` | `0` | Current page. `@bind-PageIndex`. |
| `PageSize` | `int` | `10` | Items per page. |
| `Size` | `PaginationSize` | `Md` | Control size. |

# FlareLink API

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Href` | `string?` | — | URL. |
| `Underline` | `LinkUnderline` | `Hover` | Underline: Hover, Always, None. |
| `Color` | `FlareColor` | `Default` | Link color. |
| `ChildContent` | `RenderFragment?` | — | Link text. |

# FlareDivider API

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Inset` | `DividerInset?` | — | Inset style. |
| `TextAlign` | `DividerTextAlign?` | — | Label alignment. |
| `ChildContent` | `RenderFragment?` | — | Optional label text. |
