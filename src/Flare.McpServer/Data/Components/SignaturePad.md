# FlareSignaturePad (SignaturePad)

**Category**: Inputs
**Tags**: input, signature, draw, canvas, pen
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSignaturePad.html](https://jrfrigat.github.io/Flare/api/FlareSignaturePad.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Signature capture component for drawing signatures with touch or mouse.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ImageData` | `string` | No | `` | Base64 encoded signature image |
| `Width` | `string` | No | `400px` | Canvas width |
| `Height` | `string` | No | `200px` | Canvas height |
| `Color` | `FlareColor` | No | `Default` | Pen color |

## Examples

```razor
<FlareSignaturePad @bind-ImageData="_signature" Width="500px" Height="200px" />
```

