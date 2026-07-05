using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using Flare.McpServer.Models;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Tools;

[McpServerToolType]
public sealed class GenerateCodeTool
{
    [McpServerTool, Description("Generate Blazor Razor code snippet for a Flare component with optional parameter overrides.")]
    public static string GenerateCode(
        ComponentCatalog catalog,
        [Description("Component name. Examples: Button, Card, DataGrid, Select, TextField")] string component,
        [Description("JSON object of parameter overrides. Example: {\"Variant\": \"Filled\", \"Color\": \"Primary\"}")] string? parameters = null,
        [Description("Predefined variant: 'basic', 'compound', 'form'. Default is 'basic'.")] string? variant = null)
    {
        var componentInfo = catalog.GetByName(component);
        if (componentInfo is null)
        {
            return JsonSerializer.Serialize(new
            {
                error = $"Component '{component}' not found. Use list_components to see available components."
            }, new JsonSerializerOptions { WriteIndented = true });
        }

        Dictionary<string, string>? paramOverrides = null;
        if (!string.IsNullOrEmpty(parameters))
        {
            try
            {
                paramOverrides = JsonSerializer.Deserialize<Dictionary<string, string>>(parameters);
            }
            catch
            {
                return JsonSerializer.Serialize(new
                {
                    error = "Invalid parameters JSON. Expected format: {\"Variant\": \"Filled\", \"Color\": \"Primary\"}"
                }, new JsonSerializerOptions { WriteIndented = true });
            }
        }

        var code = GenerateRazorCode(componentInfo, paramOverrides, variant);

        return JsonSerializer.Serialize(new
        {
            component = componentInfo.Name,
            displayName = componentInfo.DisplayName,
            code,
            notes = GetGenerationNotes(componentInfo, variant)
        }, new JsonSerializerOptions { WriteIndented = true });
    }

    private static string GenerateRazorCode(
        ComponentInfo component,
        Dictionary<string, string>? parameters,
        string? variant)
    {
        var effectiveVariant = variant?.ToLowerInvariant() ?? "basic";

        return effectiveVariant switch
        {
            "compound" => GenerateCompoundCode(component, parameters),
            "form" => GenerateFormCode(component, parameters),
            _ => GenerateBasicCode(component, parameters)
        };
    }

    private static string GenerateBasicCode(ComponentInfo component, Dictionary<string, string>? parameters)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("@using Flare.Components");
        sb.AppendLine("@using Flare.Abstractions");
        sb.AppendLine();

        var attrs = BuildAttributes(component, parameters);
        var hasChildContent = component.Parameters.Any(p => p.Name == "ChildContent");
        var displayName = component.DisplayName;

        if (hasChildContent)
        {
            sb.AppendLine($"<{displayName}{attrs}>");
            sb.AppendLine($"    {GetDefaultContent(component)}");
            sb.AppendLine($"</{displayName}>");
        }
        else
        {
            sb.AppendLine($"<{displayName}{attrs} />");
        }

        return sb.ToString();
    }

    private static string GenerateCompoundCode(ComponentInfo component, Dictionary<string, string>? parameters)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("@using Flare.Components");
        sb.AppendLine("@using Flare.Abstractions");
        sb.AppendLine();

        var attrs = BuildAttributes(component, parameters);
        var displayName = component.DisplayName;

        if (component.SubComponents.Count == 0)
            return GenerateBasicCode(component, parameters);

        sb.AppendLine($"<{displayName}{attrs}>");

        foreach (var sub in component.SubComponents)
        {
            var subDisplayName = sub.StartsWith("Flare") ? sub : $"Flare{sub}";
            sb.AppendLine($"    <{subDisplayName}>");
            sb.AppendLine($"        {GetSubComponentContent(sub)}");
            sb.AppendLine($"    </{subDisplayName}>");
        }

        sb.AppendLine($"</{displayName}>");
        return sb.ToString();
    }

    private static string GenerateFormCode(ComponentInfo component, Dictionary<string, string>? parameters)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("@using Flare.Components");
        sb.AppendLine("@using Flare.Abstractions");
        sb.AppendLine();

        var displayName = component.DisplayName;
        var isInput = component.Category == "Inputs" || component.Category == "Buttons";

        if (isInput && component.Name != "Button")
        {
            var varName = char.ToLowerInvariant(component.Name[0]) + component.Name[1..];
            sb.AppendLine($"<{displayName} @bind-Value=\"{varName}\"");
            sb.AppendLine($"         Label=\"{component.Name}\" />");
            sb.AppendLine();
            sb.AppendLine("@code {");
            sb.AppendLine($"    private string {varName} = \"\";");
            sb.AppendLine("}");
        }
        else
        {
            return GenerateBasicCode(component, parameters);
        }

        return sb.ToString();
    }

    private static string BuildAttributes(ComponentInfo component, Dictionary<string, string>? parameters, bool isForm = false)
    {
        if (parameters is null || parameters.Count == 0)
            return "";

        var attrs = new List<string>();
        foreach (var (key, value) in parameters)
        {
            var param = component.Parameters.FirstOrDefault(p =>
                p.Name.Equals(key, StringComparison.OrdinalIgnoreCase));

            if (param is null) continue;

            var enumType = GetEnumType(param.Type);
            if (enumType is not null)
            {
                attrs.Add($"{key}=\"@{enumType}.{value}\"");
            }
            else if (param.Type == "bool")
            {
                attrs.Add($"{key}=\"@{value.ToLowerInvariant()}\"");
            }
            else
            {
                attrs.Add($"{key}=\"{value}\"");
            }
        }

        return attrs.Count > 0 ? " " + string.Join(" ", attrs) : "";
    }

    private static string? GetEnumType(string typeName)
    {
        return typeName switch
        {
            "Variant" => "Variant",
            "ButtonVariant" => "ButtonVariant",
            "ButtonType" => "ButtonType",
            "TypographyScale" => "TypographyScale",
            "FlareColor" => "FlareColor",
            "Size" => "Size",
            "ThemeMode" => "ThemeMode",
            "Severity" => "Severity",
            "SnackbarSeverity" => "SnackbarSeverity",
            "ColumnAlign" => "ColumnAlign",
            "Placement" => "Placement",
            "DialogSize" => "DialogSize",
            "ProgressType" => "ProgressType",
            _ => null
        };
    }

    private static string GetDefaultContent(ComponentInfo component)
    {
        return component.Name switch
        {
            "Button" => "Click me",
            "Link" => "Link text",
            "Chip" => "Tag",
            "Badge" => "5",
            "Text" => "Hello, Flare!",
            "Accordion" => "<!-- Add FlareAccordionPanel children -->",
            "Tabs" => "<!-- Add FlareTab children -->",
            "Stepper" => "<!-- Add FlareStep children -->",
            "Menu" => "<!-- Add FlareMenuItem children -->",
            "Select" => "<!-- Items passed via Items parameter -->",
            "DataGrid" => "<!-- Add FlareColumn children -->",
            "Card" => "<!-- Add FlareCardHeader/Content/Actions children -->",
            "NavMenu" => "<!-- Add FlareNavLink/FlareNavGroup children -->",
            "Grid" => "<!-- Add FlareCol children -->",
            "Stack" => "<!-- Stack children -->",
            "Popover" => "<!-- Trigger element + popover content -->",
            _ => "<!-- Content -->"
        };
    }

    private static string GetSubComponentContent(string subComponent)
    {
        return subComponent switch
        {
            "FlareCardHeader" => "<FlareText Typo=\"TypographyScale.HeadlineMedium\">Title</FlareText>",
            "FlareCardContent" => "<FlareText Typo=\"TypographyScale.BodyMedium\">Card content goes here</FlareText>",
            "FlareCardActions" => "<FlareButton Variant=\"ButtonVariant.Filled\">Action</FlareButton>",
            "FlareCardFooter" => "<!-- Footer content -->",
            "FlareCardMedia" => "<!-- Image/media embed -->",
            "CardHeader" => "<FlareText Typo=\"TypographyScale.HeadlineMedium\">Title</FlareText>",
            "CardContent" => "<FlareText Typo=\"TypographyScale.BodyMedium\">Card content goes here</FlareText>",
            "CardActions" => "<FlareButton Variant=\"ButtonVariant.Filled\">Action</FlareButton>",
            "CardFooter" => "<!-- Footer content -->",
            "CardMedia" => "<!-- Image/media embed -->",
            "FlareColumn" => "<!-- DataGrid column definition -->",
            "FlareColumnBand" => "<!-- Grouped column headers -->",
            "FlareColumnRow" => "<!-- Multi-row headers -->",
            "FlareTab" => "Tab content here",
            "FlareAccordionPanel" => "Accordion panel content",
            "FlareStep" => "Step content",
            "FlareNavLink" => "<!-- Navigation link -->",
            "FlareNavGroup" => "<!-- Nested navigation links -->",
            "FlareMenuItem" => "Menu item",
            "FlareMenuGroup" => "<!-- Sub menu items -->",
            "FlareSubMenu" => "<!-- Nested menu items -->",
            "FlareCol" => "<!-- Grid column -->",
            _ => "<!-- Content -->"
        };
    }

    private static List<string> GetGenerationNotes(ComponentInfo component, string? variant)
    {
        var notes = new List<string>();

        if (component.DisplayName.StartsWith("Flare"))
            notes.Add($"Component is used as <{component.DisplayName}> in Razor markup");

        if (component.SubComponents.Count > 0)
        {
            notes.Add($"This component has sub-components: {string.Join(", ", component.SubComponents)}");
            notes.Add("Use variant='compound' to generate code with sub-components");
        }

        if (component.Category == "Inputs")
        {
            notes.Add("Use @bind-Value for two-way data binding");
            notes.Add("Use variant='form' to generate a complete form field with @code block");
        }

        if (component.Events.Count > 0)
            notes.Add($"Available events: {string.Join(", ", component.Events.Select(e => e.Name))}");

        notes.Add("All components start with 'Flare' prefix (e.g., FlareButton, FlareTextField)");
        notes.Add("Variants use enums: ButtonVariant.Filled, TypographyScale.HeadlineMedium, etc.");
        notes.Add("Colors use FlareColor: FlareColor.Primary, FlareColor.Success, FlareColor.Custom(\"#E91E63\")");

        return notes;
    }
}
