# FlareTabs API

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
