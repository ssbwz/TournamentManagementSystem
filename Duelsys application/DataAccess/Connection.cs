using MySql.Data.MySqlClient;
using DataAccess.ExceptionModels;
using System.Diagnostics;

namespace DataAccess
{
    public class Connection
    {
        private static MySqlConnection? conn;

        internal static MySqlConnection Connect
        {
            get
            {
                try
                {
                    if (conn == null)
                    {
                        conn = new MySqlConnection("Enter your server link");
                        conn.Open();
                    }
                    return conn;
                }
                catch (MySqlException ex) 
                {
                    Debug.WriteLine(ex.Message);
                    CloseConnection();
                    throw new UnableToConnectToHostException("Unable to connect to a host", ex);
                }
            }
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
            conn = null;
        }
    }
}
