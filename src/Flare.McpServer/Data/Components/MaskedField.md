# FlareMaskedField (MaskedField)

**Category**: Inputs
**Tags**: input, mask, format, phone, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareMaskedField.html](https://jrfrigat.github.io/Flare/api/FlareMaskedField.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Text input with input mask for formatted values like phone numbers, dates, etc.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string` | No | `` | Field value |
| `ValueChanged` | `EventCallback<string>` | No | `` | Callback on change |
| `Mask` | `string` | Yes | `` | Mask pattern (e.g. (999) 000-0000) |
| `Label` | `string` | No | `` | Field label |

## Examples

```razor
<FlareMaskedField @bind-Value="_phone" Mask="(999) 000-0000" Label="Phone" />
```

