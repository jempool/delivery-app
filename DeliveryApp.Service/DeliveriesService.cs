using System;
using System.Collections.Generic;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Service
{
    public class DeliveriesService
    {
        public static void CreateDelivery(string status, int orderId)
        {
            DeliveriesData.Create(status, orderId);
        }

        public static List<Delivery> GetAllDeliveries()
        {
            return DeliveriesData.GetAll();
        }

        public static List<Delivery> FilterDeliveriesByDateRange(DateTime from, DateTime to)
        {
            return DeliveriesData.FilterByDateRange(from, to);
        }
    }
}