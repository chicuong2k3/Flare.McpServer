using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Tools;

[McpServerToolType]
public sealed class GetComponentTool
{
    [McpServerTool, Description("Get full API reference and documentation for a Flare component including parameters, events, sub-components, usage examples, and detailed docs.")]
    public static string GetComponent(
        ComponentCatalog catalog,
        ComponentDocs docs,
        [Description("Component name (case-insensitive). Examples: Button, DataGrid, Card, Select, TextField")] string name,
        [Description("Include full documentation markdown. Default: true")] bool includeDocs = true)
    {
        var component = catalog.GetByName(name);

        if (component is null)
        {
            var suggestions = catalog.GetAll()
                .Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .Select(c => c.Name)
                .Take(5)
                .ToList();

            var message = $"Component '{name}' not found.";
            if (suggestions.Count > 0)
                message += $" Did you mean: {string.Join(", ", suggestions)}?";
            else
                message += " Use list_components to see all available components.";

            return JsonSerializer.Serialize(new { error = message },
                new JsonSerializerOptions { WriteIndented = true });
        }

        if (!includeDocs)
        {
            return JsonSerializer.Serialize(component, new JsonSerializerOptions { WriteIndented = true });
        }

        var doc = docs.GetDoc(name);

        var result = new
        {
            component.Name,
            component.DisplayName,
            component.Category,
            component.Description,
            component.Parameters,
            component.Events,
            component.SubComponents,
            component.Examples,
            component.Tags,
            Documentation = doc ?? $"No detailed documentation available for {name}.",
            component.DocUrl,
            component.ApiUrl
        };

        return JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true });
    }
}
