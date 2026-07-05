# FlareTextArea

Multi-line text input with auto-resize support.

```razor
<FlareTextArea @bind-Value="_description" Label="Description" Rows="5" AutoResize="true" />
```

## Key Parameters
- `Value` / `@bind-Value` - two-way value binding
- `Rows` - visible line count (default 3)
- `AutoResize` - automatically grow based on content
- `MaxRows` - maximum rows when auto-resizing
- `Label`, `Placeholder`, `Color`, `Variant` - same as TextField
- `Disabled`, `ReadOnly` - state flags
