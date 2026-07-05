# FlareTextField (TextField)

**Category**: Inputs
**Tags**: input, text, form, field, label, validation
**API Reference**: [https://jrfrigat.github.io/Flare/api/Flare.Components.FlareTextField.html](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareTextField.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Single-line text input field with label, placeholder, leading/trailing icons, adornments, floating label, character counter, clearable, validation, and Color/Variant/Size controls.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string?` | No | `` | Current value of the input. Supports @bind-Value. |
| `Label` | `string?` | No | `` | Label text shown for the field. |
| `Placeholder` | `string?` | No | `` | Placeholder when field is empty. |
| `HelperText` | `string?` | No | `` | Helper text shown below the field. |
| `ErrorText` | `string?` | No | `` | Error text; overrides HelperText and marks field invalid. |
| `Color` | `FlareColor` | No | `Default` | Semantic color for the focus/active border. |
| `Variant` | `InputVariant` | No | `Default` | Visual variant: Default, Filled, Outlined. |
| `Size` | `FieldSize` | No | `Md` | Control size: Xs..Xl. Medium is default. |
| `Disabled` | `bool` | No | `false` | Disables the field (no input, dimmed). |
| `ReadOnly` | `bool` | No | `false` | Makes field read-only. |
| `Required` | `bool` | No | `false` | Marks field as required (visual + native). |
| `LeadingIcon` | `RenderFragment?` | No | `` | Icon rendered inside the leading edge of the input. |
| `TrailingIcon` | `RenderFragment?` | No | `` | Icon rendered inside the trailing edge of the input. |
| `AdornmentStart` | `RenderFragment?` | No | `` | Leading adornment (e.g. currency symbol, prefix). |
| `AdornmentEnd` | `RenderFragment?` | No | `` | Trailing adornment (e.g. unit label, suffix). |
| `FloatingLabel` | `bool` | No | `false` | Animated floating label that moves above input on focus. |
| `MaxLength` | `int` | No | `0` | Max characters allowed. 0 = no limit. |
| `Clearable` | `bool` | No | `false` | Shows clear (x) button when non-empty. |
| `ShowCharacterCount` | `bool` | No | `false` | Shows character counter in supporting-text row. |
| `FullWidth` | `bool` | No | `true` | When true fills container width; false = content-sized. |
| `Margin` | `FieldMargin` | No | `None` | Vertical margin: None, Dense, Normal. |
| `Typo` | `TypographyScale?` | No | `` | Optional typography scale override for input text. |
| `Immediate` | `bool` | No | `false` | Update on every keystroke (oninput) vs on change/blur. |
| `DebounceInterval` | `int` | No | `0` | Debounce ms for Immediate updates. 0 = no debounce. |
| `For` | `Expression<Func<TValue>>?` | No | `` | Expression to bind and validate against EditContext. |
| `Error` | `bool` | No | `false` | Forces error visual state without a message. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnKeyDown` | `EventCallback<KeyboardEventArgs>` | Invoked on keydown in the input. |
| `OnKeyUp` | `EventCallback<KeyboardEventArgs>` | Invoked on keyup in the input. |

## Examples

```razor
<FlareTextField @bind-Value="_name" Label="Name" Placeholder="Enter your name" />
```

```razor
<FlareTextField @bind-Value="_email" Label="Email" LeadingIcon="@emailIcon" Clearable="true" />
```

```razor
<FlareTextField @bind-Value="_amount" Label="Amount" AdornmentStart="@dollarIcon" />
```

---

> Inherits `FlareFieldBase` → `FlareField<string>` → Implements `IFlareField<string>`  
> Source: [FlareTextField.cs](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Input/FlareTextField.cs) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareTextField.html)

A convenience class: `FlareField<string>` under a non-generic name. For non-string values, use `FlareField<TValue>`.

---

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `string?` | — | Current value. Supports `@bind-Value`. |
| `Label` | `string?` | — | Label text shown for the field. |
| `Placeholder` | `string?` | — | Placeholder when empty. |
| `HelperText` | `string?` | — | Helper text shown below the field. |
| `ErrorText` | `string?` | — | Error text; overrides HelperText and marks field invalid. |
| `Error` | `bool` | `false` | Forces error visual state without a message. |
| `Color` | `FlareColor` | `Default` | Semantic color for focus/active border. |
| `Variant` | `InputVariant` | `Default` | Visual variant: Default, Filled, Outlined. |
| `Size` | `FieldSize` | `Md` | Control size: Xs..Xl. |
| `Disabled` | `bool` | `false` | Disables the field (no input, dimmed). |
| `ReadOnly` | `bool` | `false` | Makes field read-only. |
| `Required` | `bool` | `false` | Marks as required. |
| `LeadingIcon` | `RenderFragment?` | — | Icon inside leading edge of input. |
| `TrailingIcon` | `RenderFragment?` | — | Icon inside trailing edge of input. |
| `AdornmentStart` | `RenderFragment?` | — | Leading adornment (currency symbol, prefix). |
| `AdornmentEnd` | `RenderFragment?` | — | Trailing adornment (unit label, suffix). |
| `FloatingLabel` | `bool` | `false` | Animated floating label on focus. |
| `MaxLength` | `int` | `0` | Max characters. 0 = no limit. |
| `Clearable` | `bool` | `false` | Clear (x) button when non-empty. |
| `ShowCharacterCount` | `bool` | `false` | Character counter in supporting-text row. |
| `FullWidth` | `bool` | `true` | Fills container width; false = content-sized. |
| `Margin` | `FieldMargin` | `None` | Vertical margin: None, Dense, Normal. |
| `Typo` | `TypographyScale?` | — | Optional typography override for input text. |
| `Immediate` | `bool` | `false` | Update on every keystroke vs on blur. |
| `DebounceInterval` | `int` | `0` | Debounce ms for Immediate updates. |
| `Type` | `string` | `"text"` | HTML type attribute. |
| `For` | `Expression<Func<TValue>>?` | — | Expression for EditContext binding. |
| `AriaLabel` | `string?` | — | Accessible label for input. |
| `AriaDescribedBy` | `string?` | — | IDs of describing elements. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnKeyDown` | `EventCallback<KeyboardEventArgs>` | Invoked on keydown in input. |
| `OnKeyUp` | `EventCallback<KeyboardEventArgs>` | Invoked on keyup in input. |

## Usage

```razor
<FlareTextField @bind-Value="_name" Label="Name" Placeholder="Enter your name" />
<FlareTextField @bind-Value="_email" Label="Email" LeadingIcon="@EmailIcon" Clearable="true" />
<FlareTextField @bind-Value="_amount" Label="Amount" AdornmentStart="@DollarIcon" FloatingLabel="true" />
<FlareTextField @bind-Value="_search" Immediate="true" DebounceInterval="300" />
```
