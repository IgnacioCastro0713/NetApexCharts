using aspnetcore_apexcharts.Models.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Stroke: ShowAttribute
    {
        public int Width { get; set; }
        public string[] Colors { get; set; }
    }
}