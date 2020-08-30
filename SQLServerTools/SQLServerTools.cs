using System;
using System.Data.SqlClient;

namespace SQLServerTools
{
    public class SQLServerTools
    {
        private string serverName;
        private string databaseName;
        private string userName;
        private string password;
        private string connString;
        private SqlConnection sqlConnection;

        public SQLServerTools(String serverName, string databaseName, string userName, string password)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.userName = userName;
            this.password = password;
        }
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        public void ConnectToDatabase()
        {
            connString = @"Server=" + serverName + ";Database=" + databaseName + ";User ID=" + userName + ";Password=" + password + ";";
            sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

        }
        public SqlDataReader submitSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            //execute the SQLCommand
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
//          dr.Close();
        }

    }
}
