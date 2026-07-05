# FlareTextField

Text input field with label, placeholder, validation, and icon support.

```razor
<FlareTextField @bind-Value="_name" Label="Name" />
<FlareTextField @bind-Value="_email" Label="Email" Placeholder="user@domain.com" Icon="email" />
<FlareTextField @bind-Value="_password" Label="Password" Type="InputType.Password" />
```

## Key Parameters
- `Value` / `@bind-Value` - two-way value binding
- `Label` - label displayed above input
- `Placeholder` - placeholder text when empty
- `Color` - `FlareColor` for the field border/label
- `Variant` - visual variant (Outlined, Filled, etc.)
- `Icon` - leading Material icon name
- `Disabled`, `ReadOnly`, `Required` - state flags
- `HelperText` - text displayed below the field
- `MaxLength` - character limit
