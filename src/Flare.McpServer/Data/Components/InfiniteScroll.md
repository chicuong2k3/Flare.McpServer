# FlareInfiniteScroll (InfiniteScroll)

**Category**: Layout
**Tags**: scroll, infinite, load, lazy, pagination
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareInfiniteScroll.html](https://jrfrigat.github.io/Flare/api/FlareInfiniteScroll.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Scroll container that triggers data loading when reaching the bottom.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Scrollable content |
| `HasMore` | `bool` | No | `true` | Whether more data is available |
| `Threshold` | `int` | No | `200` | Pixels from bottom to trigger load |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnLoadMore` | `EventCallback` | Fired when scrolled near bottom |

## Examples

```razor
<FlareInfiniteScroll HasMore="_hasMore" OnLoadMore="LoadMore">
    <FlareVirtualList Items="_items" />
</FlareInfiniteScroll>
```

