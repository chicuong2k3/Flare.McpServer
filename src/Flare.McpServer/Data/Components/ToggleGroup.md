# FlareToggleGroup (ToggleGroup)

**Category**: Buttons
**Tags**: button, toggle, group, toolbar, selection
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareToggleGroup.html](https://jrfrigat.github.io/Flare/api/FlareToggleGroup.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Group of toggle buttons where only one (or multiple) can be selected at a time.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | ToggleButton children |
| `MultiSelect` | `bool` | No | `false` | Allow multi-selection |

## Examples

```razor
<FlareToggleGroup>
    <FlareToggleButton Icon="format_align_left" />
    <FlareToggleButton Icon="format_align_center" />
    <FlareToggleButton Icon="format_align_right" />
</FlareToggleGroup>
```

