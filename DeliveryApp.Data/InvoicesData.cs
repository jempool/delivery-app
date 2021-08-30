using System;

namespace DeliveryApp.Data
{
    public class InvoicesData
    {
        public static void Create(string invoiceNumber, DateTime expeditionDate, int orderId)
        {
            string query = "INSERT INTO Invoices (InvoiceNumber, ExpeditionDate, OrderId)" 
                        + $" VALUES ('{invoiceNumber}', '{expeditionDate:MM/dd/yyyy HH:mm:ss.fff}', {orderId})";

            Connection.ExecuteSQLQuery(query);
        }
    }   
}