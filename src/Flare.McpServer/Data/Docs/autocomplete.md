# FlareAutocomplete

Input with suggestions dropdown, filtering, and templates.

```razor
<FlareAutocomplete @bind-Value="_query" Items="_suggestions" Label="Search" MinChars="2" />
```

## Key Parameters
- `Items` - suggestions collection
- `Value` / `@bind-Value` - input text
- `MinChars` - minimum chars before filtering
- `ItemTemplate` - custom item rendering
