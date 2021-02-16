using System;
using System.Linq;

namespace aspnetcore_apexcharts.Models
{
    public class ChartResponse
    {
        private static string ChartLetters { get; } = "abcdefghijklmnopqrstuvwxyz";

        protected string Id { get; set; } = new string(Enumerable.Repeat(ChartLetters, 25)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());

        protected Options Options { get; set; }
    }
}