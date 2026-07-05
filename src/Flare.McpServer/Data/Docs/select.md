# FlareSelect API

> Inherits `FlareFieldBase` → `FlareSelectBase<TValue>`  
> Source: [FlareSelect.cs](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Select/FlareSelect.cs) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareSelect-1.html)

Single-value dropdown select with custom combobox trigger. Shares implementation with `FlareMultiSelect<TValue>` via `FlareSelectBase<TValue>`.

---

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `TValue?` | — | Currently selected value. Supports `@bind-Value`. |
| `Label` | `string?` | — | Label text. |
| `Placeholder` | `string?` | — | Placeholder when nothing selected. |
| `HelperText` | `string?` | — | Helper text below field. |
| `Color` | `FlareColor` | `Default` | Semantic color for focus/active border. |
| `Variant` | `InputVariant` | `Default` | Default, Filled, Outlined. |
| `Size` | `FieldSize` | `Md` | Control size: Xs..Xl. |
| `Disabled` | `bool` | `false` | Disables the select. |
| `Required` | `bool` | `false` | Marks as required. |
| `FullWidth` | `bool` | `true` | Fills container width. |
| `For` | `Expression<Func<TValue>>?` | — | EditContext binding expression. |
| `ChildContent` | `RenderFragment?` | — | Declarative `<option>` items or custom content. |
| `ItemTemplate` | `RenderFragment<TValue>?` | — | Custom dropdown item template. |
| `ValueTemplate` | `RenderFragment<TValue>?` | — | Custom selected value template. |
| `Searchable` | `bool` | `false` | Search input inside dropdown. |
| `Clearable` | `bool` | `false` | Clear button to reset selection. |

## Events

| Name | Type | Description |
|------|------|-------------|
| `ValueChanged` | `EventCallback<TValue?>` | Fired when selection changes. |

## Usage

```razor
<!-- Declarative options -->
<FlareSelect @bind-Value="_role" Label="Role" Searchable="true" Clearable="true">
    <option value="admin">Administrator</option>
    <option value="user">User</option>
</FlareSelect>

<!-- ItemTemplate -->
<FlareSelect @bind-Value="_color" Label="Color" Items="_colors">
    <ItemTemplate>
        <span style="color:@context">@context</span>
    </ItemTemplate>
</FlareSelect>
```
