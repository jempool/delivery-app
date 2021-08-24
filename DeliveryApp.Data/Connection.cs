using System;
using System.Data.SqlClient;

namespace DeliveryApp.Data
{
    public class Connection
    {
        public static SqlConnection Connect()
        {
            SqlConnection cn = new SqlConnection("SERVER=(localdb)\\MSSQLLocalDB;DATABASE=SQLDeliveryDB;Integrated security=true");
            cn.Open();

            try
            {
                cn.Open();
                Console.WriteLine("Connected!");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection fails {0}", ex);
            }

            return cn;
        }
    }
}
