using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Tools;

[McpServerToolType]
public sealed class SearchComponentsTool
{
    [McpServerTool, Description("Search Flare components by keyword. Searches names, descriptions, parameters, tags, and categories.")]
    public static string SearchComponents(
        ComponentCatalog catalog,
        [Description("Search query. Examples: 'button', 'input', 'modal', 'toggle', 'data', 'layout'")] string query)
    {
        var results = catalog.Search(query);

        var output = results.Select(c => new
        {
            c.Name,
            c.Category,
            c.Description,
            c.DisplayName,
            ParameterCount = c.Parameters.Count
        });

        return JsonSerializer.Serialize(new
        {
            query,
            results = output,
            total = results.Count
        }, new JsonSerializerOptions { WriteIndented = true });
    }
}
