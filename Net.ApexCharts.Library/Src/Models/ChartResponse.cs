using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace aspnetcore_apexcharts.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ChartResponse
    {
        private static string ChartLetters { get; } = "abcdefghijklmnopqrstuvwxyz";

        public string Id { get; set; } = new string(Enumerable.Repeat(ChartLetters, 25)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());

        public Options Options { get; set; } = new Options();
    }
}