# FlareButtonGroup (ButtonGroup)

**Category**: Buttons
**Tags**: button, group, toolbar, actions
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareButtonGroup.html](https://jrfrigat.github.io/Flare/api/FlareButtonGroup.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Group of buttons with shared variant, color, and size.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Grouped FlareButton children |
| `Variant` | `ButtonVariant` | No | `Filled` | Shared variant for all buttons |
| `Color` | `FlareColor` | No | `Default` | Shared color |
| `Size` | `Size` | No | `Md` | Shared size |

## Examples

```razor
<FlareButtonGroup Variant="ButtonVariant.Outlined">
    <FlareButton>Left</FlareButton>
    <FlareButton>Center</FlareButton>
    <FlareButton>Right</FlareButton>
</FlareButtonGroup>
```

