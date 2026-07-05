# FlareButton (Button)

**Category**: Buttons
**Tags**: button, action, click, form, submit, icon, link
**API Reference**: [https://jrfrigat.github.io/Flare/api/Flare.Components.FlareButton.html](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareButton.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Highly customizable button with five visual variants (Filled/Outlined/Text/Elevated/Tonal), leading/trailing icons, loading state with spinner, link mode via Href, press-morph animation, and color support via FlareColor.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment?` | No | `` | Button label and inner content. |
| `LeadingIcon` | `RenderFragment?` | No | `` | Icon rendered before the button label. |
| `TrailingIcon` | `RenderFragment?` | No | `` | Icon rendered after the button label. |
| `Variant` | `ButtonVariant` | No | `Filled` | Visual style variant: Filled, Outlined, Text, Elevated, Tonal. |
| `Size` | `ButtonSize` | No | `Md` | Size: Xs, Sm, Md, Lg, Xl. |
| `Shape` | `ButtonShape` | No | `Default` | Corner shape: Default (theme native), Rounded, Circular, Square. |
| `Typo` | `TypographyScale?` | No | `` | Overrides label typography. Null keeps size default. |
| `Color` | `FlareColor` | No | `Default` | Button color. Semantic preset or Custom("#FF0000"). |
| `OnColor` | `string?` | No | `` | Optional foreground color for filled variant when Color is custom. |
| `Disabled` | `bool` | No | `false` | Disables the button when true. |
| `Type` | `ButtonType` | No | `Button` | HTML button type: Button, Submit, Reset. |
| `Loading` | `bool` | No | `false` | Shows a spinner and disables the button when true. |
| `LoadingText` | `string?` | No | `` | Replaces button label text while Loading is true. |
| `PressMorph` | `bool` | No | `false` | Opt-in: corner radius animates while pressed. |
| `FullWidth` | `bool` | No | `false` | Stretches button to full container width. |
| `Href` | `string?` | No | `` | When set, renders as a link <a> to this URL. |
| `Target` | `string?` | No | `` | Target for link button (e.g. _blank). Only with Href. |
| `AriaLabel` | `string?` | No | `` | Accessible label, forwarded as aria-label. |
| `AriaPressed` | `bool` | No | `false` | Indicates pressed state for toggle buttons. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback<MouseEventArgs>` | Callback invoked when the button is clicked. |

## Examples

```razor
<FlareButton Variant="ButtonVariant.Filled" OnClick="Save">Save</FlareButton>
```

```razor
<FlareButton Variant="ButtonVariant.Outlined" LeadingIcon="@DeleteIcon">Delete</FlareButton>
```

```razor
<FlareButton Variant="ButtonVariant.Filled" Loading="true" LoadingText="Saving...">Save</FlareButton>
```

```razor
<FlareButton Href="/docs" Variant="ButtonVariant.Text">Docs</FlareButton>
```

---

> Inherits `FlareComponentBase` → Implements `IFlareButton`  
> Source: [FlareButton.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Button/FlareButton.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareButton.html)

---

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Button label and inner content. |
| `LeadingIcon` | `RenderFragment?` | — | Icon rendered before the button label. |
| `TrailingIcon` | `RenderFragment?` | — | Icon rendered after the button label. |
| `Variant` | `ButtonVariant` | `Filled` | Visual style: Filled, Outlined, Text, Elevated, Tonal. |
| `Size` | `ButtonSize` | `Md` | Size: Xs, Sm, Md, Lg, Xl. |
| `Shape` | `ButtonShape` | `Default` | Corner shape: Default (theme native), Rounded, Circular, Square. |
| `Typo` | `TypographyScale?` | — | Overrides label typography. Null keeps the size-based default. |
| `Color` | `FlareColor` | `Default` | Color: semantic preset (`FlareColor.Primary`) or custom (`FlareColor.Custom("#FF0000")`). |
| `OnColor` | `string?` | — | Optional foreground color for filled variant when Color is custom. |
| `Disabled` | `bool` | `false` | Disables the button when true. |
| `Type` | `ButtonType` | `Button` | HTML type: Button, Submit, Reset. |
| `Loading` | `bool` | `false` | Shows a spinner and disables the button when true. |
| `LoadingText` | `string?` | — | Replaces button label text while Loading is true. |
| `PressMorph` | `bool` | `false` | Opt-in: corner radius animates while pressed. |
| `FullWidth` | `bool` | `false` | Stretches button to full container width. |
| `Href` | `string?` | — | When set, renders as `<a>` link. Disabled/Loading removes href. |
| `Target` | `string?` | — | Target for link button (`_blank`). Only with Href. |
| `AriaLabel` | `string?` | — | Accessible label, forwarded as `aria-label`. |
| `AriaPressed` | `bool` | `false` | Indicates pressed state for toggle buttons (`aria-pressed`). |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback<MouseEventArgs>` | Callback invoked when the button is clicked. |

## Inherited from FlareComponentBase

| Name | Type | Description |
|------|------|-------------|
| `Class` | `string?` | Additional CSS classes on root element. |
| `Style` | `string?` | Inline style. |
| `AdditionalAttributes` | `Dictionary<string,object>?` | HTML attribute pass-through. |

## ButtonGroup Integration

When placed inside a `FlareButtonGroup`, cascaded `FlareButtonGroupContext` overrides `Variant`, `Size`, and `Color` from the group.

## Usage

```razor
<FlareButton Variant="ButtonVariant.Filled" OnClick="Save">Save</FlareButton>
<FlareButton Variant="ButtonVariant.Outlined" LeadingIcon="@DeleteIcon" Color="FlareColor.Error">Delete</FlareButton>
<FlareButton Variant="ButtonVariant.Tonal" Loading="true" LoadingText="Saving...">Save</FlareButton>
<FlareButton Href="/docs" Target="_blank" Variant="ButtonVariant.Text">Documentation</FlareButton>
<FlareButton Shape="ButtonShape.Circular" LeadingIcon="@AddIcon" AriaLabel="Add item" />
```
