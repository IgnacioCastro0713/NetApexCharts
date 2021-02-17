using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models.Common
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ShowAttribute
    {
        public bool Show { get; set; } = false;
    }
}