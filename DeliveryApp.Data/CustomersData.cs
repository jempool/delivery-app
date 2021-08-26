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
                           + $"VALUES ('{customerName}', {customerFono}, '{customerAddress}')";
            
            Connection.ExecuteSQLQuery(query);
        }

        public static void Update(int Id, string customerName, string customerFono, string customerAddress)
        {
            // TODO: Implement this method
            Console.WriteLine($"Update Customer: {Id}, {customerName}, {customerFono}, {customerAddress}\n");
        }

        public static List<Customer> GetAll()
        {
            string query = "SELECT * FROM Customers";
            
            var dataTable = Connection.ExecuteSQLQuery(query);
            List<Customer> customertList = (from DataRow dr in dataTable.Rows  
            select new Customer()  
            {  
                Id = Convert.ToInt32(dr["ID"]),
                Name = dr["Name"].ToString(),
                PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]),
                Address = dr["Address"].ToString(),
            }).ToList(); 

            return customertList;
        }
    }   
}