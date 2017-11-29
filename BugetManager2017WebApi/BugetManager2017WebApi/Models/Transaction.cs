﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BugetManager2017WebApi.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        private string img;

        public string Img
        {
            get { return img; }
            set { img = value; }
        }

        public Transaction()
        {
            Date = DateTime.Now;
        }
        private int transactionID;
        public int TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private DateTime date = new DateTime();
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private string description, category;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private int subCat;
        public int SubCat
        {
            get { return subCat; }
            set { subCat = value; }
        }


    }
}