using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Resources;

[McpServerResourceType]
public sealed class ComponentResourceProvider
{
    private readonly ComponentIndex _index;
    private readonly ComponentDocs _docs;
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    public ComponentResourceProvider(ComponentIndex index, ComponentDocs docs)
    {
        _index = index;
        _docs = docs;
    }

    [McpServerResource(UriTemplate = "flare://components", Name = "All Components", MimeType = "application/json")]
    [Description("List of all Flare component resource URIs")]
    public string ListComponentResources()
    {
        var components = _index.GetAll();
        var resources = components.Select(c => new
        {
            uri = $"flare://components/{c.Name.ToLowerInvariant()}",
            name = c.Name,
            description = c.Description,
            hasDocs = _docs.HasDoc(c.Name),
            mimeType = "text/markdown"
        });

        return JsonSerializer.Serialize(new
        {
            resources,
            total = components.Count
        }, JsonOptions);
    }

    [McpServerResource(UriTemplate = "flare://components/{name}", Name = "Component Documentation", MimeType = "text/markdown")]
    [Description("Get full API reference and documentation for a specific Flare component as markdown")]
    public ResourceContents GetComponentResource(string name)
    {
        var entry = _index.GetByName(name);

        if (entry is null)
        {
            return new TextResourceContents
            {
                Uri = $"flare://components/{name}",
                MimeType = "text/markdown",
                Text = $"# Component Not Found\n\nComponent '{name}' not found.\n\nAvailable: {string.Join(", ", _index.GetAll().Select(c => c.Name).Order())}"
            };
        }

        var doc = _docs.GetDoc(name) ?? $"# {entry.DisplayName}\n\n{entry.Description}\n\n*No detailed documentation available.*";

        return new TextResourceContents
        {
            Uri = $"flare://components/{name.ToLowerInvariant()}",
            MimeType = "text/markdown",
            Text = doc
        };
    }
}
