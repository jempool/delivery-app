using DeliveryApp.Data;

namespace DeliveryApp.Logic
{
    public class ProductsLogic
    {
        public static string[][] ListProducts()
        {
            string[] row1 = { "Super Pizza", "1", "150" };
            string[] row2 = { "Coke", "2", "50" };
            string[][] output = {row1, row2};
            return output;
        }

        public static void Update(string customerName, string customerFono, string customerAddress)
        {
            // TODO: implement method
            int id = 0;
            CustomersData.Update(id, customerName, customerFono, customerAddress); 
        }
    }
}