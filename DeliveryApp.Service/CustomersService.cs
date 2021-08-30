using System.Collections.Generic;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Service
{
    public class CustomersService
    {
        public static void CreateCustomer(string customerName, string customerFono, string customerAddress)
        {
            CustomersData.Create(customerName, customerFono, customerAddress);
        }

        public static void UpdateCustomer(string customerName, string customerFono, string customerAddress)
        {
            // TODO: implement method
            int id = 0;
            CustomersData.Update(id, customerName, customerFono, customerAddress); 
        }

        public static List<Customer> GetAllCustomers()
        {
            return CustomersData.GetAll();
        }

        public static List<Customer> GetCustomerByNamePattern(string pattern)
        {
            return CustomersData.GetByNamePattern(pattern);
        }
    }
}