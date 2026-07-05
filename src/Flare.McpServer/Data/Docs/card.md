# FlareCard API

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
