# FlareDialog (Dialog)

**Category**: Overlays
**Tags**: dialog, modal, overlay, popup, confirm, alert
**API Reference**: [https://jrfrigat.github.io/Flare/api/Flare.Components.FlareDialog.html](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareDialog.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Modal dialog with title, icon, body content, actions, scrim close, ESC close, and divider. Use with IDialogService or standalone via @bind-Visible.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment?` | No | `` | Main body content rendered inside the dialog. |
| `Title` | `string?` | No | `` | Title text displayed in the dialog header. |
| `Icon` | `RenderFragment?` | No | `` | Optional hero icon shown centered above the title. |
| `Actions` | `RenderFragment?` | No | `` | Action buttons rendered in the dialog footer. |
| `Visible` | `bool` | No | `false` | Controls whether the dialog is shown. Supports @bind-Visible. |
| `Size` | `string?` | No | `` | Maximum width of the dialog (Sm, Md, Lg, or CSS value). |
| `CloseOnScrimClick` | `bool` | No | `true` | Closes the dialog when the scrim backdrop is clicked. |
| `CloseOnEsc` | `bool` | No | `true` | Closes the dialog when the Escape key is pressed. |
| `Divider` | `bool` | No | `false` | Shows a divider between the header and the content. |
| `AriaLabel` | `string?` | No | `` | Accessible name when Title is empty (aria-label). |

## Examples

```razor
<FlareDialog @bind-Visible="_open" Title="Confirm" Size="Sm">
    <p>Are you sure?</p>
    <Actions><FlareButton OnClick="Confirm">Yes</FlareButton></Actions>
</FlareDialog>
```

```razor
var ok = await Dialog.ConfirmAsync("Delete", "Cannot be undone.", "Delete", "Cancel");
```

---

> Inherits `FlareComponentBase`  
> Source: [FlareDialog.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Dialog/FlareDialog.razor) | [API Reference](https://jrfrigat.github.io/Flare/api/Flare.Components.FlareDialog.html)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | Main body content. |
| `Title` | `string?` | — | Title text in header. |
| `Icon` | `RenderFragment?` | — | Hero icon centered above title. |
| `Actions` | `RenderFragment?` | — | Action buttons in footer. |
| `Visible` | `bool` | `false` | Dialog visibility. `@bind-Visible`. |
| `Size` | `string?` | — | Max width (Sm, Md, Lg, or CSS value). |
| `CloseOnScrimClick` | `bool` | `true` | Close on backdrop click. |
| `CloseOnEsc` | `bool` | `true` | Close on Escape key. |
| `Divider` | `bool` | `false` | Divider between header and content. |
| `AriaLabel` | `string?` | — | Accessible name when Title empty. |

## Service-based (IDialogService)

```csharp
@inject IDialogService Dialog

// Simple confirm
var ok = await Dialog.ConfirmAsync("Delete", "Cannot undo.", "Delete", "Cancel");

// Custom component
var result = await Dialog.ShowAsync<EditDialog>("Edit", parameters,
    new DialogOptions { Size = DialogSize.Sm });
```

Dialog body closes via cascaded `FlareDialogInstance`:
```csharp
[CascadingParameter] public FlareDialogInstance Dialog { get; set; }
private void Save() => Dialog.Close(_edited);
private void Cancel() => Dialog.Cancel();
```

## Component-based

```razor
<FlareDialog @bind-Visible="_open" Title="Confirm" Size="Sm">
    <p>Are you sure?</p>
    <Actions><FlareButton OnClick="Confirm">Yes</FlareButton></Actions>
</FlareDialog>
```
