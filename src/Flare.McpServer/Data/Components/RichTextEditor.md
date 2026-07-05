# FlareRichTextEditor (RichTextEditor)

**Category**: Inputs
**Tags**: editor, richtext, wysiwyg, html, content
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareRichTextEditor.html](https://jrfrigat.github.io/Flare/api/FlareRichTextEditor.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

WYSIWYG rich text editor with formatting toolbar. Separate package: Flare.Components.RichTextEditor.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string` | No | `` | HTML content |
| `ValueChanged` | `EventCallback<string>` | No | `` | Callback on change |
| `Toolbar` | `RichTextToolbar` | No | `Full` | Toolbar configuration |

## Examples

```razor
<FlareRichTextEditor @bind-Value="_content" Toolbar="RichTextToolbar.Full" />
```

