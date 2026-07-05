# FlareCalendar (Calendar)

**Category**: Inputs
**Tags**: input, calendar, date, month, picker
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareCalendar.html](https://jrfrigat.github.io/Flare/api/FlareCalendar.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Standalone calendar for date selection, date range, and event display.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `DateTime?` | No | `` | Selected date |
| `ValueChanged` | `EventCallback<DateTime?>` | No | `` | Callback |
| `Events` | `IEnumerable<CalendarEvent>` | No | `` | Calendar events to highlight |

## Examples

```razor
<FlareCalendar @bind-Value="_date" />
```

