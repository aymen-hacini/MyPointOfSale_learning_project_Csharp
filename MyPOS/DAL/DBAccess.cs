using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPOS.DAL
{
    internal class DBAccess
    {
        public const string ConnectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=MyPOS;Integrated Security=True";
        private static SqlConnection objConnection;
        private static SqlDataAdapter objAdapter;
        
        private static void OpenConnection()
        {
            try {
                if (objConnection == null)
                {
                    objConnection = new SqlConnection(ConnectionString);
                    objConnection.Open();
                }
                else if (objConnection.State != System.Data.ConnectionState.Open)
                 { 
                    objConnection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=MyPOS;Integrated Security=True");
                    objConnection.Open();
                }
                
            }
            
            
            
            catch { }

        }

        private static void CloseConnection()
        {
            try
            {
                if (!(objConnection==null))
                {
                    if (objConnection.State == System.Data.ConnectionState.Open)
                    {
                        objConnection.Close();
                        objConnection.Dispose();
                    }
                }
            }

            catch { 
            
            
            
            }
        }

        public static DataTable FillDataTable(string query, DataTable table) { 
        try
            {
                OpenConnection();
                objAdapter = new SqlDataAdapter(query, objConnection);
                objAdapter.Fill(table);
                objAdapter.Dispose();
                CloseConnection();
                return table;
            }
            catch
            {

                return null;
            }
        
        
        }
        public static bool ExecuteInsertQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static SqlDataReader ExecuteReader(string cmd)
        {
            try
            {
                SqlDataReader objReader;
                objConnection = new SqlConnection(ConnectionString);
                OpenConnection();
                SqlCommand command = new SqlCommand(cmd, objConnection);
                objReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                command.Dispose();
                return objReader;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
