using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class DonutChart : NetApexChart, ISimpleData<NetApexChart>
    {
        public DonutChart()
        {
            MainChar.Options.Chart.Type = "donut";
        }
    }
}