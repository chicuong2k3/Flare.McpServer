# FlareMediaQuery (MediaQuery)

**Category**: Layout
**Tags**: responsive, media, query, breakpoint
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareMediaQuery.html](https://jrfrigat.github.io/Flare/api/FlareMediaQuery.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Conditionally renders content based on CSS media query breakpoints.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Conditional content |
| `MinWidth` | `string` | No | `` | Minimum width to show |
| `MaxWidth` | `string` | No | `` | Maximum width to show |

## Examples

```razor
<FlareMediaQuery MinWidth="768px"><FlareButton>Desktop-only</FlareButton></FlareMediaQuery>
```

