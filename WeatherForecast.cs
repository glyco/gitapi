using System;

namespace gitapi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public DateTime Date2 { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureCnueva { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public string desc2 {get;set;}

        public string desc3 {get;set;}
    }
}
