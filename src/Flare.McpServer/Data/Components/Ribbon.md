# FlareRibbon (Ribbon)

**Category**: IDE
**Tags**: ribbon, toolbar, office, ide
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareRibbon.html](https://jrfrigat.github.io/Flare/api/FlareRibbon.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Office-style ribbon toolbar with tabs, groups, buttons, and dropdowns. Separate package: Flare.Components.IDE.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | RibbonTab children |

## Sub-Components

- `FlareRibbonTab`
- `FlareRibbonGroup`
- `FlareRibbonButton`
- `FlareRibbonDropdown`

## Examples

```razor
<FlareRibbon>
    <FlareRibbonTab Title="Home">
        <FlareRibbonGroup Title="Clipboard">
            <FlareRibbonButton Icon="content_copy" Label="Copy" />
        </FlareRibbonGroup>
    </FlareRibbonTab>
</FlareRibbon>
```

