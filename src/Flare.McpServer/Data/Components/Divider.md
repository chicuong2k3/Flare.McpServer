# FlareDivider (Divider)

**Category**: Layout
**Tags**: divider, separator, line, layout
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDivider.html](https://jrfrigat.github.io/Flare/api/FlareDivider.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Horizontal or vertical divider line separating content sections.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Vertical` | `bool` | No | `false` | Render as vertical divider |
| `Inset` | `bool` | No | `false` | Add left inset spacing |
| `Label` | `string` | No | `` | Optional label in the middle |

## Examples

```razor
<FlareDivider />
```

```razor
<FlareDivider Label="OR" />
```

---

Horizontal or vertical separator line.

```razor
<FlareDivider />
<FlareDivider Label="OR" />
<FlareDivider Vertical="true" />
```

## Key Parameters
- `Vertical` - vertical orientation
- `Inset` - left inset spacing
- `Label` - optional text label
