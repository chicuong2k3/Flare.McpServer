# FlareDateTimePicker (DateTimePicker)

**Category**: Inputs
**Tags**: input, datetime, calendar, time, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDateTimePicker.html](https://jrfrigat.github.io/Flare/api/FlareDateTimePicker.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Combined date and time picker in a single component.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `DateTime?` | No | `` | Selected datetime |
| `ValueChanged` | `EventCallback<DateTime?>` | No | `` | Callback |
| `Label` | `string` | No | `` | Field label |

## Examples

```razor
<FlareDateTimePicker @bind-Value="_appointment" Label="Appointment" />
```

