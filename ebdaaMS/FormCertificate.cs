using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ebdaaMS
{
    public partial class FormCertificate : Form
    {
        string sql = "";
        dcon dcon1 = new dcon();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        string idcourse = "";
        string idStudent="";
        //DateTime date;
        string date = "";
        string corseid = "";

        public FormCertificate()
        {
            InitializeComponent();
            refreshdata();
        }

        public void refreshdata()
        {
            //get all students

            try
            {

                String sql = "select * from STUDENTS";


                dt = dcon1.GetTable(sql);


                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    comboBox1.Items.Add(dt.Rows[i]["enfirst"] + " " + dt.Rows[i]["ensecond"] + " " + dt.Rows[i]["enthird"] + "" + dt.Rows[i]["arfirst"] + " " + dt.Rows[i]["arsecond"] + " " + dt.Rows[i]["arthird"] + "        (إنجليزي)");

                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("F:\\ebdaaMS\\ebdaaMS\\report1.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idStudent != "")
                {
                    ReportDocument cryRpt = new ReportDocument();
                    cryRpt.Load("F:\\ebdaaMS\\ebdaaMS\\report1.rpt");
                    crystalReportViewer1.ReportSource = cryRpt;

                    crystalReportViewer1.SelectionFormula = "{STUDENTS.ID} =" + idStudent;
                   // MessageBox.Show("1");
                    crystalReportViewer1.Refresh();
                    

                }

                else
                    labelError.Text = "لا بد من إختيار طالب لكي تصدر شهادة";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                int index = comboBox1.SelectedIndex;

                idStudent = dt.Rows[index]["id"].ToString(); //student

                sql = "select * from ENROLLMENT where student =" + idStudent;
                dt2 = dcon1.GetTable(sql);
                string id2 = dt2.Rows[0]["diss_id"].ToString();

                sql = "select * from cours_diss where id =" + id2;
                dt2 = dcon1.GetTable(sql);
                string id3 = dt2.Rows[0]["cours"].ToString();
                corseid = dt2.Rows[0]["id"].ToString();
                

                sql = "select * from levels where id =" + id3;
                dt2 = dcon1.GetTable(sql);
                 idcourse = dt2.Rows[0]["course"].ToString();
                int hours = Convert.ToInt32(dt2.Rows[0]["hours"]);

                sql = "select * from courses where id=" + idcourse;
                dt2 = dcon1.GetTable(sql);
                string course = dt2.Rows[0]["name"].ToString();

               // date = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                date = DateTime.Now.ToString("dd-MM-yyyy");
                

                altoTextBox1.Text = course;
                altoTextBox2.Text = hours+"";



            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (idStudent != "" && idcourse != "" && date != "")
                {

                    sql = "select isnull(max(id),0) from CIRTIFICATE ";

                    int pk = dcon1.ExecuteAnyQurey(sql) + 1;

                    sql = "INSERT INTO CIRTIFICATE ([id] ,[student],[cours],[sdate])" +
                    "VALUES ("+pk +"," + idStudent + "," + idcourse + ",'" + date + "')";

                    dcon1.ExecuteAnyQurey(sql);

                    MessageBox.Show("ok");
                }
            }

            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
