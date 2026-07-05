# Flare MCP Server

MCP (Model Context Protocol) server for the [Flare](https://github.com/jrfrigat/Flare) Blazor component library. Provides tools and resources for AI assistants (Claude, VS Code Copilot, etc.) to query Flare component documentation, generate Blazor Razor code, and access theming information.

## Features

- **116 components** cataloged with parameters, events, sub-components, usage examples, and tags
- **5 MCP tools**: `list_components`, `get_component`, `search_components`, `get_theming`, `generate_code`
- **4 MCP resources**: `flare://components`, `flare://components/{name}`, `flare://theming`, `flare://theming/{topic}`
- **6 theming topics**: overview, design-systems, palettes, customization, dark-mode, getting-started
- **Code generation**: produces valid Blazor `.razor` snippets with enum-aware parameter mapping
- **Offline**: all data embedded in the binary - no network calls at runtime

## Quick Start

### Install as .NET tool

```sh
dotnet tool install --global FlareUI.McpServer
```

### Configure in MCP client

Add to your MCP client config (Claude Desktop, VS Code, etc.):

```json
{
  "mcpServers": {
    "flare": {
      "command": "flare-mcp"
    }
  }
}
```

### Install from source

```sh
git clone https://github.com/jrfrigat/Flare.McpServer.git
cd Flare.McpServer
dotnet run --project src/Flare.McpServer
```

## Tools

| Tool | Description |
|------|-------------|
| `list_components` | List all Flare components, optionally filtered by category |
| `get_component` | Get full API reference and documentation for a component |
| `search_components` | Search components by keyword across names, descriptions, parameters, tags |
| `get_theming` | Get Flare theming documentation (design systems, palettes, dark mode, etc.) |
| `generate_code` | Generate Blazor Razor code for a component with parameter overrides |

## Resources

| URI | Description |
|-----|-------------|
| `flare://components` | Index of all 116 component resource URIs |
| `flare://components/{name}` | Full component details with documentation |
| `flare://theming` | Index of theming topics |
| `flare://theming/{topic}` | Theming documentation in markdown |

## Build

```sh
dotnet build
dotnet pack
```

## License

MIT
