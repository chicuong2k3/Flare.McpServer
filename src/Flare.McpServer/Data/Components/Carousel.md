# FlareCarousel (Carousel)

**Category**: DataDisplay
**Tags**: carousel, slideshow, images, gallery, slider
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareCarousel.html](https://jrfrigat.github.io/Flare/api/FlareCarousel.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Image/content carousel with slide transitions, autoplay, and navigation controls. Separate package: Flare.Components.Carousel.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Slide content |
| `AutoPlay` | `bool` | No | `false` | Auto-advance slides |
| `Interval` | `int` | No | `3000` | Auto-play interval in ms |
| `ShowIndicators` | `bool` | No | `true` | Show dot indicators |
| `ShowControls` | `bool` | No | `true` | Show prev/next arrows |

## Examples

```razor
<FlareCarousel AutoPlay="true">
    <img src="/img1.jpg" />
    <img src="/img2.jpg" />
</FlareCarousel>
```

