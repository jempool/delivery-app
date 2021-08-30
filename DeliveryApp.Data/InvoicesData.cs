using System;
using System.Data;
using System.Linq;

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

        public static string GetNewInvoiceNumber()
        {
            string query = "declare @InvoiceNumber as VarChar(16)"
                           + " select @InvoiceNumber = "
                           + "'INV00' + Cast( ( select Count(Id) + 1 from Invoices ) as VarChar(10) )"
                           + " select @InvoiceNumber as 'InvoiceNumber'";

            var dataTable = Connection.ExecuteSQLQuery(query);
            var invoiceNumber = (from DataRow dr in dataTable.Rows 
            select new
            { 
                Value = dr["InvoiceNumber"].ToString(),
            }).First();
            
            return invoiceNumber.Value;
        }
    }   
}