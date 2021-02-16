using System.Collections.Generic;
using aspnetcore_apexcharts.Config;

namespace aspnetcore_apexcharts.Models
{
    public class Options
    {
        public Chart Chart { get; set; }
        public PlotOptions PlotOptions { get; set; }
        public string[] Colors { get; set; } = DefaultColorDataSets.Colors;
        public IEnumerable<Series> Series { get; set; }
        protected DataLabels DataLabels { get; set; }
        protected Title Title { get; set; }
        protected SubTitle SubTitle { get; set; }
        protected Xaxis Xaxis { get; set; }
        protected Grid Grid { get; set; }
        protected Makers Makers { get; set; }
    }
}