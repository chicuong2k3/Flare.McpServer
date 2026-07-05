using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Tools;

[McpServerToolType]
public sealed class SearchComponentsTool
{
    [McpServerTool, Description("Search Flare components by keyword. Searches names, descriptions, tags, and categories.")]
    public static string SearchComponents(
        ComponentIndex index,
        ComponentDocs docs,
        [Description("Search query. Examples: 'button', 'input', 'modal', 'toggle', 'data', 'layout'")] string query,
        [Description("Also search full documentation content (slower but more thorough). Default: false")] bool deep = false)
    {
        var results = index.Search(query);

        if (deep)
        {
            var lowerQuery = query.ToLowerInvariant();
            var matchedNames = new HashSet<string>(results.Select(r => r.Name), StringComparer.OrdinalIgnoreCase);

            foreach (var entry in index.GetAll())
            {
                if (matchedNames.Contains(entry.Name)) continue;
                var doc = docs.GetDoc(entry.Name);
                if (doc?.Contains(lowerQuery, StringComparison.OrdinalIgnoreCase) == true)
                {
                    results = results.Append(entry).ToList().AsReadOnly();
                    matchedNames.Add(entry.Name);
                }
            }
        }

        var output = results.Select(c => new
        {
            c.Name,
            c.Category,
            c.Description,
            c.DisplayName
        });

        return JsonSerializer.Serialize(new
        {
            query,
            results = output,
            total = results.Count
        }, new JsonSerializerOptions { WriteIndented = true });
    }
}
