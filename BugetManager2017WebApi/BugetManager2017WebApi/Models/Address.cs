using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugetManager2017WebApi.Models
{
    public class Address
    {
        private string addr;

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        private int zipCode;

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }





    }
}