using System.Collections.Generic;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Logic
{
    public class ProductsLogic
    {
        public static List<Product> GetAll()
        {
            return ProductsData.GetAll();
        }
    }
}