using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Data
{
    public class ProductsData
    {
        public static List<Product> GetAll()
        {
            string query = "SELECT * FROM Products";
            
            var dataTable = Connection.ExecuteSQLQuery(query);
            List<Product> ProductList = (from DataRow dr in dataTable.Rows  
            select new Product()  
            {  
                Id = Convert.ToInt32(dr["ID"]),  
                Name = dr["Name"].ToString(),  
                Price = Convert.ToInt32(dr["Price"]),                
            }).ToList(); 

            return ProductList;
        }
    }   
}