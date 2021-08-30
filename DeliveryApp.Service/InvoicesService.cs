using System;
using DeliveryApp.Data;

namespace DeliveryApp.Service
{
    public class InvoicesService
    {
        public static void Create(string invoiceNumber, DateTime expeditionDate, int orderId)
        {
            InvoicesData.Create(invoiceNumber, expeditionDate, orderId);
        }
    }
}