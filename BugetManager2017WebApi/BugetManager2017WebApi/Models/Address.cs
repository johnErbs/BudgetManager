using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugetManager2017WebApi.Models
{
    public class Address
    {
        private static int id;
        public static int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string roadName, city;

        private int roadNumber, zipCode;

        public string RoadName
        {
            get { return roadName; }
            set { roadName = value; }
        }

        public int RoadNumber
        {
            get { return roadNumber; }
            set { roadNumber = value; }
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
     
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}