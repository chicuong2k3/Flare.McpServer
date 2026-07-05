# FlareTableOfContents (TableOfContents)

**Category**: Navigation
**Tags**: toc, contents, navigation, sidebar
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTableOfContents.html](https://jrfrigat.github.io/Flare/api/FlareTableOfContents.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Table of contents with nested link hierarchy and expand/collapse.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | TocLink children |

## Sub-Components

- `FlareTocLink`

## Examples

```razor
<FlareTableOfContents>
    <FlareTocLink Href="#intro" Title="Introduction" />
    <FlareTocLink Href="#setup" Title="Setup" />
</FlareTableOfContents>
```

