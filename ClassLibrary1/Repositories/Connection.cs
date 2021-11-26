using System;
using System.Data;
using System.Data.SqlClient;

namespace Service.Repositories
{
    public class Connection
    {
        private static SqlConnection _connection;
        private static readonly string _stringConnection = "Data Source=DESKTOP-SSND26T\\SQLEXPRESS; Initial Catalog=dbpousada;   Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            try
            {
                _connection = new SqlConnection(_stringConnection);
                _connection.Open();
                return _connection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
