using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Registration_System.SearchAcademicStaff
{
    class UpdateStaff
    {

        Connection conn = new Connection();

        public void fillForm(String ASID,ref RadioButton Mr, ref RadioButton Mrs, ref RadioButton Miss,ref TextBox txtFullName,ref TextBox txtInitials,ref DateTimePicker dateDob,ref RadioButton male,ref RadioButton female,ref TextBox txtTelePrivate,ref TextBox txtTeleOffice, ref TextBox txtEmailPrivate,ref TextBox txtEmailOffice,
            ref MaskedTextBox txtNIC,ref TextBox txtPassport,ref  ComboBox cmbBxDesignation,ref ComboBox cmbBxFaculty, ref ComboBox cmbBxDepartment, ref TextBox txtUPF,ref  DateTimePicker dateAppointment,ref  DateTimePicker dateRetirement,ref TextBox txtMarriageCertificate, ref TextBox txtServiceNo,
            ref PictureBox personalPicLoc, ref PictureBox marriageCertificateLoc, ref ComboBox cmbBxSalaryStep, ref DateTimePicker dateIncrement, ref TextBox txtAddress1Mail, ref TextBox txtCityMail, ref TextBox txtMailZipCode, ref TextBox txtAddress1Home,  ref TextBox txtCityHome, ref TextBox txtHomeZipCode,
            DataGridView tblChildren, DataGridView tblEducation, DataGridView tblOtherPositions, DataGridView tblService)
        {
            try
            {
                
                string selectSQL = "SELECT * FROM AcademicStaff where [ASID] = @1;";
                

                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = new SqlCommand(selectSQL, conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                SqlDataReader reader;


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    

                    Mr.Checked = reader["Title"].ToString() == "Mr";
                    Mrs.Checked = reader["Title"].ToString() == "Mrs";
                    Miss.Checked = reader["Title"].ToString() == "Miss";

                    txtFullName.Text = reader["Full Name"].ToString() ;
                    txtInitials.Text = reader["Name with Initials"].ToString();
                    dateDob.Text = reader["DOB"].ToString();

                    

                    male.Checked = reader["Gender"].ToString() == "Male";
                    female.Checked = reader["Gender"].ToString() == "Female";

                    txtTelePrivate.Text = reader["Private Contact No"].ToString();
                    txtTeleOffice.Text = reader["Office Contact No"].ToString();
                    txtEmailPrivate.Text = reader["Private Email"].ToString();
                    txtEmailOffice.Text = reader["Office Email"].ToString();
                    txtNIC.Text = reader["NIC No"].ToString();
                    txtPassport.Text = reader["Passport No"].ToString();
                    txtUPF.Text = reader["UPF No"].ToString();
                    dateAppointment.Text = reader["Appointment Date"].ToString();
                    dateRetirement.Text = reader["Retirement Date"].ToString();
                    txtMarriageCertificate.Text = reader["Marriage Certificate No"].ToString();
                    // mpic 


                    if (DBNull.Value.Equals(reader.GetValue(17)))
                    {
                        personalPicLoc.Image = null;
                        
                    }

                    else
                    {
                        
                        byte[] img = (byte[])reader.GetValue(17);
                        MemoryStream ms = new MemoryStream(img);
                        personalPicLoc.Image = Image.FromStream(ms);

                    }
                    // ppic
                    // type
                    txtServiceNo.Text = reader["ServiceNo"].ToString();
                    cmbBxDepartment.Text = reader["Department Name"].ToString();

                    cmbBxDesignation.Text = reader["Designation"].ToString();
                    cmbBxSalaryStep.Text = reader["Salary Step"].ToString();
                    dateIncrement.Text = reader["Increment Date"].ToString();






                    MessageBox.Show("good");


                }
                reader.Close();


                conn.connOpen();
                conn.connConnection();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM ServiceRecords where [ASID] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblService.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

                conn.connOpen();
                conn.connConnection();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM OtherPositions where [ASID] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);

                dataAdapter = new SqlDataAdapter(cmd);

                table = new DataTable();
                dataAdapter.Fill(table);

                tblOtherPositions.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

                conn.connOpen();
                conn.connConnection();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM EducationalQulifications where [ASID] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);

                dataAdapter = new SqlDataAdapter(cmd);

                table = new DataTable();
                dataAdapter.Fill(table);

                tblEducation.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

                conn.connOpen();
                conn.connConnection();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM ChildrenDetail where [ASID] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);

                dataAdapter = new SqlDataAdapter(cmd);

                table = new DataTable();
                dataAdapter.Fill(table);

                tblChildren.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

                conn.connOpen();
                conn.connConnection();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM Address where [ASID] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtAddress1Mail.Text = reader["Maling Address"].ToString();
                    txtCityMail.Text = reader["Maling City"].ToString();
                    txtMailZipCode.Text = reader["Maling ZipCode"].ToString();
                    txtAddress1Home.Text = reader["Home Address"].ToString();
                    txtCityHome.Text = reader["Home City"].ToString();
                    txtHomeZipCode.Text = reader["Home ZipCode"].ToString();
                }
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
