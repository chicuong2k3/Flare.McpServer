# FlareTextArea (TextArea)

**Category**: Inputs
**Tags**: input, textarea, text, form, multiline
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTextArea.html](https://jrfrigat.github.io/Flare/api/FlareTextArea.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Multi-line text input with auto-resize support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string` | No | `` | Gets or sets the text value |
| `ValueChanged` | `EventCallback<string>` | No | `` | Callback when value changes |
| `Label` | `string` | No | `` | Label text displayed above the textarea |
| `Placeholder` | `string` | No | `` | Placeholder text when empty |
| `Color` | `FlareColor` | No | `Default` | Color of the textarea |
| `Variant` | `Variant` | No | `Outlined` | Visual variant |
| `Rows` | `int` | No | `3` | Number of visible text lines |
| `AutoResize` | `bool` | No | `true` | Whether the textarea auto-resizes based on content |
| `MaxRows` | `int?` | No | `` | Maximum rows when AutoResize is enabled |
| `Disabled` | `bool` | No | `false` | Whether the textarea is disabled |
| `ReadOnly` | `bool` | No | `false` | Whether the textarea is read-only |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnChange` | `EventCallback<string>` | Fired when the value changes |
| `OnBlur` | `EventCallback<FocusEventArgs>` | Fired when the textarea loses focus |

## Examples

```razor
<FlareTextArea @bind-Value="_description" Label="Description" Rows="5" AutoResize="true" />
```

---

> Inherits `FlareFieldBase` → Implements `IFlareField<string>`  
> Source: [FlareTextArea.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/TextArea/FlareTextArea.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareTextArea.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `string?` | — | Current text content. `@bind-Value`. |
| `Label` | `string?` | — | Label text (inherited from FlareFieldBase). |
| `Placeholder` | `string?` | — | Placeholder text (inherited). |
| `HelperText` | `string?` | — | Helper text below field (inherited). |
| `ErrorText` | `string?` | — | Error text (inherited). |
| `Disabled` | `bool` | `false` | Disable (inherited). |
| `ReadOnly` | `bool` | `false` | Read-only (inherited). |
| `Required` | `bool` | `false` | Required (inherited). |
| `Rows` | `int?` | — | Number of visible text rows. |
| `AutoGrow` | `bool` | `false` | Auto-resize height (zero-JS via CSS field-sizing). |
| `MaxLines` | `int` | `0` | With AutoGrow, caps height then scrolls. 0=unlimited. |
| `MaxLength` | `int` | `0` | Max characters. Auto-enables counter. |
| `ShowCharacterCount` | `bool` | `false` | Character counter in supporting-text row. |
| `Variant` | `InputVariant` | `Default` | Filled/Outlined. |
| `Immediate` | `bool` | `false` | Update on every keystroke. |
| `DebounceInterval` | `int` | `0` | Debounce ms for Immediate. |
| `Typo` | `TypographyScale?` | — | Typography override. |
| `For` | `Expression<Func<string>>?` | — | EditContext binding. |

```razor
<FlareTextArea @bind-Value="_description" Label="Description" Rows="5" AutoGrow="true" MaxLines="10" />
```
