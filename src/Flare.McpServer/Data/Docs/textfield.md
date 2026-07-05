# FlareTextField API

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
