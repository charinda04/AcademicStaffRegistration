using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Registration_System.SearchAcademicStaff
{
    class DeleteStaff
    {
        Connection conn = new Connection();


        public void deleteAcademicStaff(String ASID)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();

                cmd = new SqlCommand("DELETE FROM [AcademicStaff] WHERE [ASID] = @1 ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
