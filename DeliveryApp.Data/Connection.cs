using System.Data.SqlClient;

namespace DeliveryApp.Data
{
    public static class Connection
    {          
        public static SqlDataReader ExecuteSQLQuery(string query)
        {
            string connectionString = GetConnectionString();
            SqlDataReader dataReader = null;

            using (SqlConnection connection = new())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();    
            }

            return dataReader;
        }

        static private string GetConnectionString()
        {
            return "Server=(localdb)\\MSSQLLocalDB;Database=SQLDeliveryDB;"
            + "Trusted_Connection=True;MultipleActiveResultSets=true";
        }
    }
}
