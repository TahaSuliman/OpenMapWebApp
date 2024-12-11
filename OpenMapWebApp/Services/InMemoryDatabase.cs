using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Caching.Memory;

namespace OpenMapWebApp.Services
{
    public static class InMemoryDatabase
    {
        // Static lists to hold points and areas
        private static readonly List<Point> Points;
        private static readonly List<Area> Areas;

        // Static constructor to initialize the data
  
        static InMemoryDatabase()
        {
            Points = new List<Point>
        {
        new Point { Id = 1, Latitude = 15.556944451163426, Longitude = 32.53857276961871, Name = "Khartoum Central Market", FontAwesomeIcon = "fa-shopping-cart" },
        new Point { Id = 2, Latitude = 15.573750189134438, Longitude =  32.52325394261977, Name = "Khartoum International Airport", FontAwesomeIcon = "fa-plane" },
        new Point { Id = 3, Latitude = 15.670190236387963, Longitude = 32.44506872265578, Name = "Omdurman National Museum", FontAwesomeIcon = "fa-landmark" },
        new Point { Id = 4, Latitude = 15.604014017872915, Longitude =  32.467480021897494, Name = "Bahri Train Station", FontAwesomeIcon = "fa-train" },
        new Point { Id = 5, Latitude = 15.505491060542097, Longitude = 32.62914385439807, Name = "Soba Hospital", FontAwesomeIcon = "fa-hospital" },
        new Point { Id = 6, Latitude = 15.725375431118852, Longitude = 32.58595165852446, Name = "Mogran Park", FontAwesomeIcon = "fa-tree" },
        new Point { Id = 7, Latitude = 15.600725837343882, Longitude = 32.629368683721296, Name = "Tuti Island", FontAwesomeIcon = "fa-water" }
        };

       Areas = new List<Area>
       {
        new Area { Id = 1, Name = "Khartoum Area", FontAwesomeIcon = "fa-building" , Coordinates = new List<Coordinate>
        {
       new Coordinate { Latitude = 15.516723711260669, Longitude = 32.518386804693506 }, // Starting Point
        new Coordinate { Latitude = 15.537734366209941, Longitude = 32.51282074677144 },  // Moved earlier
        new Coordinate { Latitude = 15.54511643981513, Longitude = 32.507964812548884 },  // Adjusted
        new Coordinate { Latitude = 15.560567165241523, Longitude = 32.50612451350737 },  // Kept original
        new Coordinate { Latitude = 15.557023280624394, Longitude = 32.52301922580827 },  // Adjusted slightly to avoid crossing
        new Coordinate { Latitude = 15.516723711260669, Longitude = 32.518386804693506 }  // Closing Point
        }},


        new Area { Id = 2, Name = "Omdurman Area",FontAwesomeIcon = "fa-monument" , Coordinates = new List<Coordinate>
        {
            new Coordinate { Latitude = 15.630, Longitude = 32.560 },
            new Coordinate { Latitude = 15.640, Longitude = 32.580 },
            new Coordinate { Latitude = 15.650, Longitude = 32.590 },
            new Coordinate { Latitude = 15.660, Longitude = 32.570 },
            new Coordinate { Latitude = 15.670, Longitude = 32.550 },
            new Coordinate { Latitude = 15.650, Longitude = 32.530 }
        }},
        new Area { Id = 3, Name = "Bahri Area",FontAwesomeIcon = "fa-university" , Coordinates = new List<Coordinate>
        {
            new Coordinate { Latitude = 15.510, Longitude = 32.410 },
            new Coordinate { Latitude = 15.520, Longitude = 32.430 },
            new Coordinate { Latitude = 15.530, Longitude = 32.440 },
            new Coordinate { Latitude = 15.540, Longitude = 32.430 },
            new Coordinate { Latitude = 15.530, Longitude = 32.410 },
            new Coordinate { Latitude = 15.520, Longitude = 32.390 },
            new Coordinate { Latitude = 15.510, Longitude = 32.400 }
        }},
        new Area { Id = 4, Name = "Soba Area",FontAwesomeIcon = "fa-user" , Coordinates = new List<Coordinate>
        {
            new Coordinate { Latitude = 15.700, Longitude = 32.680 },
            new Coordinate { Latitude = 15.710, Longitude = 32.700 },
            new Coordinate { Latitude = 15.720, Longitude = 32.710 },
            new Coordinate { Latitude = 15.730, Longitude = 32.690 },
            new Coordinate { Latitude = 15.720, Longitude = 32.670 }
        }},
        new Area { Id = 5, Name = "Shambat Area",FontAwesomeIcon = "fa-home" , Coordinates = new List<Coordinate>
        {
            new Coordinate { Latitude = 15.800, Longitude = 32.750 },
            new Coordinate { Latitude = 15.810, Longitude = 32.770 },
            new Coordinate { Latitude = 15.820, Longitude = 32.780 },
            new Coordinate { Latitude = 15.830, Longitude = 32.760 },
            new Coordinate { Latitude = 15.820, Longitude = 32.740 },
            new Coordinate { Latitude = 15.810, Longitude = 32.730 }
        }}
        };
        }



        public static List<Point> GetPoints()
        {
            return Points;
        }

        public static List<Area> GetAreas()
        {
            return Areas;
        }
    }

    public class Point
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public string FontAwesomeIcon { get; set; }

        
    }

    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string FontAwesomeIcon { get; set; }

        public List<Coordinate> Coordinates { get; set; }
    }

    public class Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
