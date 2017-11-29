using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugetManager2017WebApi.Models
{
    public class Organization
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string apiKey;

        public string ApiKey
        {
            get { return apiKey; }
            set { apiKey = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int primaryPhone;

        public int PrimaryPhone
        {
            get { return primaryPhone; }
            set { primaryPhone = value; }
        }

        private int secondaryPhone;

        public int SecondaryPhone
        {
            get { return secondaryPhone; }
            set { secondaryPhone = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int fk_budgetID;

        public int FK_BudgetID
        {
            get { return fk_budgetID; }
            set { fk_budgetID = value; }
        }



    }
}