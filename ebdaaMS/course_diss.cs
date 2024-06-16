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
    public partial class course_diss : UserControl
    {

        DataTable table;
        dcon conn = new dcon();

        public course_diss()
        {
            InitializeComponent();

            try
            {


                string sql = "select cours_diss.id 'رقم التوزيع', TEACHERS.name'إسم المدرس ' , levels.name 'إسم الكورس ',cours_start 'تاريخ البدء ',cours_end 'تاريخ النهاية 'from TEACHERS, levels,cours_diss where cours_diss.teacher= TEACHERS.id and cours_diss.cours=levels.id;";


                conn.open();


                table = conn.GetTable(sql);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {
                
                               MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new dscours_add().ShowDialog();

            string sql = "select cours_diss.id 'رقم التوزيع', TEACHERS.name'إسم المدرس ' , levels.name 'إسم الكورس ',cours_start 'تاريخ البدء ',cours_end 'تاريخ النهاية 'from TEACHERS, levels,cours_diss where cours_diss.teacher= TEACHERS.id and cours_diss.cours=levels.id;";


            dataGridView1.DataSource = conn.GetTable(sql); try
            {

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {


                int idedit = Convert.ToInt32(dataGridView1.CurrentRow.Cells["رقم التوزيع"].Value);



                new dscourse_edite(idedit).ShowDialog();


                string sql = "select cours_diss.id 'رقم التوزيع', TEACHERS.name'إسم المدرس ' , levels.name 'إسم الكورس ',cours_start 'تاريخ البدء ',cours_end 'تاريخ النهاية 'from TEACHERS, levels,cours_diss where cours_diss.teacher= TEACHERS.id and cours_diss.cours=levels.id;";


                dataGridView1.DataSource = conn.GetTable(sql);

            }
            catch (Exception  ex)
            {
                
           MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsaltoTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string sql = "select cours_diss.id 'رقم التوزيع', TEACHERS.name'إسم المدرس ' , levels.name 'إسم الكورس ', cours_diss.cours_start 'تاريخ البدء ' , cours_diss.cours_end 'تاريخ النهاية '  from TEACHERS, levels,cours_diss  where cours_diss.teacher= TEACHERS.id and cours_diss.cours=levels.id  andcours_diss.id  + TEACHERS.name  + levels.name + cours_diss.cours_start + cours_diss.cours_end  like '%" + dsaltoTextBox1.Text + "%';";


                dataGridView1.DataSource = conn.GetTable(sql);



            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
