# FlareListbox (Listbox)

**Category**: Inputs
**Tags**: input, listbox, list, selection, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareListbox.html](https://jrfrigat.github.io/Flare/api/FlareListbox.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Scrollable list selection with single and multi-select modes.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `TValue` | No | `` | Selected value |
| `Items` | `IEnumerable<TValue>` | Yes | `` | List items |
| `MultiSelect` | `bool` | No | `false` | Allow multi-select |

## Examples

```razor
<FlareListbox @bind-Value="_selection" Items="_options" />
```

