using System;
using System.Collections.Generic;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Logic
{
    public class DeliveriesLogic
    {
        public static void Create()
        {
        }

        public static void Update()
        {
        }

        public static List<Delivery> GetAll()
        {
            return DeliveriesData.GetAll();
        }

        public static List<Delivery> FilterByDateRange(DateTime from, DateTime to)
        {
            return DeliveriesData.FilterByDateRange(from, to);
        }
    }
}