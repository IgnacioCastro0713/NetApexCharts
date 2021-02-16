using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class DonutChart : NetApexChart, ISimpleData<DonutChart>
    {
        public DonutChart() => Options.Chart.Type = "donut";

        public DonutChart AddData(int[] data)
        {
            var series = new Series {Name = "", Data = data};
            Options.Series = new[]
            {
                series
            };
            return this;
        }
    }
}