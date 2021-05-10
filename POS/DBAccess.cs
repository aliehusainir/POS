using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    class DBAccess
    {
        private static SqlConnection objConnection;
        private static SqlDataAdapter objDataAdapter;
        private static SqlCommand objCommand;

        public static string connectionString = @"Data Source=WALDO-PC; Initial Catalog=POS; Integrated Security=True;";

        private static void OpenConnection()
        {
            if (objConnection == null || objConnection.State != ConnectionState.Open)
            {
                objConnection = new SqlConnection(connectionString);
                objConnection.Open();
            }
        }
        private static void CloseConnection()
        {
            if (objConnection != null && objConnection.State == ConnectionState.Open)
            {
                objConnection.Close();
                objConnection.Dispose();
            }
        }
        public static DataTable FillDataTable(string query, DataTable table)
        {
            OpenConnection();
            objDataAdapter = new SqlDataAdapter(query, objConnection);
            objDataAdapter.Fill(table);
            objDataAdapter.Dispose();
            CloseConnection();
            return table;
        }

        public static void InsertQuery(string query)
        {
            OpenConnection();
            objCommand = new SqlCommand(query, objConnection);
            objCommand.ExecuteNonQuery();
            objCommand.Dispose();
            CloseConnection();
        }

        public static DataSet FillDataSet(string query, DataSet dataSet)
        {
            OpenConnection();
            objDataAdapter = new SqlDataAdapter(query, objConnection);
            objDataAdapter.Fill(dataSet);
            objDataAdapter.Dispose();
            CloseConnection();
            return dataSet;
        }
    }
}
