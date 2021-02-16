using aspnetcore_apexcharts.Charts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts
{
    public class NetApexChart : ChartResponse
    {
        protected string[] Labels { get; set; }
        public  AreaChart AreaChart() => new AreaChart();
        public DonutChart DonutChart() => new DonutChart();
    }
}