using System;
using System.Collections.Generic;

namespace DeliveryApp.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DueTime { get; set; }
        public int TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public List<Product> Products { get; set; }
    }
}