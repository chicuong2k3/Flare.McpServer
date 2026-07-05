# FlareTabs (Tabs)

**Category**: Navigation
**Tags**: navigation, tabs, tab, panel, container
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTabs.html](https://jrfrigat.github.io/Flare/api/FlareTabs.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Tabbed navigation container with animated active indicator.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Tab content (FlareTab children) |
| `ActiveTabIndex` | `int` | No | `0` | Gets or sets the active tab index |
| `ActiveTabIndexChanged` | `EventCallback<int>` | No | `` | Callback when active tab changes |
| `Position` | `TabPosition` | No | `Top` | Tab header position |
| `Color` | `FlareColor` | No | `Default` | Color of the active indicator |
| `Centered` | `bool` | No | `false` | Center the tab headers |
| `Border` | `bool` | No | `true` | Show bottom border on headers |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnTabChange` | `EventCallback<int>` | Fired when a tab is selected |

## Sub-Components

- `FlareTab`

## Examples

```razor
<FlareTabs @bind-ActiveTabIndex="_tabIndex">
    <FlareTab Title="General">General content</FlareTab>
    <FlareTab Title="Settings">Settings content</FlareTab>
    <FlareTab Title="Advanced">Advanced content</FlareTab>
</FlareTabs>
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareTabs.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Tabs/FlareTabs.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareTabs.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | `FlareTab` panels. |
| `ActiveIndex` | `int` | — | Zero-based active tab. `@bind-ActiveIndex`. |
| `Variant` | `TabsVariant?` | — | Visual variant (theme override). |
| `Placement` | `TabsPlacement` | `Top` | Tab bar side: Top, Bottom, Left, Right. |
| `Typo` | `TypographyScale?` | — | Type scale for tab labels. |
| `LabelRotation` | `TabLabelRotation` | `None` | Label rotation: 0, 90, 180, 270. |
| `Lazy` | `bool` | `false` | Only render active tab content (unmounts inactive). |
| `HeaderStart` | `RenderFragment?` | — | Content before tabs (title, buttons). |
| `HeaderEnd` | `RenderFragment?` | — | Content after tabs (action buttons). |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnPreviewInteraction` | `EventCallback<TabInteractionEventArgs>` | Before tab change; set Cancel to veto. |
| `OnTabClose` | `EventCallback<string>` | Fired with label of closed tab. |

## Sub-component: FlareTab

| Param | Description |
|-------|-------------|
| `Title` | Tab label text. |
| `Icon` | Optional icon. |
| `Closable` | Show close button. |
| `Disabled` | Disable tab. |

```razor
<FlareTabs @bind-ActiveIndex="_tab" Variant="TabsVariant.Filled" Placement="TabsPlacement.Top">
    <FlareTab Title="General" Icon="settings">General content</FlareTab>
    <FlareTab Title="Advanced" Icon="tune" Closable="true">Advanced content</FlareTab>
</FlareTabs>
```
