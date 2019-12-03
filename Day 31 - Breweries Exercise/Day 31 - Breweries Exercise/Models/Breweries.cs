using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day_31___Breweries_Exercise.Models
{
    public enum States
    {
        Alabama, 
        Alaska, Arizona, Arkansas, California, Colorado, Connecticut, Delaware,
        [Display(Name = "Washington D.C.")]
        DistrictofColumbia, 
        Florida, Georgia, Guam, Hawaii, Idaho, Illinois, 
        Indiana, Iowa, Kansas, Kentucky, Louisiana, Maine, Maryland, 
        Massachusetts, Michigan, Minnesota, 
        Mississippi, Missouri, Montana, Nebraska, Nevada,
        [Display(Name = "New Hampshire")]
        NewHampshire,
        [Display(Name = "New Jersey")]
        NewJersey,
        [Display(Name = "New Mexico")]
        NewMexico,
        [Display(Name = "New York")]
        NewYork,
        [Display(Name = "North Carolina")]
        NorthCarolina,
        [Display(Name = "North Dakota")]
        NorthDakota, 
        Ohio, Oklahoma, Oregon, Pennsylvania,
        [Display(Name = "Rhode Island")]
        RhodeIsland,
        [Display(Name = "South Carolina")]
        SouthCarolina,
        [Display(Name = "South Dakota")]
        SouthDakota, Tennessee, Texas, Utah, Vermont, Virginia, Washington,
        [Display(Name = "West Virginia")]
        WestVirginia, Wisconsin, Wyoming
    }

    public class BreweryRoot
    {
        public Brewery[] Property1 { get; set; }
    }

    public class Brewery
    {
        public int id { get; set; }
        public string name { get; set; }
        public string brewery_type { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string phone { get; set; }
        public string website_url { get; set; }
        public DateTime updated_at { get; set; }
        public object[] tag_list { get; set; }
    }

}
