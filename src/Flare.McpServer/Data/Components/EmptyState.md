# FlareEmptyState (EmptyState)

**Category**: Feedback
**Tags**: empty, state, placeholder, zero, no-data
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareEmptyState.html](https://jrfrigat.github.io/Flare/api/FlareEmptyState.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Empty state placeholder with icon, title, description, and optional action button.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Icon` | `string` | No | `` | Material icon name |
| `Title` | `string` | No | `` | Empty state title |
| `Description` | `string` | No | `` | Empty state description |
| `ActionTemplate` | `RenderFragment` | No | `` | Optional action button |

## Examples

```razor
<FlareEmptyState Icon="inbox" Title="No messages" Description="You have no new messages yet.">
    <FlareButton Variant="ButtonVariant.Filled">Compose</FlareButton>
</FlareEmptyState>
```

