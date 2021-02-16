using System.Collections.Generic;
using aspnetcore_apexcharts.Charts;
using aspnetcore_apexcharts.Models;

namespace aspnetcore_apexcharts
{
    public class NetApexChart
    {
        #region Properties

        protected ChartResponse MainChar { get; }
        private string[] Labels { get; set; }

        #endregion

        #region Constructors

        public NetApexChart() => MainChar = new ChartResponse();

        // Chart constructors
        public AreaChart AreaChart() => new AreaChart();
        public DonutChart DonutChart() => new DonutChart();

        #endregion

        #region Methods

        public NetApexChart SetType(string type)
        {
            MainChar.Options.Chart.Type = type;
            return this;
        }

        public NetApexChart SetDataSets(IEnumerable<Series> series)
        {
            MainChar.Options.Series = series;
            return this;
        }

        public NetApexChart SetHeight(int height)
        {
            MainChar.Options.Chart.Height = height;
            return this;
        }
        
        public NetApexChart SetWidth(int width)
        {
            MainChar.Options.Chart.Width = width;
            return this;
        }

        public NetApexChart SetColors(string[] colors)
        {
            MainChar.Options.Colors = colors;
            return this;
        }

        public NetApexChart SetHorizontal(bool horizontal)
        {
            MainChar.Options.PlotOptions.Bar.Horizontal = horizontal;
            return this;
        }

        public NetApexChart SetTitle(string title)
        {
            MainChar.Options.Title.Text = title; 
            return this;
        }
        
        public NetApexChart SetSubTitle(string subtitle, string position = "left")
        {
            MainChar.Options.SubTitle.Text = subtitle;
            MainChar.Options.SubTitle.Position = position;
            return this;
        }

        public NetApexChart SetLabels(string[] labels)
        {
            Labels = labels;
            return this;
        }

        public NetApexChart SetXAxis(string[] categories)
        {
            MainChar.Options.Xaxis.Categories = categories;
            return this;
        }

        #endregion
    }
}