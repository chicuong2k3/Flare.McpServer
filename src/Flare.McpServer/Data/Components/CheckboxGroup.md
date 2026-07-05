# FlareCheckboxGroup (CheckboxGroup)

**Category**: Inputs
**Tags**: checkbox, multi-select, group, input, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareCheckboxGroup.html](https://jrfrigat.github.io/Flare/api/FlareCheckboxGroup.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Group of checkboxes for multi-selection with validation support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Values` | `IEnumerable<TValue>` | No | `` | Selected values collection |
| `ValuesChanged` | `EventCallback<IEnumerable<TValue>>` | No | `` | Callback when selection changes |
| `Items` | `IEnumerable<TValue>` | Yes | `` | Available options |
| `Label` | `string` | No | `` | Group label |
| `Color` | `FlareColor` | No | `Default` | Checkbox color |
| `Inline` | `bool` | No | `false` | Layout inline horizontally |

## Examples

```razor
<FlareCheckboxGroup @bind-Values="_permissions" Items="_allPermissions" Label="Permissions" />
```

---

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
