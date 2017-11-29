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
    public class OrganizationController : ApiController
    {
        // GET: api/Organization
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Organization/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Organization
        public void Post(Organization organization)
        {
            DAL.Open();
            DAL.CreateOrg(organization);
            DAL.Close();
        }

        // PUT: api/Organization/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Organization/5
        public void Delete(int id)
        {
        }
    }
}
