# FlareDialog

Modal dialog with service-based and component-based invocation.

## Service-based (recommended)
```razor
@inject IDialogService Dialog

<!-- Place providers once in layout -->
<FlareDialogProvider />
<FlareMessageBoxProvider />

@code {
    // Simple confirm
    var ok = await Dialog.ConfirmAsync("Delete record", "This cannot be undone.", "Delete", "Cancel");

    // Custom component dialog
    var result = await Dialog.ShowAsync<EditDialog>("Edit profile", parameters,
        new DialogOptions { Size = DialogSize.Sm });
}
```

## Dialog body component
```razor
@code {
    [CascadingParameter] public FlareDialogInstance Dialog { get; set; } = default!;

    private void Save() => Dialog.Close(_edited);   // confirm with payload
    private void Cancel() => Dialog.Cancel();        // dismiss
}
```

## Component-based
```razor
<FlareDialog @bind-Visible="_open" Title="Confirm" Size="DialogSize.Sm">
    <p>Are you sure?</p>
    <FlareButton OnClick="Confirm">Yes</FlareButton>
</FlareDialog>
```

## Key Parameters
- `Size` - Xs, Sm, Md, Lg, Xl, FullScreen
- `CloseOnOverlayClick` - close on backdrop click
- `CloseOnEscape` - close on Escape key
