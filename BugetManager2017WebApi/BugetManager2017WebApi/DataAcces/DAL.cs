using BugetManager2017WebApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BugetManager2017WebApi.DataAcces
{
    public class DAL
    {
        //Author Johnny Schmidt Erbs
        static public SqlConnection connection = null;

        //Author Johnny Schmidt Erbs
        //Opens sqlConnection
        public static void Open()
        {
            try
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TransactionDB"].ConnectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Author Johnny Schmidt Erbs
        //Close SqlConnection
        public static void Close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Author Johnny Schmidt Erbs
        //Inserts new Adress into database
        internal static void CreateAddr(Address address)
        {
            //try
            //{
            //    SqlCommand createCmd = new SqlCommand("INSERT INTO Address (AddressLine, ZipCode, City) VALUES(@addr, @zipCode, @city)", connection);
            //    createCmd.Parameters.Add(CreateParam("@addr", address.Addr, SqlDbType.NVarChar));
            //    createCmd.Parameters.Add(CreateParam("@zipCode", address.ZipCode, SqlDbType.NVarChar));
            //    createCmd.Parameters.Add(CreateParam("@city", address.City, SqlDbType.NVarChar));

            //    createCmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        //Author Johnny Schmidt Erbs
        //Inserts new Organization into database
        internal static void CreateOrg(Organization organization)
        {
            try
            {
                SqlCommand createCmd = new SqlCommand("INSERT INTO Organization (ApiKey, Name)VALUES(@apiKey, @name)",connection);
                createCmd.Parameters.Add(CreateParam("@apiKey", organization.ApiKey, SqlDbType.NVarChar));
                createCmd.Parameters.Add(CreateParam("@name", organization.Name, SqlDbType.NVarChar));

                createCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Author Johnny Schmidt Erbs
        //Creates SqlParameter (Sets value to data)
        public static SqlParameter CreateParam(string name, object value, SqlDbType type)
        {
            SqlParameter param = new SqlParameter(name, type);
            param.Value = value;
            return param;
        }
    }
}



//OldFiles...
        //private static bool _ListIsCleared { get; set; }

        //private static List<Transaction> transactionslist = new List<Transaction>();
        //public static List<Transaction> Transactionslist
        //{
        //    get { return transactionslist; }
        //    set { transactionslist = value; }
        //}

        //internal static void CreateTemplate(BudgetModel template)
        //{
        //    try
        //    {
        //        SqlCommand tablecmd = new SqlCommand("CREATE TABLE "+template.Name+"(TemplateID INT PRIMARY KEY IDENTITY(1, 1), Headline NVARCHAR(255), Description NVARCHAR(255), Year SMALLINT)", connection);
        //        tablecmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //internal static void CreateTemplate(string[] value)
        //{
        //    throw new NotImplementedException();
        //}

        //public static void Select()
        //{
        //    SqlCommand command1 = new SqlCommand("SELECT * FROM Transactions", connection);
        //    try
        //    {
        //        using (SqlDataReader DR = command1.ExecuteReader())
        //        {
        //            while (DR.Read())     //Mens DR Læser...
        //            {
        //                //Her addes der til liste fra 1. kollone i TableName.
        //                int id = DR.GetInt32(0);
        //                double amount = DR.GetDouble(1);
        //                DateTime date = DR.GetDateTime(2);
        //                string description = DR.GetString(3);
        //                int subID = DR.GetInt32(4);
        //                string img = DR.GetString(5);


        //                for (int i = 0; i < transactionslist.Count; i++)
        //                {

        //                    if (transactionslist[i].TransactionID == id)
        //                    {
        //                        transactionslist.Clear();
        //                        _ListIsCleared = true;
        //                    }
        //                }
        //                if (transactionslist.Count == 0)
        //                {
        //                    _ListIsCleared = true;
        //                }
        //                if (_ListIsCleared)
        //                {
        //                    transactionslist.Add(new Transaction { Img = img,TransactionID = id, Amount = amount, Date = date, Description = description, SubCat = subID });
        //                }
        //            }

        //            _ListIsCleared = false;
        //        }
        //    }

        //    catch (SqlException ex)
        //    {

        //    }
        //}