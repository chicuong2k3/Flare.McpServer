# FlareChart (Chart)

**Category**: DataDisplay
**Tags**: chart, graph, visualization, data, plot, svg
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareChart.html](https://jrfrigat.github.io/Flare/api/FlareChart.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

SVG chart component supporting line, bar, pie, and donut charts with theme colors, hover tooltips, and legend.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `Type` | `ChartType` | Yes | `Line` | Chart type (Line, Bar, Pie, Donut) |
| `Data` | `IEnumerable<ChartDataPoint>` | Yes | `` | Chart data points |
| `Width` | `string` | No | `100%` | Chart width (CSS value) |
| `Height` | `string` | No | `300px` | Chart height (CSS value) |
| `ShowLegend` | `bool` | No | `true` | Show chart legend |
| `ShowTooltip` | `bool` | No | `true` | Show hover tooltips |
| `Colors` | `FlareColor[]` | No | `` | Color array for data series |

## Examples

```razor
<FlareChart Type="ChartType.Bar" Data="_chartData" ShowLegend="true" />
```

```razor
<FlareChart Type="ChartType.Pie" Data="_pieData" Height="400px" />
```

---

SVG charts with theme colors, hover tooltips, and legend.

```razor
<FlareChart Type="ChartType.Bar" Data="_chartData" ShowLegend="true" />
<FlareChart Type="ChartType.Pie" Data="_pieData" Height="400px" />
<FlareChart Type="ChartType.Line" Data="_lineData" />
<FlareChart Type="ChartType.Donut" Data="_donutData" />
```

## Chart Types
- `ChartType.Line` - line chart
- `ChartType.Bar` - bar chart
- `ChartType.Pie` - pie chart
- `ChartType.Donut` - donut chart

## Key Parameters
- `Data` - `IEnumerable<ChartDataPoint>` (required)
- `Width` / `Height` - chart dimensions
- `ShowLegend` - toggle legend
- `ShowTooltip` - hover tooltips
- `Colors` - custom color array
