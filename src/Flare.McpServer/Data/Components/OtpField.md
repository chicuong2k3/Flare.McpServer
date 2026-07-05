# FlareOtpField (OtpField)

**Category**: Inputs
**Tags**: input, otp, code, verification, pin, 2fa
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareOtpField.html](https://jrfrigat.github.io/Flare/api/FlareOtpField.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

One-time password / verification code input with individual character boxes.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `string` | No | `` | OTP value |
| `ValueChanged` | `EventCallback<string>` | No | `` | Callback on change |
| `Length` | `int` | No | `6` | Number of digits |
| `AutoFocus` | `bool` | No | `true` | Auto-focus first input |

## Examples

```razor
<FlareOtpField @bind-Value="_code" Length="6" />
```

