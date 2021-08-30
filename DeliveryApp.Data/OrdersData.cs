using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Data
{
    public class OrdersData
    {
        public static int Create(string orderNumber, DateTime dueTime, int totalPrice, int customerId, List<Product> productList)
        {
            string sqlProductList = OrdersData.ProductListToSQLProductList(productList);

            string query = "DECLARE @OrderId INT;"
                            + " INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId)"
                            + " OUTPUT Inserted.ID as InsertedOrderID"
                            + $" VALUES ({orderNumber}, '{dueTime:MM/dd/yyyy HH:mm:ss.fff}', {totalPrice}, {customerId})"
                            + " SET @OrderId = SCOPE_IDENTITY()"
                            + " INSERT INTO OrdersProducts (OrderId, ProductID, ProductQuantity, ProductDetails)"
                            + $" VALUES {sqlProductList}";

            var dataTable = Connection.ExecuteSQLQuery(query);
            var insertedOrderID = (from DataRow dr in dataTable.Rows  
            select new
            {  
                Value = Convert.ToInt32(dr["InsertedOrderID"]),
            }).First();
            
            return insertedOrderID.Value;
        }

        public static List<Order> GetAll()
        {
            string query = "SELECT * FROM Orders";
            
            var dataTable = Connection.ExecuteSQLQuery(query);
            List<Order> ordertList = (from DataRow dr in dataTable.Rows  
            select new Order()  
            {  
                Id = Convert.ToInt32(dr["ID"]),
                OrderNumber = dr["OrderNumber"].ToString(),
                DueTime = DateTime.Parse(dr["DueTime"].ToString()),
                TotalPrice = Convert.ToInt32(dr["TotalPrice"]),
                CustomerId = Convert.ToInt32(dr["CustomerId"]),
            }).ToList();

            return ordertList;
        }

        private static string ProductListToSQLProductList(List<Product> productList)
        {
            string sqlProductList = string.Empty;
            foreach (Product product in productList)
            {                
                sqlProductList += $"(@OrderId, {product.Id}, {product.Quantity}, '{product.Details}'),";
            }
            return sqlProductList.TrimEnd(',');
        }
    }   
}