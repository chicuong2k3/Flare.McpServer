# Flare - Architecture

> [Русская версия ->](../ru/architecture.md) - [README](https://github.com/jrfrigat/Flare/blob/main/README.md)

How Flare is structured, how theming works, and the contracts components rely on.

---

## 1. Module Map

Flare is layered as a **clean / onion (ports & adapters)** stack. Dependencies point strictly inward;
the UI layer consumes **ports** (interfaces) and never references the host adapters. The composition
root (`Flare.Blazor`) is the only package that binds ports to their adapter implementations.

### Dependency Graph

```
            Flare.Abstractions   (Ring 0 - contracts)        no internal dependencies
               ^        ^      ^
               |        |      |
        Flare.Theming   |   Flare.Infrastructure   (Ring 1 engine / Ring 2 adapters)
        (-> Abstractions)   (-> Abstractions, Theming)
               ^                    ^
               |                    |
        Flare.Components   --------/   (Ring 3 - UI; -> Abstractions, Theming; NOT Infrastructure)
               ^
               |
        Flare (Flare.Blazor)   (Ring 4 - composition root; -> Components, Infrastructure)
```

> **Flare ships no themes of its own.** The umbrella `Flare.Blazor` package depends on `Flare.Components` + `Flare.Infrastructure`. Each design system is an independent `Flare.Theme.*` package.

### Rings

| Ring | Package | Purpose |
|------|---------|---------|
| 0 | `Flare.Abstractions` | Dependency-free core: ports, tokens, CSS name registry |
| 1 | `Flare.Theming` | Theme engine: ThemeService, CssVarMap, ColorMath, palettes |
| 2 | `Flare.Infrastructure` | Browser adapters: JS interop, localStorage, dialog/snackbar |
| 3 | `Flare.Components` | 100+ UI components; depends on Abstractions + Theming only |
| 4 | `Flare.Blazor` | Composition root: AddFlare binds ports to Infrastructure adapters |

### Theme Packages (7 shipped)

| Package | Theme class | ID | Default palette | Palettes |
|---------|-------------|-----|-----------------|----------|
| `Flare.Theme.MaterialDesign3Expressive` | `Md3Theme` | `md3-expressive` | Violet | 5 |
| `Flare.Theme.MaterialDesign3` | `MaterialDesign3Theme` | `md3` | Violet | (shares MD3) |
| `Flare.Theme.MaterialDesign2` | `MaterialDesign2Theme` | `md2` | Purple | 6 |
| `Flare.Theme.FluentUI2` | `Fluent2Theme` | `fluent2` | Blue | 7 |
| `Flare.Theme.Aero` | `AeroTheme` | `aero` | Blue | 5 |
| `Flare.Theme.LiquidGlass` | `LiquidGlassTheme` | `liquid-glass` | Blue | 6 |
| `Flare.Theme.VisualStudio` | `VisualStudioTheme` | `visualstudio` | Blue | 5 |

### Optional component packages (each -> Flare.Components)
`Flare.Components.Carousel`, `.Kanban`, `.Transfer`, `.QrCode`, `.RichTextEditor`, `.Media`, `.IDE`

---

## 2. Component Architecture

### FlareComponentBase Contract

```csharp
// Flare.Components.FlareComponentBase
public abstract class FlareComponentBase : ComponentBase, IAsyncDisposable
{
    [CascadingParameter] protected IThemeService? ThemeService { get; set; }
    [CascadingParameter] protected ThemeSnapshot? Theme { get; set; }
    [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
    [Parameter] public string? Class { get; set; }
    [Parameter] public string? Style { get; set; }

    protected abstract string ComponentCssClass { get; }
    protected string BuildCssClass(params string?[] additionalClasses);
    public virtual ValueTask DisposeAsync();
}
```

Key contract rules:
- `ComponentCssClass` returns the BEM block name (e.g. `"flare-btn"`)
- Theme state arrives by **cascading value**: `FlareThemeProvider` cascades `IThemeService` and immutable `ThemeSnapshot`
- All CSS rules consume only `var(--flare-*)` custom properties

### CSS Naming Convention

BEM: `flare-[component]__[element]--[modifier]`

| Context | Class |
|---------|-------|
| Block | `flare-btn` |
| Filled variant | `flare-btn--filled` |
| Active tab | `flare-tabs__tab flare-tabs__tab--active` |

### Compound Component Pattern

Parent/child families share state through **single typed cascading context objects**: `FlareTabsContext`, `FlareButtonGroup`, `FlareToggleGroup`, `FlareChipGroup`, `FlareRadioGroup`, `FlareTreeContext`.

---

## 3. Theming Architecture

### Three Axes

1. **Design system** (`ITheme`) - typography, shape, motion, elevation, component tokens
2. **Palette** (`Palette`) - ~47 color roles with light + dark `ColorScheme`
3. **Mode** (`ThemeMode`) - Light / Dark / Auto (tracks `prefers-color-scheme`)

### Theme Delivery

- **`ClassToggle`** (default, fastest) - class swap on `<html>` against static pre-generated stylesheet
- **`Inject`** - `ICssVariableInjector` writes tokens to `:root` via JS interop

### Anti-FOUC Bootstrap

One-line `flare-bootstrap.js` applies saved theme/palette/mode classes before first paint. `FlareThemeProvider` reveals the app after CSS and web fonts are loaded. Safety timeout reveals page anyway if provider is absent.

---

## 4. Service Layer

### IThemeService (Scoped)

- **State:** `CurrentTheme`, `CurrentPalette`, `Mode`, `IsDark`, `Themes`, `Palettes`
- **Switching:** `SetThemeAsync`, `SetPaletteAsync`, `SetModeAsync`, `SetRtlAsync`
- **Registration:** `RegisterTheme`, `RegisterPalette`
- **Customization:** `CustomizeColors`, `SetCustomToken(s)`, `ClearCustomToken/All`

### Services registered by AddFlare (all Scoped):

`ICssVariableInjector`, `IThemeService`, `IThemeStorageService`, `ISnackbarService`, `IDialogService`, `IMessageBoxService`, `ICollisionService`, `IThemeJsService`, `IFlareClipboard`, `IFlareDownload`, `IFlareColorExtractor`

---

_Source: https://jrfrigat.github.io/Flare/docs/en/architecture.html_
