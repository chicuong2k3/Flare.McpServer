using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Tools;

[McpServerToolType]
public sealed class GetThemingTool
{
    [McpServerTool, Description("Get Flare theming information. Topics: overview, design-systems, palettes, customization, dark-mode, getting-started.")]
    public static string GetTheming(
        [Description("Theming topic: 'overview', 'design-systems', 'palettes', 'customization', 'dark-mode', or 'getting-started'. Default is 'overview'.")] string topic = "overview")
    {
        var content = topic.ToLowerInvariant() switch
        {
            "design-systems" => ThemingData.DesignSystems,
            "palettes" => ThemingData.Palettes,
            "customization" => ThemingData.Customization,
            "dark-mode" => ThemingData.DarkMode,
            "getting-started" => ThemingData.GettingStarted,
            _ => ThemingData.Overview
        };

        return JsonSerializer.Serialize(new
        {
            topic,
            content,
            availableTopics = new[] { "overview", "design-systems", "palettes", "customization", "dark-mode", "getting-started" }
        }, new JsonSerializerOptions { WriteIndented = true });
    }
}
