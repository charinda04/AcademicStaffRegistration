using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Registration_System.AddAcademicStaff
{
    class AddStaff
    {
        Connection conn = new Connection();
        private String primaryKey = null;

        public void saveAcademicStaff(String title, String txtFullName, String txtInitials, String dateDob, String gender, String txtTelePrivate, String txtTeleOffice, String txtEmailPrivate, String txtEmailOffice,
            String txtNIC, String txtPassport, String cmbBxDesignation, String cmbBxFaculty, String cmbBxDepartment, String txtUPF, String dateAppointment, String dateRetirement, String txtMarriageCertificate, String txtServiceNo,
            String personalPicLoc, String marriageCertificateLoc, String cmbBxSalaryStep, String dateIncrement)
        {
            try
            {





                byte[] personalImg = null;
                FileStream personalFs = new FileStream(personalPicLoc, FileMode.Open, FileAccess.Read);
                BinaryReader personalBr = new BinaryReader(personalFs);
                personalImg = personalBr.ReadBytes((int)personalFs.Length);

                byte[] marriageImg = null;
                FileStream marriageFs = new FileStream(marriageCertificateLoc, FileMode.Open, FileAccess.Read);
                BinaryReader marriageBr = new BinaryReader(marriageFs);
                marriageImg = marriageBr.ReadBytes((int)marriageFs.Length);

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("insert into AcademicStaff values (@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24);", conn.connConnection());


                cmd.Parameters.AddWithValue("@2", title);
                cmd.Parameters.AddWithValue("@3", txtFullName);
                cmd.Parameters.AddWithValue("@4", txtInitials);
                cmd.Parameters.AddWithValue("@5", dateDob);
                cmd.Parameters.AddWithValue("@6", gender);
                cmd.Parameters.AddWithValue("@7", txtTelePrivate);
                cmd.Parameters.AddWithValue("@8", txtTeleOffice);
                cmd.Parameters.AddWithValue("@9", txtEmailPrivate);
                cmd.Parameters.AddWithValue("@10", txtEmailOffice);
                cmd.Parameters.AddWithValue("@11", txtNIC);
                cmd.Parameters.AddWithValue("@12", txtPassport);
                cmd.Parameters.AddWithValue("@13", txtUPF);
                cmd.Parameters.AddWithValue("@14", dateAppointment);
                cmd.Parameters.AddWithValue("@15", dateRetirement);
                cmd.Parameters.AddWithValue("@16", txtMarriageCertificate);
                cmd.Parameters.AddWithValue("@17", marriageImg);
                cmd.Parameters.AddWithValue("@18", personalImg);
                cmd.Parameters.AddWithValue("@19", "Permanent");
                cmd.Parameters.AddWithValue("@20", txtServiceNo);
                cmd.Parameters.AddWithValue("@21", cmbBxDepartment);
                cmd.Parameters.AddWithValue("@22", cmbBxDesignation);
                cmd.Parameters.AddWithValue("@23", cmbBxSalaryStep);
                cmd.Parameters.AddWithValue("@24", dateIncrement);




                cmd.ExecuteNonQuery();


                cmd = new SqlCommand("SELECT PDID FROM AcademicStaff where [NIC No] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNIC);

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    primaryKey = read[0].ToString();

                }
                read.Close();


                conn.closeConnection();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addChildrenDetail(DataGridView tblChildren)
        {
            try
            {
                int childrenCount = tblChildren.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < childrenCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new SqlCommand("insert into ChildrenDetail values(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblChildren.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblChildren.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblChildren.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addQulifications(DataGridView tblEducation)
        {
            try
            {

                int educationCount = tblEducation.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < educationCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new SqlCommand("insert into EducationalQulifications values(@1, @2, @3,@4,@5)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblEducation.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblEducation.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblEducation.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@5", tblEducation.Rows[i].Cells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addOtherPositions(DataGridView tblOtherPositions)
        {
            try
            {

                int otherPositionsCount = tblOtherPositions.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < otherPositionsCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new SqlCommand("insert into OtherPositions values(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblOtherPositions.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblOtherPositions.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblOtherPositions.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addServiceRecords(DataGridView tblService)
        {
            try
            {
                int serviceCount = tblService.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < serviceCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new SqlCommand("insert into ServiceRecords values(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblService.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblService.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblService.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addAddress() { }


        public void facultyComboBox(ComboBox cmbBxFaculty)
        {
            try
            {
                cmbBxFaculty.Items.Clear();
                string selectSQL = "SELECT [Faculty Name] FROM [Faculty];";

                conn.connOpen();
                conn.connConnection();

                SqlCommand comm = new SqlCommand(selectSQL, conn.connConnection());
                SqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxFaculty.Items.Add(reader["Faculty Name"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void departmentComboBox(ComboBox cmbBxDepartment)
        {
            try
            {
                cmbBxDepartment.Items.Clear();
                string selectSQL = "SELECT [Department Name] FROM [Department];";

                conn.connOpen();
                conn.connConnection();

                SqlCommand comm = new SqlCommand(selectSQL, conn.connConnection());
                SqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxDepartment.Items.Add(reader["Department Name"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void designationComboBox(ComboBox cmbBxDesignation)
        {
            try
            {
                cmbBxDesignation.Items.Clear();
                string selectSQL = "SELECT [Designation] FROM [Designations];";

                conn.connOpen();
                conn.connConnection();

                SqlCommand comm = new SqlCommand(selectSQL, conn.connConnection());
                SqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {

                    cmbBxDesignation.Items.Add(reader["Designation"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salaryCodeComboBox(ComboBox cmbBxSalaryCode)
        {
            try
            {
                cmbBxSalaryCode.Items.Clear();
                string selectSQL = "SELECT [Salary Code] FROM [SalaryCode];";

                conn.connOpen();
                conn.connConnection();

                SqlCommand comm = new SqlCommand(selectSQL, conn.connConnection());
                SqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxSalaryCode.Items.Add(reader["Salary Code"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salaryScaleComboBox(ComboBox cmbBxSalaryScale)
        {
            try
            {
                cmbBxSalaryScale.Items.Clear();
                string selectSQL = "SELECT [Salary Scale] FROM [SalaryScale];";

                conn.connOpen();
                conn.connConnection();

                SqlCommand comm = new SqlCommand(selectSQL, conn.connConnection());
                SqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxSalaryScale.Items.Add(reader["Salary Scale"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salaryStepComboBox(ComboBox cmbBxSalaryStep)
        {
            try
            {
                cmbBxSalaryStep.Items.Clear();
                string selectSQL = "SELECT [Salary Step] FROM [SalaryStep];";

                conn.connOpen();
                conn.connConnection();

                SqlCommand comm = new SqlCommand(selectSQL, conn.connConnection());
                SqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxSalaryStep.Items.Add(reader["Salary Step"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
