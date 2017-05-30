using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Staff_Registration_System
{
    public partial class home : Form
    {

        SqlConnection conn;
        SqlCommand comm;
        //conn.ConnectionString = @"User=DESKTOPCHARI\Charinda;Password=;Server=DESKTOPCHARI\SQLEXPRESS;Database=AcadamicStaff; Integrated Security=True";


        public home()
        {
            InitializeComponent();
            //Connection c = new Connection();
            //conn = c.connConnection();
            conn = new SqlConnection(ConnectionString);
            comm = new SqlCommand();
            comm.Connection = conn;
        }

        String ConnectionString = @"Data Source=DESKTOPCHARI\SQLEXPRESS;Initial Catalog=AcadamicStaff;Integrated Security=True";
        String personalPicLoc;
        String marriageCertificateLoc;
        Boolean PersonalPic = false;
        Boolean certificatePic = false;
        
       

        

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
        {
            dateEffective.CustomFormat = "yyyy-MM-dd";
            dateDob.CustomFormat = "yyyy-MM-dd";
            dateAppointment.CustomFormat = "yyyy-MM-dd";
            dateRetirement.CustomFormat = "yyyy-MM-dd";
            dateIncrement.CustomFormat = "yyyy-MM-dd";
            dateChildDob.CustomFormat = "yyyy-MM-dd";
            dateOtherPositionFrom.CustomFormat = "yyyy-MM-dd";
            dateOtherPosistionTo.CustomFormat = "yyyy-MM-dd";
            dateServiceFrom.CustomFormat = "yyyy-MM-dd";
            dateServiceTo.CustomFormat = "yyyy-MM-dd";
        }

       int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void presonal_detail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            picbtnAddMember.BackColor = Color.LightSeaGreen;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            picbtnAddMember.BackColor = Color.Teal;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            picbtnSearchMember.BackColor = Color.LightSeaGreen;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            picbtnSearchMember.BackColor = Color.Teal;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            picbtnReports.BackColor = Color.LightSeaGreen;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            picbtnReports.BackColor = Color.Teal;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            picbtnAlerts.BackColor = Color.LightSeaGreen;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            picbtnAlerts.BackColor = Color.Teal;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            picbtnOptions.BackColor = Color.LightSeaGreen;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            picbtnOptions.BackColor = Color.Teal;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            alerts.Visible = true;
            alerts.BringToFront();

            //Make button bar visible
            picbarAddMember.Visible = false;
            picbarSearchMember.Visible = false;
            picbarReports.Visible = false;
            picbarAlerts.Visible = true;
            picbarOptions.Visible = false;
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            lblNextPdetail1_dark.Visible = false;
            lblNextPdetail1_light.Visible = true;
        }

        private void label59_MouseLeave(object sender, EventArgs e)
        {
            lblNextPdetail1_dark.Visible = true;
            lblNextPdetail1_light.Visible = false;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            picbtnClose.BackColor = Color.Red;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            picbtnClose.BackColor = Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            lblPrevPdetail2_light.Visible = true;
            lblPrevPdetail2_dark.Visible = false;
        }

        private void label67_MouseLeave(object sender, EventArgs e)
        {
            lblPrevPdetail2_light.Visible = false;
            lblPrevPdetail2_dark.Visible = true;
        }

        private void label42_MouseEnter(object sender, EventArgs e)
        {
            lblNextPdetail2_light.Visible = true;
            lblNextPdetail2_dark.Visible = false;
        }

        private void label66_MouseLeave(object sender, EventArgs e)
        {
            lblNextPdetail2_light.Visible = false;
            lblNextPdetail2_dark.Visible = true;
        }

        private void label60_MouseEnter(object sender, EventArgs e)
        {
        }

        private void label69_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void personal_detail1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNextPdetail1_light_Click(object sender, EventArgs e)
        {
           /* if (!rdoBtnMr.Checked && !rdoBtnMrs.Checked && !rdoBtnMiss.Checked)
            {
                MessageBox.Show("Please select a title");
            }
            else if (!rdoBtnMale.Checked && !rdoBtnFemale.Checked)
            {
                MessageBox.Show("Please select a gender");
            }
            else if (txtFullName.Text.Length == 0 || txtInitials.Text.Length == 0)
            {
                MessageBox.Show("Please fill the name fileds");
            }
            else if (txtNIC.Text.Length == 0 || txtPassport.Text.Length == 0)
            {
                MessageBox.Show("Please fill the Nic and passport fields");
            }
            else if (txtEmailOffice.Text.Length == 0 && txtEmailPrivate.Text.Length == 0)
            {
                MessageBox.Show("Please fill atleast one email adress");
            }
            else if (txtTeleOffice.Text.Length == 0 && txtTelePrivate.Text.Length == 0)
            {
                MessageBox.Show("Please fill atleast one telephone No");
            }
            else if ((txtAddress1Mail.Text.Length == 0 && txtAddress2Mail.Text.Length == 0) || txtCityMail.Text.Length == 0 || txtMailZipCode.Text.Length == 0)
            {
                MessageBox.Show("Please fill the mailing address");
            }
            else if (!chkBxSame.Checked && (txtAddress1Home.Text.Length == 0 || txtAddress2Home.Text.Length == 0 || txtCityHome.Text.Length == 0 || txtHomeZipCode.Text.Length == 0))
            {
                DialogResult answer;
                answer = MessageBox.Show("Is mailing address is your home address?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    chkBxSame.Checked = true;
            }*/
            //else
            {
                personal_detail2.Visible = true;
                personal_detail2.BringToFront();
            }

            
            //progressBar1.Value = 50;
            //progressBar1.BringToFront();
            //personal_detail2.Show();
        }

        private void lblPrevPdetail2_light_Click(object sender, EventArgs e)
        {
            personal_detail1.Visible = true;
            personal_detail1.BringToFront();
        }

        private void lblNextPdetail2_light_Click(object sender, EventArgs e)
        {
            /*if (cmbBxDesignation.Text.Length == 0 || cmbBxFaculty.Text.Length==0 || cmbBxDepartment.Text.Length == 0 || txtUPF.Text.Length == 0 || txtServiceNo.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the work information");
            }
            else if (cmbBxSalaryCode.Text.Length == 0 || cmbBxSalaryStep.Text.Length == 0 || cmbBxScale.Text.Length == 0)
            {
                MessageBox.Show("Please fill salary information");
            }
           */
           // else
            {
                educational_qualifications.Visible = true;
                educational_qualifications.BringToFront();
            }
        }

        private void lblPrevPdetail2_dark_Click(object sender, EventArgs e)
        {

        }

        private void lblPrevEduQualif_dark_MouseEnter(object sender, EventArgs e)
        {
            lblPrevEduQualif_dark.Visible = false;
            lblPrevEduQualif_light.Visible = true;
        }

        private void lblPrevEduQualif_light_MouseLeave(object sender, EventArgs e)
        {
            lblPrevEduQualif_dark.Visible = true;
            lblPrevEduQualif_light.Visible = false;
        }

        private void lblNextEduQualif_dark_MouseEnter(object sender, EventArgs e)
        {
            lblNextEduQualif_dark.Visible = false;
            lblNextEduQualif_light.Visible = true;
        }

        private void lblNextEduQualif_light_MouseLeave(object sender, EventArgs e)
        {
            lblNextEduQualif_dark.Visible = true;
            lblNextEduQualif_light.Visible = false;
        }

        private void lblPrevEduQualif_light_Click(object sender, EventArgs e)
        {
            personal_detail2.Visible = true;
            personal_detail2.BringToFront();
        }

        private void lblNextEduQualif_light_Click(object sender, EventArgs e)
        {
            other_positions.Visible = true;
            other_positions.BringToFront();
        }

        private void lblPrevOtherPostns_dark_MouseEnter(object sender, EventArgs e)
        {
            lblPrevOtherPostns_dark.Visible = false;
            lblPrevOtherPostns_light.Visible = true;
        }

        private void lblPrevOtherPostns_light_MouseLeave(object sender, EventArgs e)
        {
            lblPrevOtherPostns_dark.Visible = true;
            lblPrevOtherPostns_light.Visible = false;
        }

        private void lblPrevOtherPostns_light_Click(object sender, EventArgs e)
        {
            educational_qualifications.Visible = true;
            educational_qualifications.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            search.Visible = true;
            search.BringToFront();

            //Make button bar visible
            picbarAddMember.Visible = false;
            picbarSearchMember.Visible = true;
            picbarReports.Visible = false;
            picbarAlerts.Visible = false;
            picbarOptions.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personal_detail1.Visible = true;
            personal_detail1.BringToFront();

            //Make button bar visible
            picbarAddMember.Visible = true;
            picbarSearchMember.Visible = false;
            picbarReports.Visible = false;
            picbarAlerts.Visible = false;
            picbarOptions.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            reports.Visible = true;
            reports.BringToFront();

            //Make button bar visible
            picbarAddMember.Visible = false;
            picbarSearchMember.Visible = false;
            picbarReports.Visible = true;
            picbarAlerts.Visible = false;
            picbarOptions.Visible = false;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            picbtnMinimize.BackColor = Color.LightGray;
        }

        private void picbtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            picbtnMinimize.BackColor = Color.White;
        }

        private void picbtnOptions_Click(object sender, EventArgs e)
        {

            settings.Visible = true;
            settings.BringToFront();

           
            //Make button bar visible
            picbarAddMember.Visible = false;
            picbarSearchMember.Visible = false;
            picbarReports.Visible = false;
            picbarAlerts.Visible = false;
            picbarOptions.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);

            comm = new SqlCommand();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                String primaryKey = null;
                String title = null, gender = null;
                if (rdoBtnMr.Checked)
                    title = "Mr";
                else if (rdoBtnMrs.Checked)
                    title = "Mrs";
                else if (rdoBtnMiss.Checked)
                    title = "Miss";

                if (rdoBtnMale.Checked)
                    gender = "Male";
                else if (rdoBtnFemale.Checked)
                    gender = "Female";
                /*
               // conn = new SqlConnection(ConnectionString);
                //conn.Open();

                comm.Connection = conn;
                String q = "insert into PersonalDetail values (3,'zcsf','sfd','sf','sss','db','db','db',13,13,'gf','fg','sfd','2002-02-02','sf','sdf','sf','fsd','fsd','sfd','2002-02-02');";
                
                comm = new SqlCommand(q,conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("run");
                conn.Close();
                */
                if (true)
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(personalPicLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd = new SqlCommand("insert into PersonalDetail values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22);", conn);


                    cmd.Parameters.AddWithValue("@1", title);
                    cmd.Parameters.AddWithValue("@2", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@3", txtInitials.Text);
                    cmd.Parameters.AddWithValue("@4", dateDob.Text);
                    cmd.Parameters.AddWithValue("@5", gender);

                    cmd.Parameters.AddWithValue("@6", txtTelePrivate.Text);
                    cmd.Parameters.AddWithValue("@7", txtTeleOffice.Text);
                    cmd.Parameters.AddWithValue("@8", txtEmailPrivate.Text);
                    cmd.Parameters.AddWithValue("@9", txtEmailOffice.Text);
                    cmd.Parameters.AddWithValue("@10", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@11", txtPassport.Text);
                    cmd.Parameters.AddWithValue("@12", cmbBxDesignation.Text);
                    cmd.Parameters.AddWithValue("@13", cmbBxFaculty.Text);
                    cmd.Parameters.AddWithValue("@14", cmbBxDepartment.Text);
                    cmd.Parameters.AddWithValue("@15", txtUPF.Text);
                    cmd.Parameters.AddWithValue("@16", dateAppointment.Value);
                    cmd.Parameters.AddWithValue("@17", dateRetirement.Value);
                    cmd.Parameters.AddWithValue("@18", txtMarriageCertificate.Text);
                    cmd.Parameters.AddWithValue("@19", "1");
                    cmd.Parameters.AddWithValue("@20", img);
                    cmd.Parameters.AddWithValue("@21", "Permanent");
                    cmd.Parameters.AddWithValue("@22", txtServiceNo.Text);

                    /*
                    //cmd.Parameters.AddWithValue("@1", "1");
                    //cmd.Parameters.AddWithValue("@2", "1");
                    //cmd.Parameters.AddWithValue("@3", "1");
                    //cmd.Parameters.AddWithValue("@4", "2002-02-02");
                    //cmd.Parameters.AddWithValue("@5", "1");
                    cmd.Parameters.AddWithValue("@6", "1");
                    cmd.Parameters.AddWithValue("@7", "1");
                    cmd.Parameters.AddWithValue("@8", "1");
                    cmd.Parameters.AddWithValue("@9", "1");
                    cmd.Parameters.AddWithValue("@10", "1");
                    cmd.Parameters.AddWithValue("@11", "1");
                    cmd.Parameters.AddWithValue("@12", "1");
                    cmd.Parameters.AddWithValue("@13", "1");
                    cmd.Parameters.AddWithValue("@14", "1");
                    cmd.Parameters.AddWithValue("@15", "1");
                    cmd.Parameters.AddWithValue("@16", "2002-02-02");
                    cmd.Parameters.AddWithValue("@17", "2002-02-02");
                    cmd.Parameters.AddWithValue("@18", "1");
                    cmd.Parameters.AddWithValue("@19", "1");
                    cmd.Parameters.AddWithValue("@20", "1");
                    cmd.Parameters.AddWithValue("@21", "1");
                    cmd.Parameters.AddWithValue("@22", "1");
                    */
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();

                    cmd = new SqlCommand("SELECT PDID FROM PersonalDetail where [NIC No] = @1; ", conn);
                    cmd.Parameters.AddWithValue("@1", txtNIC.Text);

                    SqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        primaryKey = read[0].ToString();

                    }
                    read.Close();

                    int childrenCount = tblChildren.Rows.Count;
                    int serviceCount = tblService.Rows.Count;
                    int otherPositionsCount = tblOtherPositions.Rows.Count;
                    int educationCount = tblEducation.Rows.Count;

                   // for (int i = 0; i < childrenCount; i++) 
                        //MessageBox.Show(tblChildren.Rows[i].Cells[0].Value.ToString() + tblChildren.Rows[i].Cells[1].Value.ToString() + tblChildren.Rows[i].Cells[2].Value.ToString());
                    //MessageBox.Show(tblChildren.Rows[1].Cells.Count.ToString());

                    for (int i = 0; i < childrenCount; i++)
                    {
                        cmd = conn.CreateCommand();
                        cmd = new SqlCommand("insert into ChildrenDetail values(@1, @2, @3,@4)", conn);
                        cmd.Parameters.AddWithValue("@1", primaryKey);
                        cmd.Parameters.AddWithValue("@2", tblChildren.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@3", tblChildren.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@4", tblChildren.Rows[i].Cells[2].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < serviceCount; i++)
                    {
                        cmd = conn.CreateCommand();
                        cmd = new SqlCommand("insert into ServiceRecords values(@1, @2, @3,@4)", conn);
                        cmd.Parameters.AddWithValue("@1", primaryKey);
                        cmd.Parameters.AddWithValue("@2", tblService.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@3", tblService.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@4", tblService.Rows[i].Cells[2].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < otherPositionsCount; i++)
                    {
                        cmd = conn.CreateCommand();
                        cmd = new SqlCommand("insert into OtherPositions values(@1, @2, @3,@4)", conn);
                        cmd.Parameters.AddWithValue("@1", primaryKey);
                        cmd.Parameters.AddWithValue("@2", tblOtherPositions.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@3", tblOtherPositions.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@4", tblOtherPositions.Rows[i].Cells[2].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < educationCount; i++)
                    {
                        cmd = conn.CreateCommand();
                        cmd = new SqlCommand("insert into EducationalQulifications values(@1, @2, @3,@4,@5)", conn);
                        cmd.Parameters.AddWithValue("@1", primaryKey);
                        cmd.Parameters.AddWithValue("@2", tblEducation.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@3", tblEducation.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@4", tblEducation.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@5", tblEducation.Rows[i].Cells[3].Value.ToString());
                        cmd.ExecuteNonQuery();
                    }


                    conn.Close();
                   

                }
                /*
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "insert into PersonalDetail values ('','sfd','sf','sss','db','db','db',13,13,'gf','fg','sfd','2002-02-02','sf','sdf','sf','fsd','fsd','sfd','2002-02-02');";

                cmd = new SqlCommand("insert into ServiceRecords values(@1, @2, @3,@4)",conn);
                cmd.Parameters.AddWithValue("@1","1");
                cmd.Parameters.AddWithValue("@2", "dfdf");
                cmd.Parameters.AddWithValue("@3", "2002-02-02");
                cmd.Parameters.AddWithValue("@4", "2002-02-02");
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //cmd.Prepare();
                //SqlDataReader res = cmd.ExecuteReader();
                // insert into ServiceRecords values ('@1','@2','@3',@4);
                cmd.ExecuteNonQuery();
                conn.Close();

                */


                MessageBox.Show("record saved");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            finally
            {
                
            }

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (txtQulification.Text.Length == 0 || txtUniversity.Text.Length == 0 || txtGrade.Text.Length == 0)
            {
                MessageBox.Show("Fill all the fields first");
            }
            else
            {
                tblEducation.Rows.Add(txtQulification.Text, txtUniversity.Text, dateEffective.Text, txtGrade.Text);
                txtQulification.Text = "";
                txtUniversity.Text = "";
                dateEffective.Value = DateTime.Now;
                txtGrade.Text = "";
            }
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if(txtServicePosition.Text.Length == 0 )
            {
                MessageBox.Show("Fill all the fields first");
            }
            else
            {
                tblService.Rows.Add(txtServicePosition.Text, dateServiceFrom.Text, dateServiceTo.Text);
                txtServicePosition.Text = "";
                dateServiceFrom.Value = DateTime.Now;
                dateServiceTo.Value = DateTime.Now;
            }
            
        }

        private void btnRemoveEducation_Click(object sender, EventArgs e)
        {
            if (tblEducation.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblEducation.Rows.Remove(tblEducation.Rows[tblEducation.SelectedCells[0].RowIndex]);
            }


        }

        private void btnServiceRemove_Click(object sender, EventArgs e)
        {
            if (tblService.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblService.Rows.Remove(tblService.Rows[tblService.SelectedCells[0].RowIndex]);
            }
        }

        private void btnAddOtherPosition_Click(object sender, EventArgs e)
        {
            if (txtOtherPosition.Text.Length == 0)
            {
                MessageBox.Show("Fill all the fields first");
            }
            else
            {
                tblOtherPositions.Rows.Add(txtOtherPosition.Text, dateOtherPositionFrom.Text, dateOtherPosistionTo.Text);
                txtOtherPosition.Text = "";
                dateOtherPositionFrom.Value = DateTime.Now;
                dateOtherPosistionTo.Value = DateTime.Now;
            }
        }

        private void btnRemoveOtherPosition_Click(object sender, EventArgs e)
        {
            if (tblOtherPositions.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblOtherPositions.Rows.Remove(tblOtherPositions.Rows[tblOtherPositions.SelectedCells[0].RowIndex]);
            }
        }

        private void btnAddChildren_Click(object sender, EventArgs e)
        {
            if (txtChildName.Text.Length == 0 || txtChildBirthCertificate.Text.Length == 0 )
            {
                MessageBox.Show("Fill all the fields first");
            }
            else
            {
                tblChildren.Rows.Add(txtChildName.Text, dateChildDob.Text, txtChildBirthCertificate.Text);
                txtChildName.Text = "";
                txtChildBirthCertificate.Text = "";
                dateChildDob.Value = DateTime.Now;
                //MessageBox.Show(tblChildren.Rows.Count.ToString());
            }
        }

        private void btnRemoveChildren_Click(object sender, EventArgs e)
        {
            if (tblChildren.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblChildren.Rows.Remove(tblChildren.Rows[tblChildren.SelectedCells[0].RowIndex]);
            }
        }

        private void btnPersonalPic_Click(object sender, EventArgs e)
        {
            openFileDialogPersonalPic.FileName = "";
            if (openFileDialogPersonalPic.ShowDialog() == DialogResult.OK)
            {
                ptBxPersonalPic.Image = Image.FromFile(openFileDialogPersonalPic.FileName);
                personalPicLoc = openFileDialogPersonalPic.FileName.ToString();
            }
        }

        private void chkBxSame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSame.Checked)
            {
                txtAddress1Home.Enabled = false;
                txtAddress2Home.Enabled = false;
                txtCityHome.Enabled = false;
                txtHomeZipCode.Enabled = false;
            }
            else if (!chkBxSame.Checked)
            {
                txtAddress1Home.Enabled = true;
                txtAddress2Home.Enabled = true;
                txtCityHome.Enabled = true;
                txtHomeZipCode.Enabled = true;
            }
        }

        private void lblNextPdetail1_dark_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMarriageCertificate_Click(object sender, EventArgs e)
        {
            openFileDialogMarriageCertificate.FileName = "";
            if (openFileDialogMarriageCertificate.ShowDialog() == DialogResult.OK)
            {
                ptBxMarriageCertificate.Image = Image.FromFile(openFileDialogMarriageCertificate.FileName);
                marriageCertificateLoc = openFileDialogMarriageCertificate.FileName.ToString();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd = new SqlCommand("SELECT * FROM PersonalDetail where [First Name] = @1; ", conn);
                cmd.Parameters.AddWithValue("@1", txtSearchName.Text);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table; 

                /*SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    primaryKey = read[0].ToString();

                }
                read.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    } 
}
