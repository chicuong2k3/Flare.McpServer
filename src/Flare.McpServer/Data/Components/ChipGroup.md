# FlareChipGroup (ChipGroup)

**Category**: Display
**Tags**: chip, group, filter, selection, tags
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareChipGroup.html](https://jrfrigat.github.io/Flare/api/FlareChipGroup.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Container for multiple chips with selection and filtering support.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | FlareChip children |
| `MultiSelect` | `bool` | No | `true` | Allow multiple selected chips |

## Examples

```razor
<FlareChipGroup MultiSelect="false">
    <FlareChip Selected="true">All</FlareChip>
    <FlareChip>Active</FlareChip>
    <FlareChip>Inactive</FlareChip>
</FlareChipGroup>
```

