# FlareDocumentTabs (DocumentTabs)

**Category**: IDE
**Tags**: tabs, document, editor, ide
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareDocumentTabs.html](https://jrfrigat.github.io/Flare/api/FlareDocumentTabs.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Tabbed document container like Visual Studio's editor tabs. Separate package: Flare.Components.IDE.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | DocumentTab children |
| `Closable` | `bool` | No | `true` | Tabs have close buttons |

## Sub-Components

- `FlareDocumentTab`

## Examples

```razor
<FlareDocumentTabs>
    <FlareDocumentTab Title="Program.cs">@code</FlareDocumentTab>
    <FlareDocumentTab Title="App.razor">@markup</FlareDocumentTab>
</FlareDocumentTabs>
```

