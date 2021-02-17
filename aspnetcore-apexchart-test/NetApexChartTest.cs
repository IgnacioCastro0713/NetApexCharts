using System;
using aspnetcore_apexcharts;
using NUnit.Framework;

namespace aspnetcore_apexchart_test
{
    public class NetApexChartTest
    {
        [Test]
        public void Test1()
        {
            var json = new NetApexChart().DonutChart()
                .AddData(new[] {1, 2, 3})
                .SetLabels(new []{"Player 7", "Player 10", "Player 9"})
                .SetTitle("Top 3 scorers of the team.")
                .SetSubTitle("Season 2021.")
                .ToJson();
            Console.WriteLine(json);
            Assert.Pass();
        }
    }
}