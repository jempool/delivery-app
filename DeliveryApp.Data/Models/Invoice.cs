using System;

namespace DeliveryApp.Data.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime ExpeditionDate { get; set; }
        public int OrderId { get; set; }
    }
}