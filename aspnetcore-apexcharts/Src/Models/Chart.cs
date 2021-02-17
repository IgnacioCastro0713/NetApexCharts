using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Chart
    {
        private string _width;
        public string Type { get; set; }
        public int Height { get; set; }

        public string Width
        {
            get => _width ?? "100%";
            set => _width = value;
        }

        public Toolbar Toolbar { get; set; } = new Toolbar();
        
        public Zoom Zoom { get; set; }
    }
}