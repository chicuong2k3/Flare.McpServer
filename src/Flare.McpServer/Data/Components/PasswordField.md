# FlarePasswordField (PasswordField)

**Category**: Inputs
**Tags**: input, password, secure, form, auth
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlarePasswordField.html](https://jrfrigat.github.io/Flare/api/FlarePasswordField.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Password input with show/hide toggle and strength indicator.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string` | No | `` | Password value |
| `ValueChanged` | `EventCallback<string>` | No | `` | Callback on change |
| `Label` | `string` | No | `` | Field label |
| `ShowStrength` | `bool` | No | `false` | Show strength indicator |
| `Color` | `FlareColor` | No | `Default` | Field color |

## Examples

```razor
<FlarePasswordField @bind-Value="_password" Label="Password" ShowStrength="true" />
```

