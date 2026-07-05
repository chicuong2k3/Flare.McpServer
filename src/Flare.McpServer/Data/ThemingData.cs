namespace Flare.McpServer.Data;

public static class ThemingData
{
    public const string Overview = """
        # Flare Theming Overview

        Flare uses a token-based theming system with three independently switchable axes: design system, color palette, and light/dark mode.

        ## Key Concepts
        - **Design Systems**: Material Design 3 Expressive, Material Design 3, Material Design 2, Fluent UI 2, Aero, Liquid Glass, Visual Studio 2026
        - **Palettes**: 34+ built-in palettes plus Dynamic Color from the OS/browser accent
        - **Color API**: Unified `FlareColor` type - semantic roles (Primary, Secondary, etc.) or custom CSS values
        - **Theme Provider**: `<FlareThemeProvider>` cascades `IThemeService` and `ThemeSnapshot` to all components
        - **Zero third-party CSS**: All styles use `var(--flare-*)` tokens exclusively

        ## Theme Structure
        Three independent axes compose a rendered theme:
        1. **Design system** (`ITheme`) - typography, shape, motion, elevation, component tokens
        2. **Palette** (`Palette`) - colors with light + dark `ColorScheme`
        3. **Mode** (`ThemeMode`) - Light / Dark / Auto (tracks `prefers-color-scheme`)

        ## Available Topics
        - `design-systems`: The seven built-in design systems and their packages
        - `palettes`: Built-in palettes and Dynamic Color
        - `customization`: Override tokens, create custom palettes, derive themes
        - `dark-mode`: Dark mode and auto mode implementation
        - `getting-started`: Quick start with DI setup, styles, and first component
        """;

    public const string DesignSystems = """
        # Flare Design Systems

        Each design system ships as an independent NuGet package. Reference only the ones you need.

        | Package | Theme Class | ID | Default Palette | Palettes |
        |---------|-------------|-----|-----------------|----------|
        | `Flare.Theme.MaterialDesign3Expressive` | `Md3Theme` | `md3-expressive` | Violet | 5 |
        | `Flare.Theme.MaterialDesign3` | `MaterialDesign3Theme` | `md3` | Violet | (shares MD3) |
        | `Flare.Theme.MaterialDesign2` | `MaterialDesign2Theme` | `md2` | Purple | 6 |
        | `Flare.Theme.FluentUI2` | `Fluent2Theme` | `fluent2` | Blue | 7 |
        | `Flare.Theme.Aero` | `AeroTheme` | `aero` | Blue | 5 |
        | `Flare.Theme.LiquidGlass` | `LiquidGlassTheme` | `liquid-glass` | Blue | 6 |
        | `Flare.Theme.VisualStudio` | `VisualStudioTheme` | `visualstudio` | Blue | 5 |

        ## Material Design 3 Expressive (default recommended)
        ```sh
        dotnet add package Flare.Theme.MaterialDesign3Expressive
        ```
        Extended MD3 with expressive type scale and component variations.

        ## Fluent UI 2
        ```sh
        dotnet add package Flare.Theme.FluentUI2
        ```
        Microsoft's Fluent UI 2 design system with Office palettes.

        ## Installing and registering themes
        ```csharp
        // Program.cs
        using Flare.Extensions;
        using Flare.Theme.MaterialDesign3Expressive;
        using Flare.Theme.FluentUI2;

        builder.Services.AddFlare(opts =>
        {
            opts.DefaultTheme = new Md3Theme();
            opts.DefaultPalette = Md3Palettes.Violet;
            opts.DefaultMode = ThemeMode.Auto;
        });

        // Register additional themes for runtime switching
        builder.Services.AddFlareTheme(new Fluent2Theme());
        ```

        ## Runtime theme switching
        ```csharp
        @inject IThemeService ThemeService

        await ThemeService.SetThemeAsync("fluent2");       // switch design system
        await ThemeService.SetPaletteAsync("fluent-blue");  // switch palette
        await ThemeService.SetModeAsync(ThemeMode.Dark);    // switch Light/Dark/Auto
        ```
        """;

    public const string Palettes = """
        # Flare Palettes

        Flare ships 34+ built-in palettes across the seven design systems plus Dynamic Color support.

        ## Design System Palettes
        - **Material 3 Expressive**: Violet, Sapphire, Teal, Rose, Amber
        - **Material 3**: Shares MD3 palettes
        - **Material 2**: Purple, Indigo, Blue, Teal, Red, Amber
        - **Fluent UI 2**: Blue, Red, Green, Purple, Teal, Orange, Gray
        - **Aero**: Blue, Silver, Graphite, Aqua, Emerald
        - **Liquid Glass**: Blue, Teal, Purple, Coral, Slate, Ghost
        - **Visual Studio 2026**: Blue, Purple, Green, Red, Yellow

        ## Dynamic Color
        Enable opt-in palette derived from the OS/browser accent (Windows/macOS accent, Android Material You):
        ```csharp
        builder.Services.AddFlare(opts =>
        {
            opts.UseDynamicPalette = true;
            opts.DynamicFallbackPalette = Md3Palettes.Violet; // fallback if accent unavailable
        });
        ```
        Switch to it at runtime: `await ThemeService.SetPaletteAsync(Palette.DynamicId);`

        > Chrome/Edge do not expose the real OS accent (they return a fixed placeholder for fingerprinting mitigation).
        > Only Firefox reflects the genuine accent. The DynamicFallbackPalette is used on Chromium.

        ## Custom Palettes
        Create palettes from reference color schemes:
        ```csharp
        var brand = PaletteFactory.FromColors("brand", "Brand", "#7B1FA2");
        // Or manually:
        var ocean = new Palette
        {
            Id = "ocean", Name = "Ocean", Source = "Custom",
            Light = Md3.LightColors with { Primary = "#006782", PrimaryContainer = "#BCE9FF" },
            Dark = Md3.DarkColors with { Primary = "#5DD5FC", PrimaryContainer = "#004E63" },
        };
        ```
        """;

    public const string Customization = """
        # Flare Customization

        ## Token System
        All styling is driven by CSS custom properties: `var(--flare-color-*)`, `var(--flare-shape-*)`, `var(--flare-typescale-*)`, `var(--flare-state-*)`, `var(--flare-elevation-*)`, `var(--flare-motion-*)`.

        ## Unified Color API
        Every color-aware component uses a single `Color` parameter of type `FlareColor`:
        ```razor
        <!-- Semantic role -> shared, cached theme class -->
        <FlareButton Color="FlareColor.Primary">Primary</FlareButton>
        <FlareProgress Color="FlareColor.Success" Value="70" />

        <!-- Custom value -> inline CSS tokens -->
        <FlareSlider Color="FlareColor.Custom("#E91E63")" @bind-Value="_v" />
        ```

        ## Component-Level Styling
        - Use `Class` parameter for additional CSS classes on the root element
        - Use `Style` parameter for inline styles
        - Prefer Flare tokens over hardcoded values

        ## Overriding Design Tokens
        Customize any design token via `IThemeService`:
        ```csharp
        @inject IThemeService ThemeService

        ThemeService.SetCustomToken("--flare-shape-medium", "10px");
        ```

        ## Creating a Custom Theme
        Derive from a built-in theme:
        ```csharp
        var myFluent = new Fluent2Theme().Derive(
            id: "my-fluent",
            displayName: "My Fluent",
            design: d => d with { Shape = d.Shape with { Medium = "6px" } });
        services.AddFlareTheme(myFluent);
        ```

        ## CSS Architecture
        - Global bundle: `_content/Flare.Components/css/flare-components.css`
        - BEM naming: `flare-[component]__[element]--[modifier]`
        - No scoped `*.razor.css` files
        - All rules consume `var(--flare-*)` tokens only
        """;

    public const string DarkMode = """
        # Flare Dark Mode

        ## Three Modes
        - **Light** - Always light theme
        - **Dark** - Always dark theme
        - **Auto** - Follows OS `prefers-color-scheme` (default)

        ## Setup
        Dark mode is configured in `AddFlare`:
        ```csharp
        builder.Services.AddFlare(opts =>
        {
            opts.DefaultMode = ThemeMode.Auto; // Auto, Light, or Dark
        });
        ```

        ## Anti-FOUC Bootstrap
        One-line in `<head>` to prevent flash of unstyled content:
        ```html
        <script src="_content/Flare.Components/js/flare-bootstrap.js"></script>
        ```
        The bootstrap applies saved theme/palette/mode classes before first paint.
        `FlareThemeProvider` reveals the app after theme CSS and fonts are ready.

        ## Runtime Switching
        ```csharp
        @inject IThemeService ThemeService

        await ThemeService.SetModeAsync(ThemeMode.Dark);  // force dark
        await ThemeService.SetModeAsync(ThemeMode.Light); // force light
        await ThemeService.SetModeAsync(ThemeMode.Auto);  // follow OS
        ```

        ## Palette Structure
        Each palette carries a `Light` and `Dark` `ColorScheme` with ~47 color roles each.
        The active mode selects which scheme applies. Components adapt automatically
        through token references.

        ## Toggle Component
        Use the built-in toggle:
        ```razor
        <FlareColorModeToggle />
        ```
        """;

    public const string GettingStarted = """
        # Flare Getting Started

        ## Installation
        ```sh
        dotnet add package Flare.Blazor
        dotnet add package Flare.Theme.MaterialDesign3Expressive
        ```

        ## DI Setup (`Program.cs`)
        ```csharp
        using Flare.Extensions;
        using Flare.Theme.MaterialDesign3Expressive;

        builder.Services.AddFlare(opts =>
        {
            opts.DefaultTheme = new Md3Theme();
            opts.DefaultPalette = Md3Palettes.Violet;
            opts.DefaultMode = ThemeMode.Auto;
        });
        ```

        ## Styles (`index.html` / `App.razor` `<head>`)
        ```html
        <script src="_content/Flare.Components/js/flare-bootstrap.js"></script>
        <link rel="stylesheet" href="_content/Flare.Components/css/flare-components.css" />
        <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Rounded:opsz,wght,FILL,GRAD@20..48,100..700,0..1,-50..200" />
        ```

        ## Imports (`_Imports.razor`)
        ```razor
        @using Flare.Components
        @using Flare.Abstractions
        @using Flare.Abstractions.Tokens
        ```

        ## Theme Provider (`App.razor`)
        ```razor
        <FlareThemeProvider>
            <Router AppAssembly="@typeof(App).Assembly">
                ...
            </Router>
        </FlareThemeProvider>
        ```

        ## First Component
        ```razor
        @page "/hello"
        @inject IThemeService ThemeService

        <FlareCard>
            <FlareText Typo="TypographyScale.HeadlineMedium">Hello, Flare!</FlareText>
            <FlareButton OnClick="SwitchTheme" Variant="ButtonVariant.Filled">
                Switch theme
            </FlareButton>
        </FlareCard>
        ```

        ## Overlay Providers
        Place once in your layout:
        ```razor
        <FlareDialogProvider />
        <FlareSnackbarProvider />
        <FlareMessageBoxProvider />
        ```

        ## Form Validation
        ```razor
        <EditForm Model="_model" OnValidSubmit="Submit">
            <DataAnnotationsValidator />
            <FlareTextField @bind-Value="_model.Name" Label="Name" />
            <FlareTextField @bind-Value="_model.Email" Label="Email" />
            <FlareSelect @bind-Value="_model.Role" Label="Role" Items="_roles" />
            <FlareButton Type="ButtonType.Submit" Variant="ButtonVariant.Filled">
                Submit
            </FlareButton>
        </EditForm>
        ```
        """;
}
