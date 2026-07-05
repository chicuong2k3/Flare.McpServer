using System.ComponentModel;
using System.Text.Json;
using Flare.McpServer.Data;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;

namespace Flare.McpServer.Resources;

[McpServerResourceType]
public sealed class ThemingResourceProvider
{
    private readonly ComponentDocs _docs;

    public ThemingResourceProvider(ComponentDocs docs)
    {
        _docs = docs;
    }

    [McpServerResource(UriTemplate = "flare://theming", Name = "Theming Topics", MimeType = "application/json")]
    [Description("List of available Flare theming documentation topics")]
    public string ListThemingResources()
    {
        var topics = new[]
        {
            new { uri = "flare://theming/overview", name = "Overview", description = "General theming concepts: axes, tokens, color API" },
            new { uri = "flare://theming/design-systems", name = "Design Systems", description = "Seven design systems: MD3 Expressive, MD3, MD2, Fluent UI 2, Aero, Liquid Glass, VS 2026" },
            new { uri = "flare://theming/palettes", name = "Palettes", description = "34+ built-in palettes, Dynamic Color, and custom palette creation" },
            new { uri = "flare://theming/customization", name = "Customization", description = "Token overrides, custom palettes, theme derivation, unified color API" },
            new { uri = "flare://theming/dark-mode", name = "Dark Mode", description = "Auto dark mode, anti-FOUC bootstrap, runtime mode switching" },
            new { uri = "flare://theming/getting-started", name = "Getting Started", description = "Quick start guide: install, DI setup, styles, first component" },
            new { uri = "flare://theming/ai-agents", name = "For AI Agents", description = "Compact, machine-friendly reference for LLM coding agents" },
            new { uri = "flare://theming/architecture", name = "Architecture", description = "Modules, tokens, services, theming engine deep-dive" },
            new { uri = "flare://theming/theme-creation-guide", name = "Theme Creation Guide", description = "Design tokens, palettes, custom themes, Dynamic Color" },
            new { uri = "flare://theming/component-conventions", name = "Component Conventions", description = "CSS, tokens, FlareColor, XML docs rules" }
        };

        return JsonSerializer.Serialize(new
        {
            topics,
            total = topics.Length
        }, new JsonSerializerOptions { WriteIndented = true });
    }

    [McpServerResource(UriTemplate = "flare://theming/{topic}", Name = "Theming Documentation", MimeType = "text/markdown")]
    [Description("Get Flare theming documentation for a specific topic")]
    public ResourceContents GetThemingTopic(string topic)
    {
        var content = topic.ToLowerInvariant() switch
        {
            "design-systems" => ThemingData.DesignSystems,
            "palettes" => ThemingData.Palettes,
            "customization" => ThemingData.Customization,
            "dark-mode" => ThemingData.DarkMode,
            "getting-started" => _docs.GetDoc("getting-started") ?? ThemingData.GettingStarted,
            "ai-agents" => _docs.GetDoc("ai-agents") ?? "# AI Agents doc not available",
            "architecture" => _docs.GetDoc("architecture") ?? "# Architecture doc not available",
            "theme-creation-guide" => _docs.GetDoc("theme-creation-guide") ?? "# Theme Creation Guide not available",
            "component-conventions" => _docs.GetDoc("component-conventions") ?? "# Component Conventions not available",
            "overview" => ThemingData.Overview,
            _ => $"# Topic Not Found\n\nTopic '{topic}' not found. Available topics: overview, design-systems, palettes, customization, dark-mode, getting-started, ai-agents, architecture, theme-creation-guide, component-conventions"
        };

        return new TextResourceContents
        {
            Uri = $"flare://theming/{topic.ToLowerInvariant()}",
            MimeType = "text/markdown",
            Text = content
        };
    }
}
