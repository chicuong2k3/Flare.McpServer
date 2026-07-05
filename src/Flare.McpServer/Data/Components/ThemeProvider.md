# FlareThemeProvider (ThemeProvider)

**Category**: Theming
**Tags**: theme, provider, cascade, root
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareThemeProvider.html](https://jrfrigat.github.io/Flare/api/FlareThemeProvider.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Root component that cascades IThemeService and ThemeSnapshot to all Flare components. Wrap your entire app.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | App content |
| `RespectSystemColorScheme` | `bool` | No | `true` | Track OS prefers-color-scheme |
| `ManageSplash` | `bool` | No | `true` | Hide anti-FOUC splash when ready |

## Examples

```razor
<FlareThemeProvider>
    <Router AppAssembly="@typeof(App).Assembly">...</Router>
</FlareThemeProvider>
```

