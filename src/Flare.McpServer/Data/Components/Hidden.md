# FlareHidden (Hidden)

**Category**: Layout
**Tags**: layout, hidden, responsive, breakpoint, visibility
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareHidden.html](https://jrfrigat.github.io/Flare/api/FlareHidden.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Conditionally hide content based on responsive breakpoints.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Content to show/hide |
| `HideOn` | `Breakpoint[]` | No | `` | Breakpoints to hide on |
| `ShowOn` | `Breakpoint[]` | No | `` | Breakpoints to show on |

## Examples

```razor
<FlareHidden HideOn="@new[] { Breakpoint.Sm, Breakpoint.Xs }">Mobile-hidden content</FlareHidden>
```

