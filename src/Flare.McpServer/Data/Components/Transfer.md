# FlareTransfer (Transfer)

**Category**: Inputs
**Tags**: transfer, dual-list, shuttle, move
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareTransfer.html](https://jrfrigat.github.io/Flare/api/FlareTransfer.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Dual list transfer component for moving items between two lists. Separate package: Flare.Components.Transfer.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `SourceItems` | `IEnumerable<TItem>` | Yes | `` | Available items (left list) |
| `TargetItems` | `IEnumerable<TItem>` | Yes | `` | Selected items (right list) |
| `SourceLabel` | `string` | No | `Available` | Left panel label |
| `TargetLabel` | `string` | No | `Selected` | Right panel label |

## Examples

```razor
<FlareTransfer SourceItems="_available" @bind-TargetItems="_selected" SourceLabel="All" TargetLabel="Chosen" />
```

