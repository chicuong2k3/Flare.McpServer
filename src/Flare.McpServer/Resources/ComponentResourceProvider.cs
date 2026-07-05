using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Resources;

[McpServerResourceType]
public sealed class ComponentResourceProvider
{
    private readonly ComponentCatalog _catalog;
    private readonly ComponentDocs _docs;
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    public ComponentResourceProvider(ComponentCatalog catalog, ComponentDocs docs)
    {
        _catalog = catalog;
        _docs = docs;
    }

    [McpServerResource(UriTemplate = "flare://components", Name = "All Components", MimeType = "application/json")]
    [Description("List of all Flare component resource URIs")]
    public string ListComponentResources()
    {
        var components = _catalog.GetAll();
        var resources = components.Select(c => new
        {
            uri = $"flare://components/{c.Name.ToLowerInvariant()}",
            name = c.Name,
            description = c.Description,
            hasDocs = _docs.HasDoc(c.Name),
            mimeType = "application/json"
        });

        return JsonSerializer.Serialize(new
        {
            resources,
            total = components.Count
        }, JsonOptions);
    }

    [McpServerResource(UriTemplate = "flare://components/{name}", Name = "Component Details", MimeType = "application/json")]
    [Description("Get full details and documentation for a specific Flare component")]
    public ResourceContents GetComponentResource(string name)
    {
        var component = _catalog.GetByName(name);

        if (component is null)
        {
            return new TextResourceContents
            {
                Uri = $"flare://components/{name}",
                MimeType = "application/json",
                Text = JsonSerializer.Serialize(new
                {
                    error = $"Component '{name}' not found",
                    availableComponents = _catalog.GetAll().Select(c => c.Name).Order()
                }, JsonOptions)
            };
        }

        var doc = _docs.GetDoc(name);

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
            Documentation = doc,
            component.DocUrl,
            component.ApiUrl
        };

        return new TextResourceContents
        {
            Uri = $"flare://components/{name.ToLowerInvariant()}",
            MimeType = "application/json",
            Text = JsonSerializer.Serialize(result, JsonOptions)
        };
    }
}
