# FlareAccordion (Accordion)

**Category**: Layout
**Tags**: accordion, expand, collapse, panel, layout
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareAccordion.html](https://jrfrigat.github.io/Flare/api/FlareAccordion.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Expandable accordion with multiple panels, single/multi expand modes.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | AccordionPanel children |
| `ExpandMode` | `AccordionExpandMode` | No | `Single` | Single or multiple expansion |
| `Color` | `FlareColor` | No | `Default` | Accent color for expand icon |

## Sub-Components

- `FlareAccordionPanel`

## Examples

```razor
<FlareAccordion>
    <FlareAccordionPanel Title="Section 1">Content 1</FlareAccordionPanel>
    <FlareAccordionPanel Title="Section 2">Content 2</FlareAccordionPanel>
</FlareAccordion>
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareAccordion.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Accordion/FlareAccordion.razor)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | `FlareAccordionPanel` children. |
| `ExpandMode` | `SelectionMode` | `Single` | Single or Multiple expansion. |

## Sub-component: FlareAccordionPanel

| Name | Type | Description |
|------|------|-------------|
| `Title` | `string?` | Panel header text. |
| `Icon` | `string?` | Optional header icon. |
| `ChildContent` | `RenderFragment?` | Panel body content. |
| `Expanded` | `bool` | Expanded state. `@bind-Expanded`. |

```razor
<FlareAccordion>
    <FlareAccordionPanel Title="Section 1">Content 1</FlareAccordionPanel>
    <FlareAccordionPanel Title="Section 2">Content 2</FlareAccordionPanel>
</FlareAccordion>
```
