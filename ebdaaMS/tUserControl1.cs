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
    public partial class tUserControl1 : UserControl
    {
        string sqlstr = "";
        dcon dconn = new dcon();

        public tUserControl1()
        {
            try
            {

                InitializeComponent();
                this.Dock = DockStyle.Fill;
                sqlstr = "select id 'رقم المدرس' ,name 'الإسم' , qualification 'المؤهلات ' ,address 'العنوان ' , phonenumber 'رقم الهاتف '  from teachers  ";
                tdataGridView1.DataSource = dconn.GetTable(sqlstr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                 sqlstr = "select id 'رقم المدرس' ,name 'الإسم' , qualification 'المؤهلات ' ,address 'العنوان ' , phonenumber 'رقم الهاتف '  from teachers where name + address + convert (varchar , id ) like '%" + tsearchTextBox1.Text + "%' ";
                tdataGridView1.DataSource = dconn.GetTable(sqlstr);
                //tdataGridView1[tid,] = table.Columns["id"];

            }
            catch (Exception ex)
            {
                   MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsearchTextBox1_Click(object sender, EventArgs e)
        {
            tsearchTextBox1.Text = "";
        }

        private void tbunifuImageButton1_Click(object sender, EventArgs e)
        {
            tsearchTextBox1.Visible = true;
            tsearchTextBox1.Text = "";
          //  tbunifuImageButton2.Visible = true;
          //  tbunifuImageButton1.Visible = false;
        }

        private void tbunifuImageButton2_Click(object sender, EventArgs e)
        {
            tsearchTextBox1.Visible = false;
       //     tbunifuImageButton2.Visible = false;
       //     tbunifuImageButton1.Visible = true;
        }

        private void tsearchTextBox1_Enter(object sender, EventArgs e)
        {
            tsearchTextBox1.Select();
        }

        private void taddFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                new taddForm().ShowDialog();
                sqlstr = "select id 'رقم المدرس' ,name 'الإسم' , qualification 'المؤهلات ' ,address 'العنوان ' , phonenumber 'رقم الهاتف '  from teachers where name + address + convert (varchar , id ) like '%" + tsearchTextBox1.Text + "%' ";
                tdataGridView1.DataSource = dconn.GetTable(sqlstr);

            }
            catch (Exception ex )
            {
               
                      MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlstr = "select id 'رقم المدرس' ,name 'الإسم' , qualification 'المؤهلات ' ,address 'العنوان ' , phonenumber 'رقم الهاتف '  from teachers where name + address + convert (varchar , id ) like '%" + tsearchTextBox1.Text + "%' ";
                tdataGridView1.DataSource = dconn.GetTable(sqlstr);
                //this.tdataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tdeleteFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlstr = "delete from teachers where id =" + tdataGridView1.CurrentRow.Cells["رقم المدرس"].Value + "";
                dconn.ExecuteAnyQurey(sqlstr);
                sqlstr = "select id 'رقم المدرس' ,name 'الإسم' , qualification 'المؤهلات ' ,address 'العنوان ' , phonenumber 'رقم الهاتف '  from teachers ";
                tdataGridView1.DataSource = dconn.GetTable(sqlstr);
            }
            catch (Exception ex)
            {
                
                   MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tupdateFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {


                string idedit = tdataGridView1.CurrentRow.Cells["رقم المدرس"].Value.ToString();
                // byte[] image = (byte[])tdataGridView1.CurrentRow.Cells["picture"].Value;

                new tedit(idedit).ShowDialog();
                sqlstr = "select id 'رقم المدرس' ,name 'الإسم' , qualification 'المؤهلات ' ,address 'العنوان ' , phonenumber 'رقم الهاتف '  from teachers where name + address + convert (varchar , id ) like '%" + tsearchTextBox1.Text + "%' ";
                tdataGridView1.DataSource = dconn.GetTable(sqlstr);

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpanel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
