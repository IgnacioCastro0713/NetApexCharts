using aspnetcore_apexcharts.Contracts;

namespace aspnetcore_apexcharts.Charts
{
    public class AreaChart: ChartApex, IComplexData
    {
        public AreaChart() => Type = "donut";
        

        public void Add(string name, string[] data)
        {
        }
    }
}