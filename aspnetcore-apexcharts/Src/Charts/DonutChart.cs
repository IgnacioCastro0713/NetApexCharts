using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class DonutChart : ChartApex, ISimpleData
    {
        public DonutChart() => Options.Chart.Type = "donut";

        public void Add(int[] data)
        {
            var series = new Series {Name = "", Data = data};
            Options.Series = new[]
            {
                series
            };
        }
    }
}