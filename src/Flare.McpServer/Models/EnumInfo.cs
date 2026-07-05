namespace Flare.McpServer.Models;

public record EnumInfo
{
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public List<string> Values { get; init; } = new();
}

public static class FlareEnums
{
    public static readonly EnumInfo ButtonVariant = new()
    {
        Name = "ButtonVariant",
        Description = "Appearance style of the button",
        Values = new() { "Filled", "Outlined", "Text", "Elevated", "Tonal" }
    };

    public static readonly EnumInfo ButtonType = new()
    {
        Name = "ButtonType",
        Description = "HTML button type attribute",
        Values = new() { "Button", "Submit", "Reset" }
    };

    public static readonly EnumInfo TypographyScale = new()
    {
        Name = "TypographyScale",
        Description = "Typography scale from the design system",
        Values = new() {
            "DisplayLarge", "DisplayMedium", "DisplaySmall",
            "HeadlineLarge", "HeadlineMedium", "HeadlineSmall",
            "TitleLarge", "TitleMedium", "TitleSmall",
            "BodyLarge", "BodyMedium", "BodySmall",
            "LabelLarge", "LabelMedium", "LabelSmall"
        }
    };

    public static readonly EnumInfo FlareColorRole = new()
    {
        Name = "FlareColor",
        Description = "Semantic color role or custom value",
        Values = new() {
            "Default", "Primary", "Secondary", "Tertiary",
            "Success", "Warning", "Error", "Info",
            "OnSurface", "OnSurfaceVariant"
        }
    };

    public static readonly EnumInfo ThemeMode = new()
    {
        Name = "ThemeMode",
        Description = "Light/Dark/System mode",
        Values = new() { "Light", "Dark", "Auto" }
    };

    public static readonly EnumInfo Variant = new()
    {
        Name = "Variant",
        Description = "Component appearance variant (shared across components)",
        Values = new() { "Filled", "Outlined", "Text", "Elevated", "Tonal", "Soft" }
    };

    public static readonly EnumInfo Size = new()
    {
        Name = "Size",
        Description = "Component size",
        Values = new() { "Xs", "Sm", "Md", "Lg", "Xl" }
    };

    public static readonly EnumInfo Severity = new()
    {
        Name = "Severity",
        Description = "Feedback severity level",
        Values = new() { "Info", "Success", "Warning", "Error", "Default" }
    };

    public static readonly EnumInfo SnackbarSeverity = new()
    {
        Name = "SnackbarSeverity",
        Description = "Snackbar notification severity",
        Values = new() { "Info", "Success", "Warning", "Error" }
    };

    public static readonly EnumInfo ColumnAlign = new()
    {
        Name = "ColumnAlign",
        Description = "DataGrid column text alignment",
        Values = new() { "Start", "Center", "End" }
    };

    public static readonly EnumInfo Placement = new()
    {
        Name = "Placement",
        Description = "Overlay/tooltip placement position",
        Values = new() {
            "Top", "TopStart", "TopEnd",
            "Bottom", "BottomStart", "BottomEnd",
            "Left", "LeftStart", "LeftEnd",
            "Right", "RightStart", "RightEnd"
        }
    };

    public static readonly EnumInfo DialogSize = new()
    {
        Name = "DialogSize",
        Description = "Dialog width preset",
        Values = new() { "Xs", "Sm", "Md", "Lg", "Xl", "FullScreen" }
    };

    public static readonly EnumInfo ProgressType = new()
    {
        Name = "ProgressType",
        Description = "Progress indicator style",
        Values = new() { "Linear", "Circular", "Indeterminate" }
    };

    public static List<EnumInfo> All => new()
    {
        ButtonVariant, ButtonType, TypographyScale, FlareColorRole,
        ThemeMode, Variant, Size, Severity, SnackbarSeverity,
        ColumnAlign, Placement, DialogSize, ProgressType
    };
}
