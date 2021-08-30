using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Data
{
    public class CustomersData
    {
        public static void Create(string customerName, string customerFono, string customerAddress)
        {
            string query = "INSERT INTO Customers (Name, PhoneNumber, Address)"
                           + $" VALUES ('{customerName}', {customerFono}, '{customerAddress}')";
            
            Connection.ExecuteSQLQuery(query);
        }

        public static void Update(Customer customer)
        {
            string query = "UPDATE Customers"
                + $" SET Name ='{customer.Name}', PhoneNumber = {customer.PhoneNumber}, Address ='{customer.Address}'"
                + $" WHERE ID={customer.Id}";
            
            Connection.ExecuteSQLQuery(query);
        }

        public static List<Customer> GetAll()
        {
            string query = "SELECT * FROM Customers";            
            var dataTable = Connection.ExecuteSQLQuery(query);
            List<Customer> customertList = DataTableToCustomertList(dataTable); 

            return customertList;
        }

        public static List<Customer> GetByNamePattern(string pattern)
        {
            string query = $"SELECT * FROM Customers WHERE Name LIKE '%{pattern}%'";
            var dataTable = Connection.ExecuteSQLQuery(query);
            List<Customer> customertList = DataTableToCustomertList(dataTable); 

            return customertList;
        }

        private static List<Customer> DataTableToCustomertList(DataTable dataTable)
        {
            List<Customer> customerList = (from DataRow dr in dataTable.Rows
            select new Customer()  
            {  
                Id = Convert.ToInt32(dr["ID"]),
                Name = dr["Name"].ToString(),
                PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]),
                Address = dr["Address"].ToString(),
            }).ToList();

            return customerList;
        }
    }   
}