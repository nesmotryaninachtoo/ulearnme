﻿using System;
using System.Globalization;

namespace class_creation
{
    class Program
    {
        static void Main()
        {
            var city = new City();
            city.Name = "Ekaterinburg";
            city.Location = new GeoLocation();
            city.Location.Latitude = 56.50;
            city.Location.Longitude = 60.35;
            Console.WriteLine("I love {0} located at ({1}, {2})", 
                city.Name, 
                city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
                city.Location.Latitude.ToString(CultureInfo.InvariantCulture));
        }
    }
    
    public  class City
    {
        public string Name;
        public GeoLocation Location;
    }
    
    public  class GeoLocation
    {
        public double Longitude;
        public double Latitude;
    }
}