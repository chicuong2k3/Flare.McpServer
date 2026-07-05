# FlarePopover

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
