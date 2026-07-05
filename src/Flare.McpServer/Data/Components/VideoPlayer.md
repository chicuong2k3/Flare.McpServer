# FlareVideoPlayer (VideoPlayer)

**Category**: Display
**Tags**: video, player, media, stream
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareVideoPlayer.html](https://jrfrigat.github.io/Flare/api/FlareVideoPlayer.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Video player with controls, poster, and streaming support. Separate package: Flare.Components.Media.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Src` | `string` | Yes | `` | Video source URL |
| `Poster` | `string` | No | `` | Poster image URL |
| `AutoPlay` | `bool` | No | `false` | Auto-play video |
| `Controls` | `bool` | No | `true` | Show player controls |

## Examples

```razor
<FlareVideoPlayer Src="/video.mp4" Poster="/poster.jpg" Controls="true" />
```

