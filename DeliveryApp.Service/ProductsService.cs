using System.Collections.Generic;
using DeliveryApp.Data;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Service
{
    public class ProductsService
    {
        public static List<Product> GetAllProducts()
        {
            return ProductsData.GetAll();
        }
    }
}