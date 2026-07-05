# FlareNumericField (NumericField)

**Category**: Inputs
**Tags**: input, number, numeric, form, integer
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareNumericField.html](https://jrfrigat.github.io/Flare/api/FlareNumericField.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Number input field with increment/decrement buttons, min/max validation.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `TValue` | No | `` | Numeric value |
| `ValueChanged` | `EventCallback<TValue>` | No | `` | Callback when value changes |
| `Min` | `TValue` | No | `` | Minimum allowed value |
| `Max` | `TValue` | No | `` | Maximum allowed value |
| `Step` | `TValue` | No | `1` | Increment step |
| `Label` | `string` | No | `` | Field label |
| `Color` | `FlareColor` | No | `Default` | Field color |

## Examples

```razor
<FlareNumericField @bind-Value="_age" Label="Age" Min="0" Max="150" />
```

