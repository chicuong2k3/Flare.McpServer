namespace Flare.McpServer.Models;

public record ComponentInfo
{
    public string Name { get; init; } = string.Empty;
    public string DisplayName { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string DocUrl { get; init; } = string.Empty;
    public string ApiUrl { get; init; } = string.Empty;
    public List<ComponentParameter> Parameters { get; init; } = new();
    public List<ComponentEvent> Events { get; init; } = new();
    public List<string> SubComponents { get; init; } = new();
    public List<string> Examples { get; init; } = new();
    public List<string> Tags { get; init; } = new();
}
