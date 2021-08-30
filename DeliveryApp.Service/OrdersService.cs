using System;
using System.Collections.Generic;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Service
{
    public class OrdersService
    {
        public static int CreateOrder(string orderNumber, DateTime dueTime, int totalPrice, int customerId, List<Product> productList)
        {
            return OrdersData.Create(orderNumber, dueTime, totalPrice, customerId, productList);
        }

        public static List<Order> GetAllOrders()
        {
            return OrdersData.GetAll();
        }

        public static string GetNewOrderNumber()
        {
            return OrdersData.GetNewOrderNumber();
        }
    }
}