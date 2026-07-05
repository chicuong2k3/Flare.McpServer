# FlareOnThisPage (OnThisPage)

**Category**: Navigation
**Tags**: toc, navigation, scroll, headings, sidebar
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareOnThisPage.html](https://jrfrigat.github.io/Flare/api/FlareOnThisPage.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Table of contents that highlights the current section based on scroll position.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Headings` | `IEnumerable<TocHeading>` | Yes | `` | Page heading collection |
| `Offset` | `int` | No | `80` | Scroll offset for highlighting |

## Examples

```razor
<FlareOnThisPage Headings="_headings" />
```

