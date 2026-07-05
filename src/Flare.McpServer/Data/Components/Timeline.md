# FlareTimeline (Timeline)

**Category**: DataDisplay
**Tags**: timeline, history, events, log, chronological
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTimeline.html](https://jrfrigat.github.io/Flare/api/FlareTimeline.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Vertical timeline with themed dots, connectors, and content panels.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | TimelineItem children |
| `Mode` | `TimelineMode` | No | `Left` | Left, Right, or Alternating |
| `Color` | `FlareColor` | No | `Default` | Timeline dot/connector color |

## Sub-Components

- `FlareTimelineItem`

## Examples

```razor
<FlareTimeline Color="FlareColor.Primary">
    <FlareTimelineItem Title="Shipped" Subtitle="Jan 15, 2026">Order was shipped</FlareTimelineItem>
    <FlareTimelineItem Title="Delivered" Subtitle="Jan 18, 2026">Package delivered</FlareTimelineItem>
</FlareTimeline>
```

