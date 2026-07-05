# FlareRating

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
