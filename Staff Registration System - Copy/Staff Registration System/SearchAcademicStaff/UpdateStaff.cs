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
            //try
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

                //dataAdapter = new SqlDataAdapter(cmd);

                //table = new DataTable();
                //dataAdapter.Fill(table);

                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();


                for (int i = 1; reader1.Read(); i++)
                {
                   // DataRow row = tblChildren.;
                    //row["column2"] = "column2";
                    //row["column6"] = "column6";
                   // tblChildren.Rows.Add(row);


                    //DataGridViewRow row1 = (DataGridViewRow)tblChildren.Rows[0].Clone();
                    //row1.Cells[0].Value = "XYZ";
                    //row1.Cells[1].Value = 50.2;
                    //tblChildren.Rows.Add(row1);


                    //MessageBox.Show(reader1["Name"].ToString());
                    //MessageBox.Show(reader1["DOB"].ToString());
                    //MessageBox.Show(reader1["Birth Certificate No"].ToString());
                   // tblChildren.Rows[1].Cells[0].Value = reader1["Name"].ToString();
                   // tblChildren.Rows[1].Cells[1].Value = reader1["DOB"].ToString();
                   // tblChildren.Rows[1].Cells[2].Value = reader1["Birth Certificate No"].ToString();

                }
                // var commandBuilder = new SqlCommandBuilder(dataAdapter);
                // var ds = new DataSet();
                // dataAdapter.Fill(ds);
                //tblChildren.ReadOnly = true;
                //tblChildren.DataSource = ds.Tables[0];


                // tblChildren.Columns.Clear();
                //tblChildren.ColumnCount = 3;
                //tblChildren.AutoGenerateColumns = false;
                //tblChildren.DataSource = table;
               // for (int i = 0; i < table.Rows.Count; i++)
                {
                   // MessageBox.Show(table.Rows.Count.ToString());
                   // tblChildren.Rows[i].Cells[0].Value = table.Rows[0][1].ToString();
                   // tblChildren.Rows[i].Cells[1].Value = table.Rows[0][2].ToString();
                    //tblChildren.Rows[i].Cells[2].Value = table.Rows[0][3].ToString();
                    
                }
                //tblChildren.Columns[0].Visible = false;
                //tblChildren.Columns[1].Visible = false;
                //tblChildren.Columns[2].Visible = false;
                //tblChildren.Columns[0].hee = table.Columns[1];

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
           // catch (Exception ex)
            {
           //     MessageBox.Show(ex.Message);
            }
        }



        public void updateAcademicStaff(String ASID,String title, String txtFullName, String txtInitials, String dateDob, String gender, String txtTelePrivate, String txtTeleOffice, String txtEmailPrivate, String txtEmailOffice,
            String txtNIC, String txtPassport, String cmbBxDesignation, String cmbBxFaculty, String cmbBxDepartment, String txtUPF, String dateAppointment, String dateRetirement, String txtMarriageCertificate, String txtServiceNo,
            String personalPicLoc, String marriageCertificateLoc, String cmbBxSalaryStep, String dateIncrement)
        {
            try
            {



                byte[] marriageImg = null;
                byte[] personalImg = null;

                if (personalPicLoc != null)
                {

                    FileStream personalFs = new FileStream(personalPicLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader personalBr = new BinaryReader(personalFs);
                    personalImg = personalBr.ReadBytes((int)personalFs.Length);
                }

                if (marriageCertificateLoc != null)
                {

                    FileStream marriageFs = new FileStream(marriageCertificateLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader marriageBr = new BinaryReader(marriageFs);
                    marriageImg = marriageBr.ReadBytes((int)marriageFs.Length);
                }

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();
                if (marriageImg == null && personalImg != null)
                {
                    cmd = new SqlCommand("update AcademicStaff set ([Title] = @2,[Full Name] = @3,[Name with Initials] = @4,[DOB]=@5 ,[Gender]=@6,[Private Contact No]=@7 ,[Office Contact No]=@8 ,[Private Email]=@9,[Office Email]=@10,[NIC No]=@11,[Passport No]=@12,[UPF No]=@13,[Appointment Date]=@14 ,[Retirement Date]=@15 ,[Marriage Certificate No]=@16 ,[Person Pic]=@18,[Type]=@19 ,[ServiceNo]=@20 ,[Department Name]=@21 ,[Designation]=@22,[Salary Step]=@23,[Increment Date]=@24) where [ASID] = @25;", conn.connConnection());
                    cmd.Parameters.AddWithValue("@18", personalImg);


                }
                else if (personalImg == null && marriageImg != null)
                {
                    cmd = new SqlCommand("update AcademicStaff set  ([Title]=@2,[Full Name]=@3,[Name with Initials]=@4,[DOB]=@5 ,[Gender]=@6,[Private Contact No]=@7 ,[Office Contact No]=@8,[Private Email]=@9,[Office Email]=@10,[NIC No]=@11,[Passport No]=@12,[UPF No]=@13,[Appointment Date]=@14 ,[Retirement Date]=@15 ,[Marriage Certificate No]=@16 ,[Marriage Certificate Pic]=@17,[Type]=@19,[ServiceNo]=@20 ,[Department Name]=@21,[Designation]=@22,[Salary Step]=@23,[Increment Date]=@24) where [ASID] = @25;", conn.connConnection());
                    cmd.Parameters.AddWithValue("@17", marriageImg);


                }
                else if (marriageImg == null && personalImg == null)
                {
                    MessageBox.Show("test");
                    cmd = new SqlCommand("update AcademicStaff set [Title]=@2,[Full Name]=@3,[Name with Initials]=@4,[DOB]=@5,[Gender]=@6,[Private Contact No]=@7,[Office Contact No]=@8,[Private Email]=@9,[Office Email]=@10,[NIC No]=@11 ,[Passport No]=@12 ,[UPF No]=@13,[Appointment Date]=@14,[Retirement Date]=@15 ,[Marriage Certificate No]=@16 ,[Type]=@19,[ServiceNo]=@20 ,[Department Name]=@21,[Designation]=@22,[Salary Step]=@23,[Increment Date]=@24 where [ASID] = @25;", conn.connConnection());



                }
                else
                {
                    cmd = new SqlCommand("update AcademicStaff set  [Title]=@2,[Full Name]=@3,[Name with Initials]=@4,[DOB]=@5,[Gender]=@6,[Private Contact No]=@7,[Office Contact No]=@8,[Private Email]=@9,[Office Email]=@10,[NIC No]=@11,[Passport No]=@12,[UPF No]=@13,[Appointment Date]=@14,[Retirement Date]=@15,[Marriage Certificate No]=@16,[Marriage Certificate Pic]=@17,[Person Pic]=@18,[Type]=@19,[ServiceNo]=@20,[Department Name]=@21,[Designation]=@22,[Salary Step]=@23,[Increment Date]=@24 where [ASID] = @25;", conn.connConnection());
                    cmd.Parameters.AddWithValue("@17", marriageImg);
                    cmd.Parameters.AddWithValue("@18", personalImg);



                }

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


                cmd.Parameters.AddWithValue("@19", "Permanent");
                cmd.Parameters.AddWithValue("@20", txtServiceNo);
                cmd.Parameters.AddWithValue("@21", cmbBxDepartment);
                cmd.Parameters.AddWithValue("@22", cmbBxDesignation);
                cmd.Parameters.AddWithValue("@23", cmbBxSalaryStep);
                cmd.Parameters.AddWithValue("@24", dateIncrement);
                cmd.Parameters.AddWithValue("@25", ASID);

                cmd.ExecuteNonQuery();


               // cmd = new SqlCommand("SELECT ASID FROM AcademicStaff where [NIC No] = @1; ", conn.connConnection());
               // cmd.Parameters.AddWithValue("@1", txtNIC);

              //  SqlDataReader read = cmd.ExecuteReader();

               // while (read.Read())
               // {
                //    primaryKey = read[0].ToString();

               // }
              //  read.Close();


                conn.closeConnection();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void updateChildrenDetail( String ASID,DataGridView tblChildren)
        {
            try
            {
                int childrenCount = tblChildren.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("DELETE FROM [ChildrenDetail] WHERE [ASID] = @1)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < childrenCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new SqlCommand("insert into ChildrenDetail values(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", ASID);
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

        public void updateQulifications(DataGridView tblEducation)
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
                    //cmd.Parameters.AddWithValue("@1", primaryKey);
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

        public void updateOtherPositions(DataGridView tblOtherPositions)
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
                   // cmd.Parameters.AddWithValue("@1", primaryKey);
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

        public void updateServiceRecords(DataGridView tblService)
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
                    //cmd.Parameters.AddWithValue("@1", primaryKey);
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

        public void updateAddress(String txtAddress1Mail, String txtCityMail, String txtMailZipCode, String txtAddress1Home, String txtCityHome, String txtHomeZipCode)
        {
            conn.connOpen();
            conn.connConnection();
            SqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = new SqlCommand("insert into Address values (@1,@2,@3,@4,@5,@6,@7);", conn.connConnection());


            //cmd.Parameters.AddWithValue("@1", primaryKey);
            cmd.Parameters.AddWithValue("@2", txtAddress1Mail);
            cmd.Parameters.AddWithValue("@3", txtCityMail);
            cmd.Parameters.AddWithValue("@4", txtMailZipCode);
            cmd.Parameters.AddWithValue("@5", txtAddress1Home);
            cmd.Parameters.AddWithValue("@6", txtCityHome);
            cmd.Parameters.AddWithValue("@7", txtHomeZipCode);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
        }


    }
}
