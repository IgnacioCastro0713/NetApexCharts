using System.Linq;
using aspnetcore_apexcharts.Config;
using aspnetcore_apexcharts.Models;
using Newtonsoft.Json;

namespace aspnetcore_apexcharts
{
    public class NetApexChart
    {
        #region Properties

        protected ChartResponse MainChar { get; }

        #endregion

        #region Constructors

        protected NetApexChart() => MainChar = new ChartResponse();

        #endregion

        #region Methods

        public NetApexChart SetType(string type)
        {
            MainChar.Options.Chart.Type = type;
            return this;
        }

        public NetApexChart SetDataSets(Series[] series)
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
            MainChar.Options.SubTitle.Align = position;
            return this;
        }

        public NetApexChart SetLabels(string[] labels)
        {
            MainChar.Options.Labels = labels;
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
                //Hover = new Hover {Size = hoverSize}
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
            MainChar.Options.Chart.Zoom = new Zoom {Enabled = zoom};
            return this;
        }


        public NetApexChart SetDataLabels(bool enable = true)
        {
            MainChar.Options.DataLabels = new DataLabels {Enabled = enable};
            return this;
        }

        public string ToJson()
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.None,
                NullValueHandling = NullValueHandling.Ignore
            };

            var series = MainChar.Options.Series;
            var array = MainChar.Options.Series.SelectMany(s => s.Data).ToArray();

            if (MainChar.Options.Chart.Type.Equals("donut"))
            {
                return JsonConvert.SerializeObject(new
                {
                    MainChar.Id,
                    Options = new
                    {
                        MainChar.Options.Chart,
                        MainChar.Options.PlotOptions,
                        MainChar.Options.Colors,
                        Series = array,
                        MainChar.Options.DataLabels,
                        MainChar.Options.Title,
                        MainChar.Options.SubTitle,
                        MainChar.Options.Xaxis,
                        MainChar.Options.Grid,
                        MainChar.Options.Makers,
                        MainChar.Options.Labels,
                        MainChar.Options.Stroke,
                    }
                }, settings);
            }

            return JsonConvert.SerializeObject(new
            {
                MainChar.Id,
                Options = new
                {
                    MainChar.Options.Chart,
                    MainChar.Options.PlotOptions,
                    MainChar.Options.Colors,
                    Series = series,
                    MainChar.Options.DataLabels,
                    MainChar.Options.Title,
                    MainChar.Options.SubTitle,
                    MainChar.Options.Xaxis,
                    MainChar.Options.Grid,
                    MainChar.Options.Makers,
                    MainChar.Options.Labels,
                    MainChar.Options.Stroke,
                }
            }, settings);
        }

        #endregion
    }
}