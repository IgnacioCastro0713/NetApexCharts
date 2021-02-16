using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class DonutChart : NetApexChart, ISimpleData<DonutChart>
    {
        public DonutChart() => MainChar.Options.Chart.Type = "donut";

        public DonutChart AddData(int[] data)
        {
            var series = new Series {Name = "", Data = data};
            MainChar.Options.Series = new[]
            {
                series
            };
            return this;
        }
    }
}