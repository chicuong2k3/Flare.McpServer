# FlareKanban (Kanban)

**Category**: DataDisplay
**Tags**: kanban, board, drag, cards, project, task
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareKanban.html](https://jrfrigat.github.io/Flare/api/FlareKanban.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Kanban board with draggable cards, swimlanes, and column management. Separate package: Flare.Components.Kanban.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Columns` | `IEnumerable<KanbanColumn>` | Yes | `` | Board columns with cards |
| `Draggable` | `bool` | No | `true` | Enable drag and drop |

## Events

| Name | Type | Description |
|------|------|-------------|
| `OnCardMoved` | `EventCallback<KanbanCardMovedArgs>` | Fired when a card is moved |

## Examples

```razor
<FlareKanban Columns="_columns" Draggable="true" />
```

