# FlareCheckbox (Checkbox)

**Category**: Inputs
**Tags**: input, checkbox, toggle, boolean, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareCheckbox.html](https://jrfrigat.github.io/Flare/api/FlareCheckbox.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Checkbox component for boolean values with label and indeterminate state.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `bool` | No | `false` | Gets or sets the checked state |
| `ValueChanged` | `EventCallback<bool>` | No | `` | Callback when checked state changes |
| `Label` | `string` | No | `` | Label text next to the checkbox |
| `Color` | `FlareColor` | No | `Default` | Color of the checkbox |
| `Disabled` | `bool` | No | `false` | Whether the checkbox is disabled |
| `Indeterminate` | `bool` | No | `false` | Shows indeterminate state |
| `ChildContent` | `RenderFragment` | No | `` | Custom label content (can include links/formatting) |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnChange` | `EventCallback<ChangeEventArgs>` | Fired when the checked state changes |

## Examples

```razor
<FlareCheckbox @bind-Value="_agree">I agree to the terms</FlareCheckbox>
```

```razor
<FlareCheckbox @bind-Value="_enabled" Color="FlareColor.Success" Label="Enable feature" />
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareCheckbox.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Checkbox/FlareCheckbox.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareCheckbox.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `bool?` | `false` | Tri-state: true/false/null=indeterminate. `@bind-Value`. |
| `Label` | `string?` | — | Label next to checkbox. |
| `LabelPlacement` | `LabelPlacement` | `End` | End (after), Start (before). |
| `Color` | `FlareColor` | `Primary` | Accent color of checked indicator. |
| `Size` | `Size` | `Md` | Control size: Xs..Xl. |
| `Disabled` | `bool` | `false` | Disable checkbox. |
| `CheckedIcon` | `RenderFragment?` | — | Custom checked icon. |
| `UncheckedIcon` | `RenderFragment?` | — | Custom unchecked icon. |
| `IndeterminateIcon` | `RenderFragment?` | — | Custom indeterminate icon. |
| `ErrorText` | `string?` | — | Custom error message. |
| `For` | `Expression<Func<bool>>?` | — | EditContext binding. |

```razor
<FlareCheckbox @bind-Value="_agree" Label="I agree" />
<FlareCheckbox Value="null" Label="Select all" />  <!-- indeterminate -->
```
