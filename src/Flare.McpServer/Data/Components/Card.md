# FlareCard (Card)

**Category**: DataDisplay
**Tags**: card, container, panel, selectable, layout, elevation
**API Reference**: [https://jrfrigat.github.io/Flare/api/Flare.Components.FlareCard.html](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareCard.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Card container with five visual variants (Elevated/Filled/Outlined/Tonal/Text), selectable state, link mode (Href), compact horizontal layout, and sub-component anatomy (Header/Content/Footer/Actions/Media).

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment?` | No | `` | Child content rendered inside the card. Compose with FlareCardMedia/FlareCardHeader/FlareCardContent/FlareCardFooter/FlareCardActions. |
| `Compact` | `bool` | No | `false` | When true, lays the card out horizontally (media on leading side, content beside it). |
| `Elevation` | `int?` | No | `` | Explicit elevation 0-5. null = variant default (Elevated=1, others flat). |
| `Href` | `string?` | No | `` | When set, the card renders as a link <a> to this URL. |
| `Target` | `string?` | No | `` | Target for link card (e.g. '_blank'). Only with Href. |
| `Selectable` | `bool` | No | `false` | When true, card can be toggled selected (role=checkbox). Shows accent ring. |
| `Selected` | `bool` | No | `false` | Whether a selectable card is selected. Supports @bind-Selected. |
| `Size` | `CardSize` | No | `Md` | Overall size - controls corner radius and inner gap. |
| `Variant` | `CardVariant` | No | `Elevated` | Visual variant: Elevated (default), Filled, Outlined, Tonal, Text. Mirrors ButtonVariant. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback<MouseEventArgs>` | Click handler. When set or Href set, card becomes interactive. |
| `OnSelectionChange` | `EventCallback<bool>` | Fired with new selected state when user toggles selectable card. |

## Sub-Components

- `FlareCardHeader`
- `FlareCardContent`
- `FlareCardActions`
- `FlareCardFooter`
- `FlareCardMedia`

## Examples

```razor
<FlareCard Variant="CardVariant.Elevated">
    <FlareCardHeader><FlareText Typo="TypographyScale.HeadlineMedium">Title</FlareText></FlareCardHeader>
    <FlareCardContent><FlareText>Content</FlareText></FlareCardContent>
    <FlareCardActions><FlareButton Variant="ButtonVariant.Filled">Action</FlareButton></FlareCardActions>
</FlareCard>
```

```razor
<FlareCard Selectable="true" @bind-Selected="_selected">...</FlareCard>
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareCard.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Card/FlareCard.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareCard.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Body content. Compose with FlareCardHeader/Content/Footer/Actions/Media. |
| `Variant` | `CardVariant` | `Elevated` | Visual variant: Elevated, Filled, Outlined, Tonal, Text. |
| `Elevation` | `int?` | — | Explicit elevation 0-5. null = variant default. |
| `Compact` | `bool` | `false` | Horizontal layout (media leading, content beside). |
| `Size` | `CardSize` | `Md` | Overall size - controls corner radius and inner gap. |
| `Selectable` | `bool` | `false` | Toggle selection (role=checkbox, accent ring). |
| `Selected` | `bool` | `false` | Selected state. Supports `@bind-Selected`. |
| `Href` | `string?` | — | Render as link `<a>` to URL. |
| `Target` | `string?` | — | Link target (`_blank`). Only with Href. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback<MouseEventArgs>` | Click handler. Sets role=button, keyboard focus. |
| `OnSelectionChange` | `EventCallback<bool>` | Fired with new selected state. |

## Sub-components

- `FlareCardHeader` - title/header area
- `FlareCardContent` - main body
- `FlareCardActions` - action buttons row
- `FlareCardFooter` - bottom area
- `FlareCardMedia` - image/media embed

```razor
<FlareCard Variant="CardVariant.Elevated">
    <FlareCardHeader><FlareText Typo="TypographyScale.HeadlineMedium">Title</FlareText></FlareCardHeader>
    <FlareCardContent><FlareText>Body content</FlareText></FlareCardContent>
    <FlareCardActions><FlareButton Variant="ButtonVariant.Filled">Action</FlareButton></FlareCardActions>
</FlareCard>
```
