using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Tools;

[McpServerToolType]
public sealed class ListComponentsTool
{
    [McpServerTool, Description("List all Flare Blazor components, optionally filtered by category. Categories: Buttons, Inputs, DataDisplay, Navigation, Overlays, Feedback, Display, Layout, IDE, Theming.")]
    public static string ListComponents(
        ComponentIndex index,
        [Description("Filter by category. Omit to list all.")] string? category = null)
    {
        var components = string.IsNullOrEmpty(category)
            ? index.GetAll()
            : index.GetByCategory(category);

        var result = components.Select(c => new
        {
            c.Name,
            c.Category,
            c.Description,
            c.DisplayName
        });

        return JsonSerializer.Serialize(new
        {
            components = result,
            total = components.Count,
            categories = index.GetCategories()
        }, new JsonSerializerOptions { WriteIndented = true });
    }
}
