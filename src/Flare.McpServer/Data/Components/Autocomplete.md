# FlareAutocomplete (Autocomplete)

**Category**: Inputs
**Tags**: autocomplete, search, suggestions, input, form
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareAutocomplete.html](https://jrfrigat.github.io/Flare/api/FlareAutocomplete.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Autocomplete input with search, filtering, and item template support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string` | No | `` | Input text value |
| `ValueChanged` | `EventCallback<string>` | No | `` | Callback when text changes |
| `Items` | `IEnumerable<string>` | Yes | `` | Suggestions list |
| `Label` | `string` | No | `` | Field label |
| `Placeholder` | `string` | No | `` | Placeholder text |
| `Color` | `FlareColor` | No | `Default` | Color theme |
| `MinChars` | `int` | No | `0` | Minimum characters before filtering |
| `ItemTemplate` | `RenderFragment<string>` | No | `` | Custom item template |

## Examples

```razor
<FlareAutocomplete @bind-Value="_query" Items="_suggestions" Label="Search" MinChars="2" />
```

---

> Inherits `FlareFieldBase` → Implements `IFlareField<TValue>`  
> Source: [FlareAutocomplete.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Autocomplete/FlareAutocomplete.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareAutocomplete-1.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `Value` | `TValue?` | — | Selected value. `@bind-Value`. |
| `Items` | `IEnumerable<TValue>?` | — | Static item collection (when no SearchFunc). |
| `SearchFunc` | `Func<string,Task<IEnumerable<TValue>>>?` | — | Async search callback. |
| `GetLabel` | `Func<TValue,string>?` | — | Display text for an item. |
| `GroupBy` | `Func<TValue,string>?` | — | Group label; non-null enables grouping. |
| `ItemTemplate` | `RenderFragment<TValue>?` | — | Custom dropdown option template. |
| `Fuzzy` | `bool` | `false` | Rank local Items by relevance (best first). |
| `RankFunc` | `Func<TValue,string,int>?` | — | Custom relevance scorer. Overrides Fuzzy. |
| `MinChars` | `int` | `1` | Min typed chars before search. |
| `MaxItems` | `int` | `10` | Max suggestions shown. |
| `DebounceMs` | `int` | `300` | Wait ms after input before searching. |
| `Clearable` | `bool` | `false` | Show clear (x) button. |
| `NoResultsText` | `string?` | — | "No results" text. |
| `Size` | `FieldSize` | `Md` | Control size: Xs..Xl. |
| `Typo` | `TypographyScale?` | — | Typography override. |
| `Variant` | `InputVariant` | `Default` | Filled/Outlined. |
| `For` | `Expression<Func<TValue>>?` | — | EditContext binding. |

Plus all FlareFieldBase inherited params (Label, Placeholder, HelperText, ErrorText, Disabled, ReadOnly, Required).

```razor
<FlareAutocomplete @bind-Value="_selected" Items="_items"
    SearchFunc="SearchAsync" GetLabel="@(i => i.Name)" DebounceMs="300" Clearable="true" />
```
