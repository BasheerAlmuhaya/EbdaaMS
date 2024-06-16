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
    public partial class UserControlStudent : UserControl
    {

         dcon dcon1 = new dcon(); 
        public UserControlStudent()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            String sqlstr = "select id 'رقم الطالب ' , enfirst +' '+ ensecond  +' '+ enthird +' ' + enfourth 'الإسم بالأنجليزية' ,arfirst  +' '+ arsecond +' ' + arthird  +' ' + arfoutrh 'الإسم بالعربية' ,qualification 'المؤهلات',burnplace'محل الميلاد ' , [burndate] ' تاريخ الميلاد  ' ,[phonenumber] 'رقم التلفون'   from STUDENTS";
            dataGridView1.DataSource = dcon1.GetTable(sqlstr);
          
        }

        private void altoTextBoxName_TextChanged(object sender, EventArgs e)
        {
            string sql = "select id 'رقم الطالب ' , enfirst +' '+ ensecond  +' '+ enthird +' ' + enfourth 'الإسم بالأنجليزية' ,arfirst  +' '+ arsecond +' ' + arthird  +' ' + arfoutrh 'الإسم بالعربية' ,qualification 'المؤهلات',burnplace'محل الميلاد ' , [burndate] ' تاريخ الميلاد  ' ,[phonenumber] 'رقم التلفون'   from STUDENTS where   convert (varchar , id ) like '%" + dsaltoTextBox1.Text + "%' ";

              dataGridView1.DataSource = dcon1.GetTable(sql); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void altoButtonDel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                 DialogResult result =

            MessageBox.Show("هل تريد حذف الطالب المحدد؟", "حذف",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);


                 if (result == DialogResult.Yes)
                 {
                     String sql = "DELETE FROM ENROLLMENT where student=" + dataGridView1.CurrentRow.Cells["id"].Value + "";

                     dcon1.ExecuteAnyQurey2(sql);
                     String sqlstr = "delete from STUDENTS where id =" + dataGridView1.CurrentRow.Cells["id"].Value + "";
                     dcon1.ExecuteAnyQurey(sqlstr);

                     //MessageBox.Show("تمت العملية بنجاح ");

                     sqlstr = "select id 'رقم الطالب ' , enfirst +' '+ ensecond  +' '+ enthird +' ' + enfourth 'الإسم بالأنجليزية' ,arfirst  +' '+ arsecond +' ' + arthird  +' ' + arfoutrh 'الإسم بالعربية' ,qualification 'المؤهلات',burnplace'محل الميلاد ' , [burndate] ' تاريخ الميلاد  ' ,[phonenumber] 'رقم التلفون'  from STUDENTS";
                     dataGridView1.DataSource = dcon1.GetTable(sqlstr);
                 }
            }

            catch (Exception ex)
            {

                MessageBox.Show("هناك مشكلة في حذف طالب ");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                new AddStudent().ShowDialog();
                String sql = " select id 'رقم الطالب ' , enfirst +' '+ ensecond  +' '+ enthird +' ' + enfourth 'الإسم بالأنجليزية' ,arfirst  +' '+ arsecond +' ' + arthird  +' ' + arfoutrh 'الإسم بالعربية' ,qualification 'المؤهلات',burnplace'محل الميلاد ' , [burndate] ' تاريخ الميلاد  ' ,[phonenumber] 'رقم التلفون'   from STUDENTS";
                dataGridView1.DataSource = dcon1.GetTable(sql);
            }

            catch (Exception ex) {

                MessageBox.Show("هناك مشكلة في إضافة طالب ");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string idedit = dataGridView1.CurrentRow.Cells["رقم الطالب "].Value.ToString();


                //byte[] image = (byte[]) (dataGridView1.CurrentRow.Cells["picture"].Value) ;

                //new edite_student(idedit, image).ShowDialog();

                new edite_student(idedit).ShowDialog();

                string sql = "select id 'رقم الطالب ' , enfirst +' '+ ensecond  +' '+ enthird +' ' + enfourth 'الإسم بالأنجليزية' ,arfirst  +' '+ arsecond +' ' + arthird  +' ' + arfoutrh 'الإسم بالعربية' ,qualification 'المؤهلات',burnplace'محل الميلاد ' , [burndate] ' تاريخ الميلاد  ' ,[phonenumber] 'رقم التلفون'  from STUDENTS";
                dataGridView1.DataSource = dcon1.GetTable(sql);
            }

            catch (Exception e2)
            {

                MessageBox.Show("هناك مشكلة في تعديل طالب ");
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsaltoTextBox1_Click(object sender, EventArgs e)
        {
            dsaltoTextBox1.Text = "";
        }

        private void dsaltoTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string sql = "select id 'رقم الطالب ' , enfirst +' '+ ensecond  +' '+ enthird +' ' + enfourth 'الإسم بالأنجليزية' ,arfirst  +' '+ arsecond +' ' + arthird  +' ' + arfoutrh 'الإسم بالعربية' ,qualification 'المؤهلات',burnplace'محل الميلاد ' , [burndate] ' تاريخ الميلاد  ' ,[phonenumber] 'رقم التلفون'  from STUDENTS where enfirst + arfirst + ensecond + arsecond + enthird + arthird + enfourth + arfoutrh +  convert (varchar , id ) like '%" + dsaltoTextBox1.Text + "%' ";

                dataGridView1.DataSource = dcon1.GetTable(sql);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message,"error");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

    