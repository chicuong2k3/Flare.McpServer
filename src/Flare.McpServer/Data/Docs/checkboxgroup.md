# FlareCheckboxGroup

Multi-select checkbox group with validation.

```razor
<FlareCheckboxGroup @bind-Values="_permissions" Items="_allOptions" Label="Permissions" />
<FlareCheckboxGroup @bind-Values="_selected" Items="_items" Inline="true" />
```

## Key Parameters
- `Values` / `@bind-Values` - selected values collection
- `Items` - available options
- `Label` - group label
- `Color` - `FlareColor`
- `Inline` - horizontal layout
