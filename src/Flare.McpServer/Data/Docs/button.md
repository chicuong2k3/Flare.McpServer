# FlareButton

A highly customizable button component with multiple variants, icons, loading state, and color support.

## Variants
- `ButtonVariant.Filled` (default) - solid background
- `ButtonVariant.Outlined` - border with transparent background
- `ButtonVariant.Text` - no border or background
- `ButtonVariant.Elevated` - filled with shadow
- `ButtonVariant.Tonal` - tonal/tinted background

## Basic Usage
```razor
<FlareButton Variant="ButtonVariant.Filled" OnClick="Save">Save</FlareButton>
<FlareButton Variant="ButtonVariant.Outlined" Icon="delete" Color="FlareColor.Error">Delete</FlareButton>
<FlareButton Variant="ButtonVariant.Filled" Loading="true">Saving...</FlareButton>
<FlareButton Type="ButtonType.Submit" Variant="ButtonVariant.Filled">Submit</FlareButton>
```

## Key Parameters
- `Variant` - visual style (Filled, Outlined, Text, Elevated, Tonal)
- `Color` - `FlareColor` role or custom hex value
- `Icon` - Material icon name (e.g. "delete", "search")
- `IconPosition` - Start or End relative to text
- `Loading` - shows spinner and disables interaction
- `Type` - HTML button type (Button, Submit, Reset)
- `FullWidth` - stretch to fill container width
- `Href` - render as anchor link instead of button

## Events
- `OnClick` - fired when the button is clicked
