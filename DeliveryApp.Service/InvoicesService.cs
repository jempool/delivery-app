using System;
using DeliveryApp.Data;

namespace DeliveryApp.Service
{
    public class InvoicesService
    {
        public static void CreateInvoice(string invoiceNumber, DateTime expeditionDate, int orderId)
        {
            InvoicesData.Create(invoiceNumber, expeditionDate, orderId);
        }

        public static string GetNewInvoiceNumber()
        {
            return InvoicesData.GetNewInvoiceNumber();
        }
    }
}