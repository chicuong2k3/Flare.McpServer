# FlarePropertyGrid (PropertyGrid)

**Category**: DataDisplay
**Tags**: properties, grid, editor, key-value, settings
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlarePropertyGrid.html](https://jrfrigat.github.io/Flare/api/FlarePropertyGrid.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Property grid for displaying and editing object properties in key-value rows.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Model` | `object` | Yes | `` | Object whose properties to display |
| `ReadOnly` | `bool` | No | `false` | Display only, no editing |

## Examples

```razor
<FlarePropertyGrid Model="_config" />
```

