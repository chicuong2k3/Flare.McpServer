# FlareFileUpload

File upload with drag-and-drop and multi-file support.

```razor
<FlareFileUpload Multiple="true" Accept=".pdf,.doc,.docx" OnFilesChanged="HandleFiles" />
```

## Key Parameters
- `Multiple` - allow multi-file selection
- `Accept` - accepted file types filter
- `MaxSize` - maximum file size in bytes
- `OnFilesChanged` - file change callback
