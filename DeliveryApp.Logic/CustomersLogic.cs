using System.Collections.Generic;
using System.Data;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Logic
{
    public class CustomersLogic
    {
        public static void Create(string customerName, string customerFono, string customerAddress)
        {
            CustomersData.Create(customerName, customerFono, customerAddress);
        }

        public static void Update(string customerName, string customerFono, string customerAddress)
        {
            // TODO: implement method
            int id = 0;
            CustomersData.Update(id, customerName, customerFono, customerAddress); 
        }

        public static List<Customer> GetAll()
        {
            return CustomersData.GetAll();
        }

        public static List<Customer> GetByNamePattern(string pattern)
        {
            return CustomersData.GetByNamePattern(pattern);
        }
    }
}