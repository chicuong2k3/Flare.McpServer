# FlareBackstage (Backstage)

**Category**: Navigation
**Tags**: backstage, office, navigation, menu
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareBackstage.html](https://jrfrigat.github.io/Flare/api/FlareBackstage.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Office-style backstage view that slides in over the app with category navigation and content panels.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | BackstageItem children |
| `Visible` | `bool` | No | `false` | Backstage visibility |

## Sub-Components

- `FlareBackstageItem`

## Examples

```razor
<FlareBackstage @bind-Visible="_open">
    <FlareBackstageItem Title="Info">Document info</FlareBackstageItem>
    <FlareBackstageItem Title="Options">Settings</FlareBackstageItem>
</FlareBackstage>
```

