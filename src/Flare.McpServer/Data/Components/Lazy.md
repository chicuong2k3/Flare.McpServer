# FlareLazy (Lazy)

**Category**: Layout
**Tags**: lazy, load, performance, viewport, defer
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareLazy.html](https://jrfrigat.github.io/Flare/api/FlareLazy.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Lazy-loads content only when scrolled into the viewport for performance.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Content to lazy load |
| `Placeholder` | `RenderFragment` | No | `` | Placeholder while loading |

## Examples

```razor
<FlareLazy><FlareChart Type="ChartType.Bar" Data="_data" /></FlareLazy>
```

