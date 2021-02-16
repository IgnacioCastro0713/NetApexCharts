using System;
using System.Linq;

namespace aspnetcore_apexcharts
{
    public class ChartApex
    {
        private static string ChartLetters { get; } = "abcdefghijklmnopqrstuvwxyz";

        public string Id { get; set; } = new string(Enumerable.Repeat(ChartLetters, 25)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());
        protected string Type { get; set; } = "donut";
        
    }
}