using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugetManager2017WebApi.Models
{
    public class BudgetModel
    {
        public string Headline { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}