using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebdaaMS
{
    public partial class addreg : Form
    {
        
        string sql = "";
        dcon dcon1 = new dcon();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        

        string flagname = "";
        string flagteacher = "";
        string flaglevel = "";
        
        public addreg()
        {
            InitializeComponent();
            refreshdata();
            label1.Text = "تسجيل طالب في دورة";
        }

        public addreg(string name, string teacher, string level)
        {
            InitializeComponent();
            //refreshdata();
            flagname = name;
            flagteacher=teacher;
            flaglevel = level;

            label1.Text = "تعديل بيانات طالب في دورة";

            edit();
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

                sql = "select * from levels";
                dt2 = dcon1.GetTable(sql);

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    comboBox2.Items.Add(dt2.Rows[i]["name"]);
                }

                dcon1.close();
            }

            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }

        public void edit() {

            //get specified students

            try
            {

                String sql = "select * from STUDENTS where arfirst='" + flagname + "'";


                dt = dcon1.GetTable(sql);


                if (dt.Rows.Count > 0)
                {

                    comboBox1.Items.Add(dt.Rows[0]["enfirst"] + " " + dt.Rows[0]["ensecond"] + " " + dt.Rows[0]["enthird"] + "" + dt.Rows[0]["arfirst"] + " " + dt.Rows[0]["arsecond"] + " " + dt.Rows[0]["arthird"] + "        (إنجليزي)");
                    comboBox1.Text = (dt.Rows[0]["enfirst"] + " " + dt.Rows[0]["ensecond"] + " " + dt.Rows[0]["enthird"] + "" + dt.Rows[0]["arfirst"] + " " + dt.Rows[0]["arsecond"] + " " + dt.Rows[0]["arthird"] + "        (إنجليزي)");

                }

                sql = "select * from levels";
                dt2 = dcon1.GetTable(sql);

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    comboBox2.Items.Add(dt2.Rows[i]["name"]);
                }



                dcon1.close();

            }

            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }


        public void insert() {
        
             try
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && tbprice.Text != "")
                {
                    int index = comboBox1.SelectedIndex;

                    string id = dt.Rows[index]["id"].ToString(); //student

                    int index2 = comboBox2.SelectedIndex;

                    string id2 = dt2.Rows[index2]["id"].ToString(); //course
                   
                    sql = "select cours_diss.id from cours_diss where " + id2 + " = cours_diss.cours ;";
                    dt2 = dcon1.GetTable(sql);
                    string id3 = dt2.Rows[0]["id"].ToString();
                    
                    //MessageBox.Show("student "+id);
                    //MessageBox.Show("Course " + id2);
                    //MessageBox.Show("diss id "+id3);
                    sql =

                   " INSERT INTO ENROLLMENT ([diss_id] ,[student] ,[price])" +
                    "VALUES (" + id3 + "," + id + "," + tbprice.Text + ") ";

                    dcon1.ExecuteAnyQurey(sql);
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               // MessageBox.Show("يبدو أنك سجلت طالب مسجل مسبقا في هذه الدورة");
            }

        }

        public void update() {

            try
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && tbprice.Text != "")
                {


                    string id = dt.Rows[0]["id"].ToString();

                    int index2 = comboBox2.SelectedIndex;

                    string id2 = dt2.Rows[index2]["id"].ToString();

                    sql = "select cours_diss.id from cours_diss where " + id2 + " = cours_diss.cours ;";
                    dt2 = dcon1.GetTable(sql);
                    string id3 = dt2.Rows[0]["id"].ToString();

                    //get id of previous teacher
                    sql = "select id from teachers where name='" + flagteacher + "'";
                    dt3 = dcon1.GetTable(sql);
                    string id4 = dt3.Rows[0]["id"].ToString();

                    //get id  of previous level
                    sql = "select id from levels where name='"+flaglevel+"'";
                    dt3 = dcon1.GetTable(sql);
                    string id5 = dt3.Rows[0]["id"].ToString();

                    //get id of previous cours_diss
                    sql = "select id from cours_diss where teacher=" + id4 + " and cours=" + id5;
                    dt3 = dcon1.GetTable(sql);
                    string id6 = dt3.Rows[0]["id"].ToString();

              

                    //update
                    sql =

                   " UPDATE ENROLLMENT set diss_id =" + id3 + " ,student =" + id + " ,price =" + tbprice.Text + "where diss_id="+id6+" and student="+id  ;


                    dcon1.ExecuteAnyQurey(sql);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagname == "")
                    insert();
                else
                    update();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addreg_Load(object sender, EventArgs e)
        {

        }

        private void tbprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckNumber(e);

            if (lableError.Text == "")
                tbprice.LineFocusedColor = Color.Black;

            else
                tbprice.LineFocusedColor = Color.Red;
        }
    }
}
