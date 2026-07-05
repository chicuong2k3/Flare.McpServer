# FlareVirtualList (VirtualList)

**Category**: DataDisplay
**Tags**: virtualization, list, scroll, performance, large-data
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareVirtualList.html](https://jrfrigat.github.io/Flare/api/FlareVirtualList.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Virtualized scrolling list that only renders visible items for performance.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Items` | `IEnumerable<TItem>` | Yes | `` | Data items |
| `ChildContent` | `RenderFragment<TItem>` | Yes | `` | Item template |
| `ItemHeight` | `int` | No | `48` | Fixed item height in pixels |
| `Height` | `string` | No | `400px` | List container height |

## Examples

```razor
<FlareVirtualList Items="_bigData" Height="500px" ItemHeight="48">
    <ItemTemplate>
        <FlareText>@context.Name</FlareText>
    </ItemTemplate>
</FlareVirtualList>
```

