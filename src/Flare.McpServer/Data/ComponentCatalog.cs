using System.Reflection;
using System.Text.Json;
using Flare.McpServer.Models;

namespace Flare.McpServer.Data;

public class ComponentCatalog
{
    private readonly Dictionary<string, ComponentInfo> _components;
    private readonly JsonSerializerOptions _jsonOptions = new() { PropertyNameCaseInsensitive = true };

    public ComponentCatalog()
    {
        _components = new(StringComparer.OrdinalIgnoreCase);
        LoadComponentsFromEmbeddedResources();
    }

    private void LoadComponentsFromEmbeddedResources()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceNames = assembly.GetManifestResourceNames()
            .Where(r => r.Contains("Components.") && r.EndsWith(".json"));

        foreach (var resourceName in resourceNames)
        {
            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream is null) continue;

            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            var component = JsonSerializer.Deserialize<ComponentInfo>(json, _jsonOptions);

            if (component is not null && !string.IsNullOrEmpty(component.Name))
                _components[component.Name] = component;
        }
    }

    public IReadOnlyList<ComponentInfo> GetAll() => _components.Values.ToList().AsReadOnly();

    public ComponentInfo? GetByName(string name)
    {
        _components.TryGetValue(name, out var component);
        return component;
    }

    public IReadOnlyList<ComponentInfo> Search(string query)
    {
        var lowerQuery = query.ToLowerInvariant();
        return _components.Values
            .Where(c =>
                c.Name.Contains(lowerQuery, StringComparison.OrdinalIgnoreCase) ||
                c.Description.Contains(lowerQuery, StringComparison.OrdinalIgnoreCase) ||
                c.Category.Contains(lowerQuery, StringComparison.OrdinalIgnoreCase) ||
                c.Tags.Any(t => t.Contains(lowerQuery, StringComparison.OrdinalIgnoreCase)) ||
                c.Parameters.Any(p =>
                    p.Name.Contains(lowerQuery, StringComparison.OrdinalIgnoreCase) ||
                    p.Description.Contains(lowerQuery, StringComparison.OrdinalIgnoreCase)))
            .OrderByDescending(c => GetRelevanceScore(c, lowerQuery))
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyList<ComponentInfo> GetByCategory(string category)
    {
        return _components.Values
            .Where(c => c.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyList<string> GetCategories()
    {
        return _components.Values
            .Select(c => c.Category)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .Order()
            .ToList()
            .AsReadOnly();
    }

    private static int GetRelevanceScore(ComponentInfo component, string query)
    {
        var score = 0;
        if (component.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) score += 100;
        if (component.Category.Contains(query, StringComparison.OrdinalIgnoreCase)) score += 50;
        if (component.Tags.Any(t => t.Contains(query, StringComparison.OrdinalIgnoreCase))) score += 30;
        if (component.Description.Contains(query, StringComparison.OrdinalIgnoreCase)) score += 10;
        return score;
    }
}
