# FlareAvatarGroup (AvatarGroup)

**Category**: Display
**Tags**: avatar, group, users, stack, overflow
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareAvatarGroup.html](https://jrfrigat.github.io/Flare/api/FlareAvatarGroup.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Group of overlapping avatars with overflow count indicator.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | FlareAvatar children |
| `Max` | `int` | No | `5` | Max avatars before showing overflow |

## Examples

```razor
<FlareAvatarGroup Max="3">
    <FlareAvatar Src="/user1.jpg" />
    <FlareAvatar>SJ</FlareAvatar>
    <FlareAvatar Src="/user3.jpg" />
    <FlareAvatar>JD</FlareAvatar>
</FlareAvatarGroup>
```

