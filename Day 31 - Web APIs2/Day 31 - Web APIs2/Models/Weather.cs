using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_31___Web_APIs2.Models
{

    public class WeatherRoot
    {
        public WeatherDatum[] data { get; set; }
        public int count { get; set; }
    }

    public class WeatherDatum
    {
        public string wind_cdir { get; set; }
        public string state_code { get; set; }
        public string city_name { get; set; }
        public int rh { get; set; }
        public float wind_spd { get; set; }
        public string lat { get; set; }
        public string wind_cdir_full { get; set; }
        public string lon { get; set; }
        public float app_temp { get; set; }
        public float dewpt { get; set; }
        public int vis { get; set; }
        public int uv { get; set; }
        public float pres { get; set; }
        public string ob_time { get; set; }
        public int visibility_val { get; set; }
        public string sunrise { get; set; }
        public object precip3h { get; set; }
        public string timezone { get; set; }
        public int wind_dir { get; set; }
        public Weather weather { get; set; }
        public string datetime { get; set; }
        public object precip { get; set; }
        public string station { get; set; }
        public string country_code { get; set; }
        public float slp { get; set; }
        public string sunset { get; set; }
        public float temp { get; set; }
        public string visibility { get; set; }
        public int clouds { get; set; }
        public int ts { get; set; }
    }

    public class Weather
    {
        public string icon { get; set; }
        public string code { get; set; }
        public string description { get; set; }
    }

}
