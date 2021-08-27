using System;
using DeliveryApp.Data;

namespace DeliveryApp.Logic
{
    public class InvoicesLogic
    {
        public static void Create(string invoiceNumber, DateTime expeditionDate, int orderId)
        {
            InvoicesData.Create(invoiceNumber, expeditionDate, orderId);
        }
    }
}