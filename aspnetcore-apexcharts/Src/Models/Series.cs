using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Series
    {
        public string Name { get; set; }
        public int[] Data { get; set; }
    }
}