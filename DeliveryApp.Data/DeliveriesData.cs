using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Data
{
    public class DeliveriesData
    {
        public static void Create()
        {
        }

        public static void Update()
        {
        }

        public static List<Delivery> GetAll()
        {
            string query = "SELECT Deliveries.ID, Orders.OrderNumber, Orders.DueTime, Customers.Name, Deliveries.Status"
                         + " FROM Orders INNER JOIN Deliveries ON Orders.ID=Deliveries.ID"
                         + " INNER JOIN Customers ON Orders.CustomerId=Customers.ID";
            
            var dataTable = Connection.ExecuteSQLQuery(query);
            List<Delivery> deliveriesList = (from DataRow dr in dataTable.Rows  
            select new Delivery()  
            {  
                Id = Convert .ToInt32 (dr["ID"]),
                OrderNumber = (long)dr["OrderNumber"],
                DueTime = DateTime.Parse(dr["DueTime"].ToString()),
                CustomerName = dr["Name"].ToString(),
                Status = dr["Status"].ToString()
            }).ToList(); 

            return deliveriesList;
        }
    }   
}