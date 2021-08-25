using System;

namespace DeliveryApp.Data
{
    public class CustomersData
    {
        public static void Create(string customerName, string customerFono, string customerAddress )
        {
            string query = "INSERT INTO Customers (Name, PhoneNumber, Address)"
                           + $"VALUES ('{customerName}', {customerFono}, '{customerAddress}')";
            
            Connection.ExecuteSQLQuery(query);
        }

        public static void Update(int Id, string customerName, string customerFono, string customerAddress)
        {
            Console.WriteLine($"Update Customer: {Id}, {customerName}, {customerFono}, {customerAddress}\n");
        }
    }   
}