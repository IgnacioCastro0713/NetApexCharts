using aspnetcore_apexcharts.Contracts;

namespace aspnetcore_apexcharts.Charts
{
    public class AreaChart: ChartApex, IComplexData
    {
        public AreaChart() => Options.Chart.Type = "area";
        
        public void Add(string name, int[] data)
        {
        }
    }
}