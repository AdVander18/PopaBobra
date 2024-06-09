using System.Data.SqlClient;

namespace СтраныЕвропы
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection
            (@"Data Source=AYAYAYAY\SQLEXPRESS;Initial Catalog=СтраныЕвропы;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
