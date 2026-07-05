# FlareTooltip (Tooltip)

**Category**: Overlays
**Tags**: tooltip, help, hint, overlay, popup
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTooltip.html](https://jrfrigat.github.io/Flare/api/FlareTooltip.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Tooltip overlay that shows contextual help text on hover or focus.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | The trigger element |
| `Text` | `string` | Yes | `` | Tooltip text content |
| `Position` | `Placement` | No | `Top` | Tooltip position relative to trigger |
| `Delay` | `int` | No | `400` | Delay before showing (ms) |
| `TooltipContent` | `RenderFragment` | No | `` | Custom tooltip content (overrides Text) |

## Examples

```razor
<FlareTooltip Text="Copy to clipboard" Position="Placement.Top">
    <FlareButton Icon="content_copy" Variant="ButtonVariant.Outlined" />
</FlareTooltip>
```

---

Tooltip overlay for contextual help on hover or focus.

```razor
<FlareTooltip Text="Copy to clipboard" Position="Placement.Top">
    <FlareButton Icon="content_copy" Variant="ButtonVariant.Outlined" />
</FlareTooltip>
```

## Key Parameters
- `Text` - tooltip text
- `Position` - Placement relative to trigger
- `Delay` - show delay in ms (default 400)
- `TooltipContent` - custom RenderFragment (overrides Text)
