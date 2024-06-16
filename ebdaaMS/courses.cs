using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ebdaaMS
{
    public partial class courses : UserControl
    {
         string idcells;
         dcon dcon1 = new dcon(); 
        public courses()
        {
            InitializeComponent();
            string sql1 = "Select * From COURSES";
            dgvc.DataSource = dcon1.GetTable(sql1);
          
        }

        private void courses_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }



        private void butname_Click(object sender, EventArgs e)
        {
            string sql2 = "Select * From COURSES  where convert(varchar,id) + name + type like '%" + textname.Text + "%' ";
            dgvc.DataSource = dcon1.GetTable(sql2);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void altoTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void edic_Click(object sender, EventArgs e)
        {
            if (dgvc.CurrentRow != null) {
                idcells = dgvc.CurrentRow.Cells[0].Value.ToString();
                editor oc = new editor(idcells);
                oc.ShowDialog();
               

                            }

            else { MessageBox.Show("فضلا قم بتحديد صف للتعديل عليه", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void addc_Click(object sender, EventArgs e)
        {
            ADDC od = new ADDC();
            od.ShowDialog();
        }

       

        private void delc_Click(object sender, EventArgs e)
        {
            string sql3 ="Delete from COURSES where id =" + dgvc.CurrentRow.Cells[0].Value + " ";
            if (dgvc.CurrentRow!= null)
            {     
            dcon1.ExecuteAnyQurey(sql3);
                            }
           

            else{
                MessageBox.Show("فضلا قم بتحديد صف للتعديل عليه", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void spinningCircles1_Click(object sender, EventArgs e)
        {

        }

        


     
    }
}
