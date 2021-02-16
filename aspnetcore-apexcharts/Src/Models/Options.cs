using System.Collections.Generic;
using aspnetcore_apexcharts.Config;

namespace aspnetcore_apexcharts.Models
{
    public class Options
    {
        public Chart Chart { get; set; } = new Chart();
        public PlotOptions PlotOptions { get; set; } = new PlotOptions();
        public string[] Colors { get; set; } = DefaultColorDataSets.Colors;
        public IEnumerable<Series> Series { get; set; }
        public DataLabels DataLabels { get; set; } = new DataLabels();
        public Title Title { get; set; } = new Title();
        public SubTitle SubTitle { get; set; } = new SubTitle();
        public Xaxis Xaxis { get; set; } = new Xaxis();
        public Grid Grid { get; set; } = new Grid();
        public Makers Makers { get; set; } = new Makers();
    }
}