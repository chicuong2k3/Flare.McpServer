# FlareDateRangePicker (DateRangePicker)

**Category**: Inputs
**Tags**: input, date, range, calendar, picker, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDateRangePicker.html](https://jrfrigat.github.io/Flare/api/FlareDateRangePicker.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Date range picker for selecting start and end dates with a calendar popup.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Start` | `DateTime?` | No | `` | Start date |
| `End` | `DateTime?` | No | `` | End date |
| `Label` | `string` | No | `` | Field label |

## Examples

```razor
<FlareDateRangePicker @bind-Start="_start" @bind-End="_end" Label="Date Range" />
```

