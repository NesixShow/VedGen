using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.DataFile
{
    internal class DataBase
    {
        public static SqlConnection sqlConnection = new SqlConnection(
           @"Server=(localdb)\mssqllocaldb" +
           "Database=AutoVed;" +
           "Trusted_Connection=True;");

        public static void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public static void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public static DataTable GetData(string sqlCommand, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
