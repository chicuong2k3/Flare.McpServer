# FlareButton API

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
