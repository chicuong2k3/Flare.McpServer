# FlareStatusBar (StatusBar)

**Category**: IDE
**Tags**: statusbar, ide, footer
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareStatusBar.html](https://jrfrigat.github.io/Flare/api/FlareStatusBar.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Status bar with sections for messages, progress, and indicators. Separate package: Flare.Components.IDE.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Status bar items |
| `Message` | `string` | No | `` | Status message text |

## Examples

```razor
<FlareStatusBar Message="Ready" />
```

