# FlareMessageBoxProvider (MessageBoxProvider)

**Category**: Overlays
**Tags**: messagebox, dialog, alert, confirm, modal
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareMessageBoxProvider.html](https://jrfrigat.github.io/Flare/api/FlareMessageBoxProvider.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Provider for message box dialogs via IMessageBoxService. Place once in layout.

## Examples

```razor
<FlareMessageBoxProvider />
```

```razor
var result = await MessageBox.ShowAsync("Error", "Something went wrong.", MessageBoxButtons.Ok);
```

