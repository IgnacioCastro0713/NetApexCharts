using System.Collections.Generic;
using System.Text.Json;
using aspnetcore_apexcharts.Charts;
using aspnetcore_apexcharts.Config;
using aspnetcore_apexcharts.Models;
using Newtonsoft.Json;

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

        public NetApexChart SetWidth(string width)
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

        public NetApexChart SetGrid(bool transparent = true, string color = "#e5e5e5", double opacity = 0.1)
        {
            if (transparent)
            {
                MainChar.Options.Grid.Show = true;
                return this;
            }

            MainChar.Options.Grid.Row = new Row
            {
                Colors = new[] {color, "transparent"},
                Opacity = opacity
            };

            return this;
        }

        public NetApexChart SetMakers(string[] colors = null, int width = 4, int hoverSize = 7)
        {
            colors ??= DefaultColorDataSets.Colors;

            MainChar.Options.Makers = new Makers()
            {
                Size = width,
                Colors = colors,
                StrokeColors = "#fff",
                StrokeWidth = (double) width / 2,
                Hover = new Hover {Size = hoverSize}
            };

            return this;
        }

        public NetApexChart SetStroke(int width, string[] colors)
        {
            colors ??= DefaultColorDataSets.Colors;

            MainChar.Options.Stroke = new Stroke
            {
                Show = true,
                Width = width,
                Colors = colors
            };
            return this;
        }

        public NetApexChart SetToolbar(bool show, bool zoom = true)
        {
            MainChar.Options.Chart.Toolbar = new Toolbar {Show = show};
            MainChar.Options.Chart.Zoom = new Zoom {Enable = zoom};
            return this;
        }


        public NetApexChart SetDataLabels()
        {
            MainChar.Options.DataLabels = new DataLabels {Enable = true};
            return this;
        }

        public string ToJson()
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.SerializeObject(MainChar, settings);
        }

        #endregion
    }
}