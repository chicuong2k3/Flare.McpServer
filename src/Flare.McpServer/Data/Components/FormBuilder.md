# FlareFormBuilder (FormBuilder)

**Category**: Inputs
**Tags**: input, form, builder, dynamic, generator
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareFormBuilder.html](https://jrfrigat.github.io/Flare/api/FlareFormBuilder.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Dynamic form builder that generates form fields from metadata/models at runtime.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Model` | `object` | Yes | `` | Form model object |
| `Fields` | `IEnumerable<FormFieldMeta>` | No | `` | Field definitions |
| `Columns` | `int` | No | `1` | Number of columns in layout |

## Examples

```razor
<FlareFormBuilder Model="_user" />
```

