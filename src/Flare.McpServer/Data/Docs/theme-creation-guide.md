# Flare - Theme Creation Guide

> [Русская версия ->](../ru/theme-creation-guide.md) - [README](https://github.com/jrfrigat/Flare/blob/main/README.md)

A rendered theme in Flare is the composition of three independently switchable axes:
1. **Design System** (`ITheme`) - typography, shape, motion, state, elevation, component tokens
2. **Color Palette** (`Palette`) - ~47 color roles, light + dark (and optional high-contrast)
3. **Mode** (`ThemeMode`) - Light / Dark / Auto

---

## Quick Start

### Using FlareThemeBuilder (Recommended)

```csharp
using Flare.Theming;

var myTheme = new FlareThemeBuilder("my-theme", "My Custom Theme")
    .WithTypography(new TypographyTokens
    {
        BodyLarge = new TypeStyle
        {
            FontFamily = "Inter", FontWeight = "400",
            FontSize = "1rem", LineHeight = "1.5rem", LetterSpacing = "0em"
        },
    })
    .WithShape(new ShapeTokens
    {
        None = "0px", ExtraSmall = "4px", Small = "8px",
        Medium = "12px", Large = "16px", ExtraLarge = "28px", Full = "9999px"
    })
    .WithStyleAsset("_content/MyApp/css/my-theme.css")
    .WithDefaultPalette("my-brand")
    .Build();
```

### Deriving from a built-in theme

```csharp
using Flare.Theming;
using Flare.Theme.FluentUI2;

var myFluent = new Fluent2Theme().Derive(
    id: "my-fluent", displayName: "My Fluent",
    design: d => d with { Shape = d.Shape with { Medium = "6px" } });

services.AddFlareTheme(myFluent);
```

Each theme package exposes reference tokens:
```csharp
public DesignTokens Design => Fluent2.DesignReference with { /* overrides */ };
// Fluent2.LightColors with { Primary = "#0F6CBD" }
```

### Implementing ITheme Directly

Start from a published reference package (Material or Fluent lineage) and `with`-override:

```csharp
using Flare.Abstractions;
using Flare.Abstractions.Tokens;
using Flare.Theme.MaterialDesign3.Tokens;

public sealed class MyTheme : ITheme
{
    public string Id => "my-theme";
    public string DisplayName => "My Custom Theme";
    public DesignTokens Design => MaterialDesignTokens.Design with
    {
        FocusRing = "2px solid var(--flare-color-primary)",
        Shape = MaterialDesignTokens.Design.Shape with { Medium = "6px" },
    };
    public string DefaultPaletteId => "my-brand";
    public IReadOnlyList<string> StyleAssets => ["_content/MyApp/css/my-theme.css"];
}
```

---

## Creating a Palette

### From Seed Colors
```csharp
var palette = PaletteFactory.FromColors(
    id: "my-brand", name: "My Brand Colors",
    main: "#6750A4", background: "#FFFBFE");
```

### Manual Palette
```csharp
var palette = new Palette
{
    Id = "my-brand", Name = "My Brand", Source = "Custom",
    Light = new ColorScheme { Primary = "#6750A4", OnPrimary = "#FFFFFF", ... },
    Dark = new ColorScheme { Primary = "#D0BCFF", OnPrimary = "#381E72", ... }
};
```

### Dynamic Color (OS accent)

```csharp
builder.Services.AddFlare(opts =>
{
    opts.UseDynamicPalette = true;
    opts.DynamicFallbackPalette = Md3Palettes.Violet;
});
// Switch to it:
await ThemeService.SetPaletteAsync(Palette.DynamicId);
// From your own seed:
await ThemeService.ApplyDynamicPaletteAsync(new PaletteSeed("#3F51B5"));
```

> Chrome/Edge return a fixed placeholder `#0075FF` for fingerprinting protection. Flare uses the fallback palette instead. Only Firefox exposes the genuine OS accent.

---

## Token System

### Available Token Records

| Token | Fields |
|-------|--------|
| `TypographyTokens` | 15 type scales |
| `ShapeTokens` | 7 corner radius levels |
| `ElevationTokens` | 6 box shadow levels |
| `MotionTokens` | 6 durations + 4 easings |
| `StateTokens` | 6 opacity states |
| `ButtonTokens` | ~30 fields |
| `InputTokens` | 23 fields |
| `DialogTokens` | 26 fields |
| `DataGridTokens` | 33 fields |
| `CardTokens` | 20 fields |
| `AvatarTokens` | 17 fields |
| `ProgressTokens` | 18 fields |
| `SelectTokens` | 24 fields |
| `TooltipTokens` | 15 fields |
| `SnackbarTokens` | 22 fields |
| `DrawerTokens` | 18 fields |
| `SwitchTokens` | 28 fields |
| `PopoverTokens` | 12 fields |
| `NavTokens`, `RatingTokens`, `PaginationTokens`, `TimelineTokens`, `StepperTokens`, `TreeTokens`, `CalendarTokens` | |

### Using Tokens in CSS

```css
.my-component {
    background: var(--flare-color-primary);
    color: var(--flare-color-on-primary);
    border-radius: var(--flare-shape-medium);
    transition: all var(--flare-motion-duration-short2) var(--flare-motion-easing-standard);
}
```

---

## Theme Validation & Import/Export

```csharp
var errors = new ThemeValidator().Validate(myTheme);

// Export/Import
string json = ThemeJsonSerializer.ExportTheme(myTheme);
ITheme imported = ThemeJsonSerializer.ImportTheme(json);
string paletteJson = ThemeJsonSerializer.ExportPalette(myPalette);
```

---

## Best Practices

1. Use tokens, not hardcoded values
2. Follow BEM naming: `flare-{component}__{element}--{modifier}`
3. Test both light and dark modes
4. Test RTL languages
5. Validate themes with ThemeValidator
6. Keep themes minimal - only override what you need
7. Document your tokens with XML docs

---

_Source: https://jrfrigat.github.io/Flare/docs/en/theme-creation-guide.html_
