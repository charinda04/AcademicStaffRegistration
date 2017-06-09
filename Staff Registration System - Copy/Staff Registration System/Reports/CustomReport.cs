using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Registration_System.Reports
{
    class CustomReport
    {
        Connection conn = new Connection();
        /*
        public void BindReport(CheckedListBox x, CrystalReportViewer crystalReportViewer1, CrystalReport5 CrystalReport5)
        {

            try
            {
                string query = "SELECT * ";

                foreach (object itemChecked in x.CheckedItems)
                {
                    query += itemChecked.ToString() + ",";
                    MessageBox.Show(itemChecked.ToString());
                }
                // for (int i = 0; i < x.Items.Count; i++)
                // {
                //    if (x.))
                //     {
                //        query += x.SelectedValue + ",";
                //        MessageBox.Show("test");
                //     }
                //    MessageBox.Show(x.SelectedIndex.ToString());
                // }

                query = query.Substring(0, query.Length - 1);
                query += " FROM AcademicStaff";

                MessageBox.Show(query);
                // ReportDocument crystalReport = new ReportDocument();
                // crystalReportViewer1.DisplayGroupTree = false;
                // crystalReport.Load(@"C:\Users\Charinda\AcademicStaffRegistration\Staff Registration System - Copy\Staff Registration System\CrystalReport5.rpt");
                //CrystalReport5.Load(Application.StartupPath + ("~/Report1.rpt"));
                // DataSet1 dsCustomers = GetData(query, crystalReport);
                //  crystalReport.SetDataSource(dsCustomers);
                //  crystalReportViewer1.ReportSource = crystalReport;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public DataSet1 GetData(string query, ReportDocument crystalReport)
        {

            DataSet1 dsCustomers = new DataSet1();

            try
            {
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = new SqlCommand(query, conn.connConnection());



                SqlDataReader sdr = cmd.ExecuteReader();

                //Get the List of all TextObjects in Section2.
                List<TextObject> textObjects = crystalReport.ReportDefinition.Sections["Section2"].ReportObjects.OfType<TextObject>().ToList();
                for (int i = 0; i < textObjects.Count; i++)
                {
                    //Set the name of Column in TextObject.
                    textObjects[i].Text = string.Empty;
                    if (sdr.FieldCount > i)
                    {
                        textObjects[i].Text = sdr.GetName(i);
                    }
                }
                //Load all the data rows in the Dataset.
                while (sdr.Read())
                {
                    DataRow dr = dsCustomers.Tables[0].Rows.Add();
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        dr[i] = sdr[i];
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            conn.closeConnection();
            return dsCustomers;
        }

        public void dataGridView(DataGridView tblSearch)
        {

            try
            {
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff ", conn.connConnection());
                // cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Cus(CrystalReportViewer crystalReportViewer1, CrystalReport5 CrystalReport5)
        {
            try
            {
                conn.connConnection();

                string sql = null;


                // sql = procesSQL();
                sql = "SELECT * FROM AcademicStaff";
                SqlDataAdapter dscmd = new SqlDataAdapter(sql, conn.connConnection());
                DataSet1 ds = new DataSet1();
                dscmd.Fill(ds, "Product");
                CrystalReport5.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = CrystalReport5;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void try1(CrystalReportViewer crystalReportViewer1, DataGridView tblSearch)
        {
            try
            {
                DataSet ds = new DataSet();

                ds = FetchDataFromGrid(tblSearch);

                CrystalReport1 myReport = new CrystalReport1();

                myReport.SetDataSource(ds);

                crystalReportViewer1.ReportSource = myReport;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public DataSet FetchDataFromGrid(DataGridView tblSearch)
        {
            DataSet ds = new DataSet();
            try
            {

                DataTable dt = new DataTable();


                foreach (DataGridViewRow item in tblSearch.Rows)
                {

                    DataRow dr = dt.NewRow();

                    if (item.DataBoundItem != null)
                    {
                        dr = (DataRow)((DataRowView)item.DataBoundItem).Row;
                        dt.ImportRow(dr);
                        MessageBox.Show("test");
                    }
                }

                ds.Tables.Add(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return ds;
        }

        public void try2(CrystalReportViewer crystalReportViewer1)
        {
            try
            {
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff ; ", conn.connConnection());
                // cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                CrystalReport1 myReport = new CrystalReport1();

                myReport.SetDataSource(table);

                crystalReportViewer1.ReportSource = myReport;


                conn.closeConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }*/
    }
}
