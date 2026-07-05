# FlareCheckbox

Checkbox for boolean values with label and indeterminate state.

```razor
<FlareCheckbox @bind-Value="_agree">I agree to the terms</FlareCheckbox>
<FlareCheckbox @bind-Value="_enabled" Color="FlareColor.Success" Label="Enable feature" />
```

## Key Parameters
- `Value` / `@bind-Value` - checked state binding
- `Label` - text label next to checkbox
- `Color` - `FlareColor` for the checked state
- `Indeterminate` - show indeterminate/minus state
- `ChildContent` - custom label with rich formatting
- `Disabled` - disable interaction
