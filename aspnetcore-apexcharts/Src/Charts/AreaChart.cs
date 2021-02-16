using System.Linq;
using aspnetcore_apexcharts.Contracts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts.Charts
{
    public class AreaChart : ChartApex, IComplexData
    {
        public AreaChart() => Options.Chart.Type = "area";

        public void Add(string name, int[] data)
        {
            Options.Series = Options.Series.Concat(new[]
            {
                new Series()
                {
                    Name = name,
                    Data = data
                }
            });
        }
    }
}