# FlareSplitButton (SplitButton)

**Category**: Buttons
**Tags**: button, split, dropdown, menu, actions
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSplitButton.html](https://jrfrigat.github.io/Flare/api/FlareSplitButton.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Button with a dropdown menu for additional actions. Main action + more options pattern.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Text` | `string` | No | `` | Main button label |
| `Variant` | `ButtonVariant` | No | `Filled` | Visual variant |
| `Color` | `FlareColor` | No | `Default` | Button color |
| `MenuItems` | `RenderFragment` | Yes | `` | Dropdown menu items |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback` | Fired when main action clicked |

## Examples

```razor
<FlareSplitButton Text="Save" OnClick="Save" Variant="ButtonVariant.Filled">
    <FlareMenuItem>Save and close</FlareMenuItem>
    <FlareMenuItem>Save as draft</FlareMenuItem>
</FlareSplitButton>
```

