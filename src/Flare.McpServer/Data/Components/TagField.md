# FlareTagField (TagField)

**Category**: Inputs
**Tags**: input, tag, chip, multi-value, token, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTagField.html](https://jrfrigat.github.io/Flare/api/FlareTagField.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Tag/chips input field for multiple values like email recipients or keywords.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Values` | `IEnumerable<string>` | No | `` | Tag values collection |
| `ValuesChanged` | `EventCallback<IEnumerable<string>>` | No | `` | Callback on changes |
| `Label` | `string` | No | `` | Field label |
| `Placeholder` | `string` | No | `` | Placeholder text |

## Examples

```razor
<FlareTagField @bind-Values="_emails" Label="Recipients" Placeholder="Type and press enter" />
```

