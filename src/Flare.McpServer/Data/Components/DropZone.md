# FlareDropZone (DropZone)

**Category**: Inputs
**Tags**: input, drag, drop, upload, file
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDropZone.html](https://jrfrigat.github.io/Flare/api/FlareDropZone.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Drag and drop target area for file uploads with visual feedback.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Drop zone content |
| `OnFilesDropped` | `EventCallback<IReadOnlyList<IBrowserFile>>` | No | `` | Files dropped callback |
| `Accept` | `string` | No | `` | Accepted file types |

## Examples

```razor
<FlareDropZone OnFilesDropped="HandleDrop" Accept=".pdf,.png">
    <p>Drop files here</p>
</FlareDropZone>
```

