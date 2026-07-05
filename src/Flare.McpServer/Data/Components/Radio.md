# FlareRadio (Radio)

**Category**: Inputs
**Tags**: radio, input, selection, form, group
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareRadio.html](https://jrfrigat.github.io/Flare/api/FlareRadio.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Radio button for single selection within a group.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `TValue` | Yes | `` | Selected value when checked |
| `Label` | `string` | No | `` | Radio label text |
| `Color` | `FlareColor` | No | `Default` | Radio color |
| `Disabled` | `bool` | No | `false` | Whether disabled |

## Examples

```razor
<FlareRadioGroup @bind-Value="_option">
    <FlareRadio Value="apple" Label="Apple" />
    <FlareRadio Value="orange" Label="Orange" />
</FlareRadioGroup>
```

---

Radio button group for single selection.

```razor
<FlareRadioGroup @bind-Value="_option">
    <FlareRadio Value="apple" Label="Apple" />
    <FlareRadio Value="orange" Label="Orange" />
    <FlareRadio Value="banana" Label="Banana" />
</FlareRadioGroup>
```

## Key Parameters
- `Value` - selected value binding (on group)
- `Label` - radio label text
- `Color` - `FlareColor`
