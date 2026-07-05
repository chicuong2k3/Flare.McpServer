# FlareTooltip

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
