using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebdaaMS
{
    public partial class reigestion : UserControl
    {
        string sql = "";
        dcon dconn = new dcon();
        DataTable dt = new DataTable();
       
        public reigestion()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh() {

  //     String sqlstr = "select STUDENTS.arfirst 'إسم الطالب ' , TEACHERS.name 'إسم المدرس ' , levels.name 'اسم الكورس',ENROLLMENT.price 'السعر' ,cours_start 'تاريخ البدء ',cours_end 'تاريخ النهاية ' "
  //+ "from STUDENTS, TEACHERS, levels, ENROLLMENT ,cours_diss"
  //+ "where ENROLLMENT.student =STUDENTS.ID "
  //+ "and cours_diss.teacher= TEACHERS.id "
  //+ "and cours_diss.cours=levels.id ";

            //String sqlstr = "select STUDENTS.arfirst 'إسم الطالب ' , TEACHERS.name 'إسم المدرس ' , levels.name 'اسم الكورس',ENROLLMENT.price 'السعر' ,cours_start 'تاريخ البدء ',cours_end 'تاريخ النهاية ' from STUDENTS, TEACHERS, levels, ENROLLMENT ,cours_diss where ENROLLMENT.student =STUDENTS.ID  and cours_diss.teacher= TEACHERS.id and cours_diss.cours=levels.id;";

            string sqlstr = "select STUDENTS.arfirst 'إسم الطالب ' , TEACHERS.name 'إسم المدرس ' , levels.name 'اسم الكورس',ENROLLMENT.price 'السعر' ,cours_start 'تاريخ البدء ',cours_end 'تاريخ النهاية ' from STUDENTS, TEACHERS, levels, ENROLLMENT ,cours_diss where ENROLLMENT.diss_id=cours_diss.id and  ENROLLMENT.student =STUDENTS.ID  and cours_diss.teacher= TEACHERS.id and cours_diss.cours=levels.id; ";
            
            dataGridView1.DataSource = dconn.GetTable(sqlstr);

        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dsaltoTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string studentname = dataGridView1.CurrentRow.Cells["إسم الطالب "].Value.ToString();
                string teachername = dataGridView1.CurrentRow.Cells["إسم المدرس "].Value.ToString();
                string levelename = dataGridView1.CurrentRow.Cells["اسم الكورس"].Value.ToString();

                new addreg(studentname, teachername, levelename).ShowDialog();
                refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {

                string studentname = dataGridView1.CurrentRow.Cells["إسم الطالب "].Value.ToString();
                string teachername = dataGridView1.CurrentRow.Cells["إسم المدرس "].Value.ToString();
                string levelename = dataGridView1.CurrentRow.Cells["اسم الكورس"].Value.ToString();

                //get student id
                sql = "select * from STUDENTS where arfirst='" + studentname + "'";
                dt = dconn.GetTable(sql);
                string id = dt.Rows[0]["id"].ToString();

                //get teacher id
                sql = "select id from teachers where name='" + teachername + "'";
                dt = dconn.GetTable(sql);
                string id2 = dt.Rows[0]["id"].ToString();

                //get level id
                sql = "select id from levels where name='" + levelename + "'";
                dt = dconn.GetTable(sql);
                string id3 = dt.Rows[0]["id"].ToString();

                //get id of cours_diss
                sql = "select id from cours_diss where teacher=" + id2 + " and cours=" + id3;
                dt = dconn.GetTable(sql);
                string id4 = dt.Rows[0]["id"].ToString();

                sql = "DELETE FROM ENROLLMENT where diss_id=" + id4 + " and student=" + id;

                dconn.ExecuteAnyQurey(sql);
                refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                new addreg().ShowDialog();
                refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }


}
