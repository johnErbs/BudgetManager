using BugetManager2017WebApi.DataAcces;
using BugetManager2017WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugetManager2017WebApi.Controllers
{
    public class HomeController : Controller
    {
        // View to FrontPage
        public ActionResult Index()
        {
            ViewBag.Title = "Budget Manager";

            return View();
        }

        //Author Johnny Schmidt Erbs
        // Vew List of Created Budgets
        public ActionResult BudgetIndex()
        {

            //NOTE! Virker ikke før vi har oprettet en ny Database!!!!

            //TransactionsController getTrans = new TransactionsController();
            //getTrans.Get();
            //ViewBag.Transactions = DAL.Transactionslist;
            return View();
        }

        //Author Johnny Schmidt Erbs
        //View to create new Budget 
        public ActionResult CreateBugetTemplate()
        {
            return View();
        }

        //Author Johnny Schmidt Erbs
        //View to create new Organization 
        public ActionResult CreateOrganization()
        {
            return View();
        }
        public void SendTo_ApiOrg(string Command, Address address, Organization organization)
        {
            if (Command == "createOrg")
            {
                AddressController addr = new AddressController();
                addr.Post(address);
                OrganizationController org = new OrganizationController();
                org.Post(organization);
            }

        }










        //Test
        public ActionResult CreateTable(string Command, BudgetModel template)
        {
            string headline = template.Headline;

            if (Command == "createTable")
            {
                ValuesController VC = new ValuesController();
                VC.Post(template);
            }
            return View();
        }
        //Test
        public ActionResult BudgetCreator()
        {
            //TestClass should be renamed.. to "Budget"
            BudgetModel x = new BudgetModel();
            //x.Headline = 
            return View();
        }
    }
}
