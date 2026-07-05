# FlareTabs

Tabbed navigation with animated active indicator.

```razor
<FlareTabs @bind-ActiveTabIndex="_tabIndex">
    <FlareTab Title="General">General content</FlareTab>
    <FlareTab Title="Settings">Settings content</FlareTab>
    <FlareTab Title="Advanced">Advanced content</FlareTab>
</FlareTabs>
```

## Key Parameters
- `ActiveTabIndex` / `@bind-ActiveTabIndex` - active tab
- `Position` - header position (Top, Bottom, Start, End)
- `Color` - `FlareColor` for active indicator
- `Centered` - center tab headers
- `Border` - show divider line under headers
