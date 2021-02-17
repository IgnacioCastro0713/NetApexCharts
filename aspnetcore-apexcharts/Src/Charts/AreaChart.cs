using System.Linq;
using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class AreaChart : NetApexChart, IComplexData<NetApexChart>
    {
        public AreaChart()
        {
            MainChar.Options.Chart.Type = "area";
        }
    }
}