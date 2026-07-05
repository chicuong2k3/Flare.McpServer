# FlareQrCode (QrCode)

**Category**: Display
**Tags**: qrcode, barcode, encode, url
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareQrCode.html](https://jrfrigat.github.io/Flare/api/FlareQrCode.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

QR code generator that renders an SVG QR code from string data. Separate package: Flare.Components.QrCode.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Data` | `string` | Yes | `` | Content to encode |
| `Size` | `int` | No | `256` | QR code pixel size |
| `Color` | `FlareColor` | No | `Default` | QR code color |

## Examples

```razor
<FlareQrCode Data="https://example.com" Size="200" />
```

