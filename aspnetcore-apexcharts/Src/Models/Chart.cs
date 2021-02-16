namespace aspnetcore_apexcharts.Models
{
    public class Chart
    {
        public string Type { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Toolbar Toolbar { get; set; }
    }
}