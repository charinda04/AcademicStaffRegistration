using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Registration_System.Options
{
    class OptionsPanel
    {
        Connection conn = new Connection();

        public void loadSalaryCode(DataGridView tblOldCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM [SalaryCode]; ", conn.connConnection());
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                tblOldCode.DataSource = table;
                tblOldCode.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadSalaryScale(DataGridView tblOldScale, String salaryCode,ref Boolean tblOldScalePopulated)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT [Salary Scale] FROM [SalaryScale] WHERE [Salary Code] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryCode);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);

                table = new DataTable();
                dataAdapter.Fill(table);

                tblOldScale.DataSource = table;
                tblOldScale.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (tblOldScale.Rows.Count > 0)
                    tblOldScalePopulated = true;
                else
                    tblOldScalePopulated = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadSalaryStep(DataGridView tblOldStep,String salaryScale)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT [Salary Step] FROM [SalaryStep] WHERE [Salary Scale] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryScale);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);

                table = new DataTable();
                dataAdapter.Fill(table);

                tblOldStep.DataSource = table;
                tblOldStep.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDesignation(DataGridView tblDesignation)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT [Designation] FROM [Designations];", conn.connConnection());


                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblDesignation.DataSource = table;
                tblDesignation.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadFaculty(DataGridView tblFaculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM [Faculty]; ", conn.connConnection());


                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblFaculty.DataSource = table;
                tblFaculty.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDepartment(DataGridView tblDepartment, String faculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT [Department Name] FROM [Department] WHERE [Faculty Name] = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", faculty);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblDepartment.DataSource = table;
                tblDepartment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertFaculty(String txtNewFaculty)
        {
            try
            {                
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();
                  
                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("INSERT INTO [Faculty] VALUES (@1)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewFaculty);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New faculty successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This faculty name already exsits. Please enter a different faculty name");
                //MessageBox.Show(ex.Message);
            }
        }

        public void insertDepartment(String txtNewDepartment,String Faculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("INSERT INTO [Department] VALUES (@1,@2)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewDepartment);
                cmd.Parameters.AddWithValue("@2", Faculty);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Department successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Department name already exsits. Please enter a different Department name");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertDesignation(String txtNewDesignation)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("INSERT INTO [Designations] ([Designation]) VALUES (@1);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewDesignation);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Designation successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Designation name already exsits. Please enter a different Designation name");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSalaryCode(String txtNewCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("INSERT INTO [SalaryCode] VALUES (@1);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewCode);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New SalaryCode successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This SalaryCode already exsits. Please enter a different SalaryCode");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSalaryScale(String txtNewScale, String salaryCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("INSERT INTO [SalaryScale] VALUES (@1,@2);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewScale);
                cmd.Parameters.AddWithValue("@2", salaryCode);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New SalaryScale successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This SalaryScale already exsits. Please enter a different SalaryScale");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSalaryStep(String txtNewStep, String salaryScale)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("INSERT INTO [SalaryStep] VALUES (@1,@2);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewStep);
                cmd.Parameters.AddWithValue("@2", salaryScale);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New SalaryStep successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This SalaryStep already exsits. Please enter a different SalaryStep");
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteFaculty(String txtFaculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("DELETE FROM [Faculty] WHERE [Faculty Name] = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtFaculty);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("faculty successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("This faculty name already exsits. Please enter a different faculty name");
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteDepartment(String txtDepartment)
        {
            try
            {

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("DELETE FROM [Department] WHERE [Department Name] = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtDepartment);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteDesignation(String txtDesignation)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("DELETE FROM [Designations] WHERE [Designation] = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtDesignation);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteSalaryCode(String salaryCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("DELETE FROM [SalaryCode] WHERE [Salary Code] = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryCode);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteSalaryScale(String salaryScale)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("DELETE FROM [SalaryScale] WHERE [Salary Scale] = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryScale);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteSalaryStep(String salaryStep)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("DELETE FROM [SalaryStep] WHERE [Salary Step] = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryStep);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
