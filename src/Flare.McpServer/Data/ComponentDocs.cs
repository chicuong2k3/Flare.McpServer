using System.Reflection;

namespace Flare.McpServer.Data;

public class ComponentDocs
{
    private readonly Dictionary<string, string> _docs;

    public ComponentDocs()
    {
        _docs = new(StringComparer.OrdinalIgnoreCase);
        LoadDocsFromEmbeddedResources();
    }

    private void LoadDocsFromEmbeddedResources()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceNames = assembly.GetManifestResourceNames()
            .Where(r => r.Contains("Docs.") && r.EndsWith(".md"));

        foreach (var resourceName in resourceNames)
        {
            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream is null) continue;

            using var reader = new StreamReader(stream);
            var content = reader.ReadToEnd();

            var parts = resourceName.Split('.');
            var name = parts[^2];

            _docs[name] = content;
        }
    }

    public string? GetDoc(string componentName)
    {
        _docs.TryGetValue(componentName, out var doc);
        return doc;
    }

    public bool HasDoc(string componentName) => _docs.ContainsKey(componentName);

    public IReadOnlyList<string> GetAvailableDocs() => _docs.Keys.Order().ToList().AsReadOnly();
}
