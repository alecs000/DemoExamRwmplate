using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainProject
{
    internal class DataBaseConnector
    {
        public const string connectionString = "Data source = DESKTOP-H9AB40Q; Initial catalog = MainProject; Integrated security = true";
        private SqlConnection connection = new SqlConnection(connectionString);
        public SqlConnection Connection => connection;

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection() {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
