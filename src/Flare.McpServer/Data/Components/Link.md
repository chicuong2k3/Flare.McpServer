# FlareLink (Link)

**Category**: Navigation
**Tags**: link, anchor, navigation, url, href
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareLink.html](https://jrfrigat.github.io/Flare/api/FlareLink.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Anchor link component with theme colors, underline options, and icon support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | No | `` | Link text |
| `Href` | `string` | No | `` | Destination URL |
| `Color` | `FlareColor` | No | `Default` | Link color |
| `Underline` | `LinkUnderline` | No | `Hover` | Underline style |
| `Icon` | `string` | No | `` | Icon to display with link |
| `Target` | `string` | No | `` | Link target (_blank, _self, etc.) |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnClick` | `EventCallback<MouseEventArgs>` | Fired when the link is clicked |

## Examples

```razor
<FlareLink Href="/docs" Color="FlareColor.Primary">Documentation</FlareLink>
```

```razor
<FlareLink Href="https://github.com" Target="_blank" Icon="open_in_new">GitHub</FlareLink>
```

---

Anchor link with theme colors, underline options, and icons.

```razor
<FlareLink Href="/docs" Color="FlareColor.Primary">Documentation</FlareLink>
<FlareLink Href="https://github.com" Target="_blank" Icon="open_in_new">GitHub</FlareLink>
```

## Key Parameters
- `Href` - destination URL
- `Color` - `FlareColor`
- `Underline` - Hover, Always, None
- `Icon` - Material icon name
- `Target` - link target (_blank, _self)
