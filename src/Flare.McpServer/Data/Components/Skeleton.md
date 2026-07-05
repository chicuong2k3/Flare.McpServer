# FlareSkeleton (Skeleton)

**Category**: Feedback
**Tags**: loading, placeholder, skeleton, shimmer, placeholder
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareSkeleton.html](https://jrfrigat.github.io/Flare/api/FlareSkeleton.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Skeleton loading placeholder for text, cards, avatars, and other content shapes.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Width` | `string` | No | `100%` | Skeleton width (CSS value) |
| `Height` | `string` | No | `1rem` | Skeleton height (CSS value) |
| `Shape` | `SkeletonShape` | No | `Text` | Shape of the skeleton |
| `Variant` | `SkeletonVariant` | No | `Pulse` | Visual variant (pulse or wave) |

## Examples

```razor
<FlareSkeleton Width="200px" Height="1.25rem" />
```

```razor
<FlareSkeleton Shape="SkeletonShape.Circle" Width="48px" Height="48px" />
```

```razor
<FlareSkeleton Shape="SkeletonShape.Rectangle" Width="100%" Height="200px" />
```

---

Skeleton loading placeholders for various content shapes.

```razor
<FlareSkeleton Width="200px" Height="1.25rem" />
<FlareSkeleton Shape="SkeletonShape.Circle" Width="48px" Height="48px" />
<FlareSkeleton Shape="SkeletonShape.Rectangle" Width="100%" Height="200px" />
```

## Key Parameters
- `Width` / `Height` - skeleton dimensions
- `Shape` - Text, Circle, Rectangle
- `Variant` - Pulse or Wave animation
