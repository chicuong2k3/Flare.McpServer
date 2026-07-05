# FlareCheckbox API

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
