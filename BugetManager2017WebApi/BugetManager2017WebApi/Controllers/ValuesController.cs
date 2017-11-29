using BugetManager2017WebApi.DataAcces;
using BugetManager2017WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugetManager2017WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        
        // GET api/values
        public IEnumerable<string> Get(BudgetModel template)
        {
            //Test
            return new string[] { template.Headline, template.Year.ToString(), template.Description  };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(BudgetModel template)
        {
            //Test
            //DAL.Open();
            //DAL.CreateTemplate(template);
            //DAL.Close();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
