using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace ebdaaMS
{
    public partial class deplomsUserControl1 : UserControl
    {
       
        string sqlstr = "";
        dcon dconn = new dcon();
        int myChoice=2;

        public deplomsUserControl1()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            myRefresh();
        }

        private void deplomssearchTextBox1_Click(object sender, EventArgs e)
        {
            deplomssearchTextBox1.Text = ""; 
        }

        private void deplomssearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            myRefresh();
        }

        private void deplomssearchTextBox1_Enter(object sender, EventArgs e)
        {
            deplomssearchTextBox1.Select();
        }

        private void deplomsbunifuImageButton1_Click(object sender, EventArgs e)
        {
            deplomssearchTextBox1.Visible = true;
            deplomssearchTextBox1.Text = "";
           // deplomsbunifuImageButton2.Visible = true;
        //    deplomsbunifuImageButton1.Visible = false;
        }

        private void deplomsbunifuImageButton2_Click(object sender, EventArgs e)
        {
            deplomssearchTextBox1.Visible = false;
         //   deplomsbunifuImageButton2.Visible = false;
         //   deplomsbunifuImageButton1.Visible = true;
        }

        private void deplomsbunifuImageButton3_Click(object sender, EventArgs e)
        {
            myRefresh();
        }

        private void deplomsaddFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                deplomsForm deplomsadd = new deplomsForm(this.myChoice);
                deplomsadd.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            myRefresh();
        }

        void myRefresh()
        {
            try
            {
                switch (myChoice)
                {
                    case 1:
                        {
                            this.bunifuThinButton21.IdleFillColor = Color.FromArgb(135, 146, 166);
                            this.bunifuThinButton22.IdleFillColor = Color.White;
                            this.bunifuThinButton23.IdleFillColor = Color.White;
                            sqlstr = "select id 'الرقم' , name 'الاسم' from programs "
                                    + "where name + convert (varchar , id ) like '%" + deplomssearchTextBox1.Text + "%' ";
                            break;
                        }
                    case 3:
                        {
                            this.bunifuThinButton23.IdleFillColor = Color.FromArgb(135, 146, 166);
                            this.bunifuThinButton21.IdleFillColor = Color.White;
                            this.bunifuThinButton22.IdleFillColor = Color.White;
                            sqlstr = "select levels.id 'الرقم' ,levels.name 'المستوى' ,levels.hours 'عدد الساعات' ,courses.name 'الدبلوم' "
                                + "from levels left join courses on levels.course=courses.id "
                                + "where levels.name + convert (varchar , levels.id ) like '%"
                                + deplomssearchTextBox1.Text + "%' ";
                            break;
                        }
                    default:
                        {
                            this.bunifuThinButton22.IdleFillColor = Color.FromArgb(135, 146, 166);
                            this.bunifuThinButton21.IdleFillColor = Color.White;
                            this.bunifuThinButton23.IdleFillColor = Color.White;
                            sqlstr = "select courses.id 'الرقم' ,courses.name 'اسم الدبلوم' ,"
                                    + "courses.E_name 'اسم الدبلوم بالانجليزي',programs.name 'اسم البرنامج'"
                                    + "from courses left join programs on courses.program=programs.id "
                                    + "where courses.name + convert (varchar , courses.id ) like '%" + deplomssearchTextBox1.Text + "%' ";
                            break;
                        }
                }
                deplomsdataGridView1.DataSource = dconn.GetTable(sqlstr);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void deplomsdeleteFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                switch (myChoice)
                {
                    case 1: { sqlstr = "delete from programs where id =" + deplomsdataGridView1.CurrentRow.Cells["الرقم"].Value + ""; break; }
                    case 3: { sqlstr = "delete from levels where id =" + deplomsdataGridView1.CurrentRow.Cells["الرقم"].Value + ""; break; }
                    default: { sqlstr = "delete from courses where id =" + deplomsdataGridView1.CurrentRow.Cells["الرقم"].Value + ""; break; }
                }
                dconn.ExecuteAnyQurey(sqlstr);
            }
            catch(Exception exp){
                MessageBox.Show(exp.Message);
            }
            myRefresh();

        }

        private void deplomsupdateFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string idedit = deplomsdataGridView1.CurrentRow.Cells["الرقم"].Value.ToString();
                deplomsForm deplomsedit = new deplomsForm(this.myChoice, idedit);
                deplomsedit.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            myRefresh();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            myChoice = 1;
            myRefresh();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            myChoice = 2;
            myRefresh();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            myChoice = 3;
            myRefresh();
        }
    }
}
