using aspnetcore_apexcharts.Charts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts
{
    public class NetApexChart: ChartResponse
    {

        public string[] Labels { get; set; }


        public AreaNetApexChart AreaChart()
        {
            return new AreaNetApexChart();
        }
        
        public DonutNetApexChart DonutChart()
        {
            return new DonutNetApexChart();
        }
    }
}