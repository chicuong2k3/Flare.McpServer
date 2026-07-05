# FlarePopover (Popover)

**Category**: Overlays
**Tags**: popover, overlay, dropdown, context, popup
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlarePopover.html](https://jrfrigat.github.io/Flare/api/FlarePopover.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Popover overlay anchored to an element for contextual content.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Popover trigger and content |
| `Open` | `bool` | No | `false` | Gets or sets open state |
| `OpenChanged` | `EventCallback<bool>` | No | `` | Callback when open state changes |
| `Position` | `Placement` | No | `Bottom` | Position relative to trigger |
| `CloseOnContentClick` | `bool` | No | `false` | Close when clicking inside content |
| `CloseOnOverlayClick` | `bool` | No | `true` | Close when clicking outside |

## Examples

```razor
<FlarePopover @bind-Open="_open">
    <FlareButton>Click me</FlareButton>
    <PopoverContent>
        <p>Popover content</p>
    </PopoverContent>
</FlarePopover>
```

---

Anchored overlay for contextual content.

```razor
<FlarePopover @bind-Open="_open">
    <FlareButton>Click me</FlareButton>
    <PopoverContent>
        <p>Popover content here</p>
    </PopoverContent>
</FlarePopover>
```

## Key Parameters
- `Open` / `@bind-Open` - popover visibility
- `Position` - Placement relative to trigger
- `CloseOnContentClick` - close when clicking inside
- `CloseOnOverlayClick` - close when clicking outside
