# FlareIdeLayout (IdeLayout)

**Category**: IDE
**Tags**: ide, layout, ribbon, tabs, panel, shell
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareIdeLayout.html](https://jrfrigat.github.io/Flare/api/FlareIdeLayout.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

IDE shell layout with ribbon, document tabs, tool panels, splitter, and status bar. Separate package: Flare.Components.IDE.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | IDE child regions |

## Sub-Components

- `FlareRibbon`
- `FlareDocumentTabs`
- `FlareToolPanel`
- `FlareStatusBar`

## Examples

```razor
<FlareIdeLayout>
    <FlareRibbon><!-- tabs and groups --></FlareRibbon>
    <FlareDocumentTabs><!-- tabs --></FlareDocumentTabs>
    <FlareStatusBar><!-- status items --></FlareStatusBar>
</FlareIdeLayout>
```

