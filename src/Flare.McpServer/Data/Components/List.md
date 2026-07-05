# FlareList (List)

**Category**: DataDisplay
**Tags**: list, items, selection, menu
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareList.html](https://jrfrigat.github.io/Flare/api/FlareList.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Simple list component with items, dividers, and selection support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | ListItem children |
| `Selectable` | `bool` | No | `false` | Enable item selection |
| `Dense` | `bool` | No | `false` | Compact spacing |

## Sub-Components

- `FlareListItem`

## Examples

```razor
<FlareList Selectable="true">
    <FlareListItem>Item 1</FlareListItem>
    <FlareListItem>Item 2</FlareListItem>
</FlareList>
```

