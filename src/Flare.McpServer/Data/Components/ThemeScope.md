# FlareThemeScope (ThemeScope)

**Category**: Theming
**Tags**: theme, scope, override, section
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareThemeScope.html](https://jrfrigat.github.io/Flare/api/FlareThemeScope.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Scoped theme override for a section of the page with independent tokens.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Scoped content |
| `Palette` | `string` | No | `` | Override palette for this scope |
| `Mode` | `ThemeMode?` | No | `` | Override mode for this scope |

## Examples

```razor
<FlareThemeScope Palette="fluent-blue" Mode="ThemeMode.Dark">
    <FlareCard>This card uses Fluent dark theme</FlareCard>
</FlareThemeScope>
```

