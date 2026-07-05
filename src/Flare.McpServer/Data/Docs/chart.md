# FlareChart

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
