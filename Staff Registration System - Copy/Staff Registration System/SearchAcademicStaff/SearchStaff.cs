using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Registration_System.SearchAcademicStaff
{
    class SearchStaff
    {
        Connection conn = new Connection();


        public void fillSearchTable(DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff ; ", conn.connConnection());
               // cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchByName(String txtSearchName, DataGridView tblSearch)
        {

            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff where [Full Name] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void searchByNIC(String txtSearchNIC, DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff where [NIC No] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtSearchNIC);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchByUPF(String txtSearchUPF, DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff where [UPF No] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtSearchUPF);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchByPassport(String txtPassportNo, DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff where [Passport No] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtPassportNo);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterByDepartment() { }

        public void filterByFaculty() { }

        public void filterByAppointmentDate() { }
    }
}
