# FlareRating (Rating)

**Category**: Inputs
**Tags**: rating, stars, input, feedback, review
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareRating.html](https://jrfrigat.github.io/Flare/api/FlareRating.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Star rating input with customizable count, size, and color.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Value` | `int` | No | `0` | Rating value (0 to Max) |
| `ValueChanged` | `EventCallback<int>` | No | `` | Callback when rating changes |
| `Max` | `int` | No | `5` | Maximum rating (number of stars) |
| `Color` | `FlareColor` | No | `Default` | Star color |
| `Size` | `Size` | No | `Md` | Star size |
| `ReadOnly` | `bool` | No | `false` | Display-only, not interactive |
| `Disabled` | `bool` | No | `false` | Whether rating is disabled |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnChange` | `EventCallback<int>` | Fired when rating value changes |

## Examples

```razor
<FlareRating @bind-Value="_rating" Max="5" Color="FlareColor.Warning" />
```

```razor
<FlareRating Value="4" ReadOnly="true" Size="Size.Sm" />
```

---

Star rating input with configurable count and color.

```razor
<FlareRating @bind-Value="_rating" Max="5" Color="FlareColor.Warning" />
<FlareRating Value="4" ReadOnly="true" Size="Size.Sm" />
```

## Key Parameters
- `Value` / `@bind-Value` - rating (0 to Max)
- `Max` - number of stars (default 5)
- `Color` - `FlareColor` for stars
- `Size` - star size
- `ReadOnly` - display only
