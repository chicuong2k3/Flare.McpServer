# FlareMultiSelect (MultiSelect)

**Category**: Inputs
**Tags**: input, multi-select, dropdown, chips, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareMultiSelect.html](https://jrfrigat.github.io/Flare/api/FlareMultiSelect.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Multi-select dropdown with chips for selected values and search filtering.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Values` | `IEnumerable<TValue>` | No | `` | Selected values |
| `ValuesChanged` | `EventCallback<IEnumerable<TValue>>` | No | `` | Callback |
| `Items` | `IEnumerable<TValue>` | Yes | `` | Available options |
| `Label` | `string` | No | `` | Field label |
| `Searchable` | `bool` | No | `true` | Enable search |

## Examples

```razor
<FlareMultiSelect @bind-Values="_roles" Items="_allRoles" Label="Roles" Searchable="true" />
```

