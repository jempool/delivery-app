using System;
using System.Collections.Generic;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Logic
{
    public class OrdersLogic
    {
        public static void Create(string orderNumber, DateTime dueTime, int totalPrice, int customerId, List<Product> productList)
        {
            OrdersData.Create(orderNumber, dueTime, totalPrice, customerId, productList);
        }

        public static List<Order> GetAll()
        {
            return OrdersData.GetAll();
        }
    }
}