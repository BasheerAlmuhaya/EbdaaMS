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
    public partial class dscours_add : Form
    {

        dcon conn = new dcon();
        public dscours_add()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void dscours_add_Load(object sender, EventArgs e)
        {
            try
            {

                conn.open();
                String sql = "select * from levels ";
                String sql2 = "select * from teachers ";

                comboBox1.DataSource = conn.GetTable(sql);
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";

                //////////////////////

                idComboBox.DataSource = conn.GetTable(sql2);
                idComboBox.DisplayMember = "name";
                idComboBox.ValueMember = "id";





            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            try
            {

                //   MessageBox.Show(idComboBox.S electedValue + " " + comboBox1.SelectedValue + "");

                string sqlstr = "select isnull (max(id),0) from cours_diss";
                int pk = conn.ExecuteAnyQurey(sqlstr) + 1;
                ////        sqlstr = "INSERT INTO [dbo].[cours_diss]"
                ////     +  " ([id] ,[teacher],[cours],[cours_start],[cours_end])
                ////+" VALUES ("+pk+",teacher, int,>
                ////       ,<cours, int,>
                ////       ,<cours_start, nvarchar(max),>
                ////       ,<cours_end, nvarchar(max),>)"
                sqlstr = "insert into cours_diss ([id],[teacher],[cours],[cours_start],[cours_end])" + "values(" + pk + ", " +
                  idComboBox.SelectedValue + ",'" + comboBox1.SelectedValue + "' , ' " + dateTimePicker1.Value.ToString() + " ' , ' " + dateTimePicker2.Value.ToString() + " '  ) ;";

                conn.ExecuteAnyQurey(sqlstr);



            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
