using System.Linq;
using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class AreaChart : NetApexChart, IComplexData<AreaChart>
    {
        public AreaChart()
        {
            MainChar.Options.Chart.Type = "area";
        }

        public AreaChart AddData(string name, int[] data)
        {
            var series = new Series {Data = data, Name = name};
            if (MainChar.Options.Series == null)
            {
                MainChar.Options.Series = new[] {series};
                return this;
            }

            MainChar.Options.Series = MainChar.Options.Series.Concat(new[] {series}).ToArray();
            return this;
        }
    }
}