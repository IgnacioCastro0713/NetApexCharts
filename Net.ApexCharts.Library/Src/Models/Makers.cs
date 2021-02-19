using System.ComponentModel;
using aspnetcore_apexcharts.Models.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Makers : ShowAttribute
    {
        public int? Size { get; set; }
        public string[] Colors { get; set; }
        public string StrokeColors { get; set; }
        public double? StrokeWidth { get; set; }

        //public Hover Hover { get; set; } = new Hover();
    }
}