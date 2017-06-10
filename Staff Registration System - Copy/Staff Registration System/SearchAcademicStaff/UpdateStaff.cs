using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            ref PictureBox personalPicLoc, ref PictureBox marriageCertificateLoc, ref ComboBox cmbBxSalaryStep, ref DateTimePicker dateIncrement)
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
                    if ((reader["Title"]).ToString() == "Mr")
                        Mr.Checked = true;
                    else if ((reader["Title"]).ToString() == "Mrs")
                        Mrs.Checked = true;
                    else if ((reader["Title"]).ToString() == "Miss")
                        Miss.Checked = true;

                    txtFullName.Text = reader["Full Name"].ToString() ;
                    txtInitials.Text = reader["Name with Initials"].ToString();
                    dateDob.Text = reader["DOB"].ToString();

                    if ((reader["Gender"]).ToString() == "Male")
                        male.Checked = true;
                    else if ((reader["Gender"]).ToString() == "Female")
                        female.Checked = true;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
