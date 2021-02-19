using aspnetcore_apexcharts.Config;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Options
    {
        private Series[] _series;
        public Chart Chart { get; set; } = new Chart();
        public PlotOptions PlotOptions { get; set; } = new PlotOptions();
        public string[] Colors { get; set; } = DefaultColorDataSets.Colors;

        public Series[] Series
        {
            get => _series;
            set => _series = value;
        }


        public DataLabels DataLabels { get; set; } = new DataLabels();
        public Title Title { get; set; } = new Title();
        public SubTitle SubTitle { get; set; } = new SubTitle();
        public Xaxis Xaxis { get; set; } = new Xaxis();
        public Grid Grid { get; set; } = new Grid();
        public Makers Makers { get; set; } = new Makers();

        public string[] Labels { get; set; }
        public Stroke Stroke { get; set; }
    }
}