# FlareAccordion API

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
