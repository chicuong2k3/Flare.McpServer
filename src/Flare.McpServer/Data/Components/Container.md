# FlareContainer (Container)

**Category**: Layout
**Tags**: layout, container, center, width, responsive
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareContainer.html](https://jrfrigat.github.io/Flare/api/FlareContainer.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Centered content container with configurable max-width breakpoints.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Container content |
| `MaxWidth` | `ContainerMaxWidth` | No | `Lg` | Max width preset |
| `Fluid` | `bool` | No | `false` | Full-width with padding only |

## Examples

```razor
<FlareContainer MaxWidth="ContainerMaxWidth.Md">
    ... content ...
</FlareContainer>
```

