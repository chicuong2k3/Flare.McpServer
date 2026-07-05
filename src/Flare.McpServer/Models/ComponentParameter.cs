namespace Flare.McpServer.Models;

public record ComponentParameter
{
    public string Name { get; init; } = string.Empty;
    public string Type { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string Default { get; init; } = string.Empty;
    public bool Required { get; init; }
}
