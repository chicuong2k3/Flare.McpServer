using System.Reflection;
using System.Text.Json;

namespace Flare.McpServer.Data;

public class ComponentIndex
{
    private readonly List<ComponentEntry> _components;
    private readonly Dictionary<string, ComponentEntry> _byName;
    private readonly List<string> _categories;
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };

    public ComponentIndex()
    {
        _byName = new(StringComparer.OrdinalIgnoreCase);
        var json = LoadIndexJson();
        var data = JsonSerializer.Deserialize<IndexData>(json, JsonOptions);

        _components = data?.Components ?? [];
        _categories = data?.Categories ?? [];

        foreach (var entry in _components)
        {
            if (!string.IsNullOrEmpty(entry.Name))
                _byName[entry.Name] = entry;
        }
    }

    private static string LoadIndexJson()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "Flare.McpServer.Data.Components._index.json";
        using var stream = assembly.GetManifestResourceStream(resourceName);
        using var reader = new StreamReader(stream!);
        return reader.ReadToEnd();
    }

    public IReadOnlyList<ComponentEntry> GetAll() => _components.AsReadOnly();

    public ComponentEntry? GetByName(string name)
    {
        _byName.TryGetValue(name, out var entry);
        return entry;
    }

    public IReadOnlyList<string> GetCategories() => _categories.AsReadOnly();

    public IReadOnlyList<ComponentEntry> GetByCategory(string category)
    {
        return _components
            .Where(c => c.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyList<ComponentEntry> Search(string query)
    {
        var lower = query.ToLowerInvariant();
        return _components
            .Where(c =>
                c.Name.Contains(lower, StringComparison.OrdinalIgnoreCase) ||
                c.Description.Contains(lower, StringComparison.OrdinalIgnoreCase) ||
                c.Category.Contains(lower, StringComparison.OrdinalIgnoreCase) ||
                (c.Tags?.Any(t => t.Contains(lower, StringComparison.OrdinalIgnoreCase)) ?? false))
            .OrderByDescending(c => GetRelevanceScore(c, lower))
            .ToList()
            .AsReadOnly();
    }

    private static int GetRelevanceScore(ComponentEntry c, string query)
    {
        var score = 0;
        if (c.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) score += 100;
        if (c.Category.Contains(query, StringComparison.OrdinalIgnoreCase)) score += 50;
        if (c.Tags?.Any(t => t.Contains(query, StringComparison.OrdinalIgnoreCase)) == true) score += 30;
        if (c.Description.Contains(query, StringComparison.OrdinalIgnoreCase)) score += 10;
        return score;
    }

    private record IndexData(List<ComponentEntry> Components, List<string> Categories);
}

public record ComponentEntry
{
    public string Name { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string DisplayName { get; init; } = string.Empty;
    public List<string> Tags { get; init; } = [];
    public string File { get; init; } = string.Empty;
}
