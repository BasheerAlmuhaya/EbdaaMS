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
    public partial class dscourse_edite : Form
    {
        dcon conn;
        string sql;
        
        int id;
        public dscourse_edite(int id)
        {
            InitializeComponent();
            try
            {
                conn = new dcon();
                this.id = id;

            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dscourse_edite_Load(object sender, EventArgs e)
        {
            try
            {
                conn.open();


                string sql1 = "select * from teachers ";
                string sql2 = "select * from levels ";

                comboBox2.DataSource = conn.GetTable(sql2);
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";

                comboBox1.DataSource = conn.GetTable(sql1);
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";



            }
            catch (Exception ex)
            {
                
           MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            //////////////////////
  
         





        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlstr = "update  cours_diss  set [teacher]=' " + comboBox1.SelectedValue + "',[cours] ='" + comboBox2.SelectedValue + "' ,[cours_start]=' " + dateTimePicker1.Value.ToString() + " ' ,[cours_end]= ' " + dateTimePicker2.Value.ToString() + " '   where id =" + id + "";

                conn.ExecuteAnyQurey(sqlstr);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
