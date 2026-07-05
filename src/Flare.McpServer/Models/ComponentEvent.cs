namespace Flare.McpServer.Models;

public record ComponentEvent
{
    public string Name { get; init; } = string.Empty;
    public string Type { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
}
