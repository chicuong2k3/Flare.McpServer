# FlareResizable (Resizable)

**Category**: Layout
**Tags**: resize, drag, container, layout
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareResizable.html](https://jrfrigat.github.io/Flare/api/FlareResizable.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Resizable container with drag handles on any edge.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Resizable content |
| `MinWidth` | `string` | No | `100px` | Minimum width |
| `MinHeight` | `string` | No | `100px` | Minimum height |
| `Direction` | `ResizeDirection` | No | `Both` | Resize direction |

## Examples

```razor
<FlareResizable MinWidth="200px" MinHeight="150px"><FlareCard>Resize me</FlareCard></FlareResizable>
```

