# FlareDialog API

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
