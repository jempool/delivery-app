using DeliveryApp.Data;

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
    }
}