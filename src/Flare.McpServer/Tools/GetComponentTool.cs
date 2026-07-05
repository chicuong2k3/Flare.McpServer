using System.ComponentModel;
using Flare.McpServer.Data;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Tools;

[McpServerToolType]
public sealed class GetComponentTool
{
    [McpServerTool, Description("Get full API reference and documentation for a Flare component as markdown.")]
    public static string GetComponent(
        ComponentIndex index,
        ComponentDocs docs,
        [Description("Component name (case-insensitive). Examples: Button, DataGrid, Card, Select, TextField")] string name)
    {
        var entry = index.GetByName(name);

        if (entry is null)
        {
            var suggestions = index.GetAll()
                .Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .Select(c => c.Name)
                .Take(5)
                .ToList();

            var message = $"Component '{name}' not found.";
            if (suggestions.Count > 0)
                message += $" Did you mean: {string.Join(", ", suggestions)}?";
            else
                message += " Use list_components to see all available components.";

            return message;
        }

        var doc = docs.GetDoc(name);
        return doc ?? $"# {entry.DisplayName}\n\n{entry.Description}\n\n*No detailed documentation available.*";
    }
}
