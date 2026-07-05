# FlareClipboard (Clipboard)

**Category**: Buttons
**Tags**: clipboard, copy, utility
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareClipboard.html](https://jrfrigat.github.io/Flare/api/FlareClipboard.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Copy-to-clipboard utility with feedback via IFlareClipboard service.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Text` | `string` | Yes | `` | Text to copy |
| `ChildContent` | `RenderFragment` | No | `` | Trigger content |

## Examples

```razor
<FlareClipboard Text="@_code">
    <FlareButton Icon="content_copy">Copy</FlareButton>
</FlareClipboard>
```

