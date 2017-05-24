using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Registration_System
{
    class Connection
    {
        SqlConnection conn = new SqlConnection();

        public Connection()
        {
            conn.ConnectionString = @"Data Source = DESKTOPCHARI\SQLEXPRESS; Initial Catalog = AcadamicStaff; Integrated Security = True";

            try
            {
                conn.Open();
                Console.WriteLine("State: {0}", conn.State);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public SqlConnection connConnection()
        {
            return conn;
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }




    }
}
