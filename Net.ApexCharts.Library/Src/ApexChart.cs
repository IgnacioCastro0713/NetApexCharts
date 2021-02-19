using aspnetcore_apexcharts.Charts;

namespace aspnetcore_apexcharts
{
    public class ApexChart : NetApexChart
    {
        // Chart constructors
        public AreaChart AreaChart() => new AreaChart();

        public DonutChart DonutChart() => new DonutChart();
    }
}