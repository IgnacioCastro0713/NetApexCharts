﻿using aspnetcore_apexcharts.Contracts;

namespace aspnetcore_apexcharts.Charts
{
    public class DonutChart : ChartApex, ISimpleData
    {
        public DonutChart() => Type = "donut";

        public void Add(string[] data)
        {
        }
    }
}