using System.Data;
using System.Data.SqlClient;

namespace DeliveryApp.Data
{
    public static class Connection
    {          
        public static DataTable ExecuteSQLQuery(string query)
        {
            string connectionString = GetConnectionString();
            var dataTable = new DataTable();

            using (SqlConnection connection = new())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = new SqlCommand(query, connection);
                var dataReader = command.ExecuteReader();   
                dataTable.Load(dataReader); 
            }

            return dataTable;
        }

        static private string GetConnectionString()
        {
            return "Server=(localdb)\\MSSQLLocalDB;Database=SQLDeliveryDB;"
            + "Trusted_Connection=True;MultipleActiveResultSets=true";
        }
    }
}
