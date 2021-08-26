using System;

namespace DeliveryApp.Data.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public long OrderNumber { get; set; }
        public DateTime DueTime { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public string[] ToArrString()
        {
            return new string[]
            {
                OrderNumber.ToString(),
                DueTime.ToShortDateString(),
                CustomerName,
                Status,
                DueTime.ToShortTimeString()
            };
        }
    }    
}