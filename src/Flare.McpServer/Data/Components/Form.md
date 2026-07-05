# FlareForm (Form)

**Category**: Inputs
**Tags**: form, validation, editform, submit
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareForm.html](https://jrfrigat.github.io/Flare/api/FlareForm.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Wraps Blazor's EditForm with Flare-styled layout, validation summary, and submit handling.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Model` | `object` | Yes | `` | Form model |
| `OnValidSubmit` | `EventCallback` | No | `` | Valid submit callback |
| `ChildContent` | `RenderFragment` | No | `` | Form body |

## Examples

```razor
<FlareForm Model="_user" OnValidSubmit="Save">
    <FlareTextField @bind-Value="_user.Name" Label="Name" />
    <FlareButton Type="ButtonType.Submit">Save</FlareButton>
</FlareForm>
```

