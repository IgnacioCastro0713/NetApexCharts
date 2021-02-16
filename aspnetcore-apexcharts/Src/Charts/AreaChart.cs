using System.Linq;
using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class AreaChart : NetApexChart, IComplexData<AreaChart>
    {
        public AreaChart() => MainChar.Options.Chart.Type = "area";
        public AreaChart AddData(string name, int[] data)
        {
            MainChar.Options.Series = MainChar.Options.Series.Concat(new[]
            {
                new Series()
                {
                    Name = name,
                    Data = data
                }
            });
            return this;
        }
    }
}