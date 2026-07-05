# FlareImage (Image)

**Category**: Display
**Tags**: image, picture, photo, media, lazy
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareImage.html](https://jrfrigat.github.io/Flare/api/FlareImage.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Image component with lazy loading, placeholders, error fallback, and aspect ratio.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Src` | `string` | Yes | `` | Image URL |
| `Alt` | `string` | No | `` | Alt text |
| `Placeholder` | `RenderFragment` | No | `` | Loading placeholder |
| `ErrorFallback` | `RenderFragment` | No | `` | Error fallback content |
| `Lazy` | `bool` | No | `true` | Lazy load image |

## Examples

```razor
<FlareImage Src="/photo.jpg" Alt="Photo" Lazy="true" />
```

