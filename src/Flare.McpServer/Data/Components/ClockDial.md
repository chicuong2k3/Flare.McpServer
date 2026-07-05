# FlareClockDial (ClockDial)

**Category**: Inputs
**Tags**: input, clock, time, dial, analog
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareClockDial.html](https://jrfrigat.github.io/Flare/api/FlareClockDial.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Analog clock face for time selection with hour and minute hands.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `TimeSpan?` | No | `` | Selected time |
| `ValueChanged` | `EventCallback<TimeSpan?>` | No | `` | Callback |

## Examples

```razor
<FlareClockDial @bind-Value="_time" />
```

