# FlareFileUpload (FileUpload)

**Category**: Inputs
**Tags**: file, upload, drag, drop, input, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareFileUpload.html](https://jrfrigat.github.io/Flare/api/FlareFileUpload.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

File upload component with drag-and-drop, multi-file, preview, and progress support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Files` | `IReadOnlyList<IBrowserFile>` | No | `` | Selected files |
| `OnFilesChanged` | `EventCallback<IReadOnlyList<IBrowserFile>>` | No | `` | Callback when files change |
| `Multiple` | `bool` | No | `false` | Allow multiple file selection |
| `Accept` | `string` | No | `` | Accepted file types (e.g. '.pdf,.doc') |
| `MaxSize` | `long` | No | `10485760` | Maximum file size in bytes |
| `Disabled` | `bool` | No | `false` | Whether upload is disabled |

## Examples

```razor
<FlareFileUpload Multiple="true" Accept=".pdf,.doc,.docx" OnFilesChanged="HandleFiles" />
```

---

> Inherits `FlareComponentBase`  
> Assembly: `Flare.Components.Media`  
> Source: [FlareFileUpload.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components.Media/FileUpload/FlareFileUpload.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareFileUpload.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Accept` | `string?` | — | MIME/extension filter (e.g. ".pdf,.doc,.docx"). |
| `Multiple` | `bool` | `false` | Allow multiple file selection. |
| `MaxFiles` | `int?` | — | Max number of files. |
| `Disabled` | `bool` | `false` | Disable upload zone. |
| `DropText` | `string?` | — | Instructional text. Defaults to localized string. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnFilesChanged` | `EventCallback<IReadOnlyList<IBrowserFile>>` | Fired with selected files. |

```razor
<FlareFileUpload Multiple="true" Accept=".pdf,.doc" OnFilesChanged="HandleFiles" />
```
