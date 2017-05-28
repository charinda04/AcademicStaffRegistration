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

        private void textBox5_TextChanged(object sender, EventArgs e)
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
            personal_detail2.Visible = true;
            personal_detail2.BringToFront();
        }

        private void lblPrevPdetail2_light_Click(object sender, EventArgs e)
        {
            personal_detail1.Visible = true;
            personal_detail1.BringToFront();
        }

        private void lblNextPdetail2_light_Click(object sender, EventArgs e)
        {
            educational_qualifications.Visible = true;
            educational_qualifications.BringToFront();
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
                MessageBox.Show("run");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    } 
}
