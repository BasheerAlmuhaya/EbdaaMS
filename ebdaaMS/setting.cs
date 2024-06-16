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
    public partial class setting : Form
    {
        dcon dcon1 = new dcon();
        DataTable dt = new DataTable();
        String sql = "";
        int pk;

        public setting()//bool new) //add new user or edit old user
        {
            InitializeComponent();
            //if(!new){
            this.myRefresh();
            //}
            this.mycheck();
            
        }

        void myRefresh()
        {
            try
            {
                sql = "select * from users where name = '"
                    + ebdaaMS.Properties.Settings.Default.current_user + "'";
                dt = dcon1.GetTable(sql);
                label1.Text = dt.Rows[0]["name"].ToString();
                pk = int.Parse(dt.Rows[0]["id"].ToString());
                bunifuMaterialTextbox1.Text = dt.Rows[0]["name"].ToString();
                bunifuMaterialTextbox4.Text = dt.Rows[0]["full_name"].ToString();
                bunifuMaterialTextbox2.Text = dt.Rows[0]["password"].ToString();
                bunifuMaterialTextbox3.Text = dt.Rows[0]["password"].ToString();
                if(dt.Rows[0]["picture"]!=DBNull.Value)
                bunifuImageButton1.Image = (Image)dt.Rows[0]["picture"];
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            this.canSave(0);
        }

        void mycheck()
        {
            if (bunifuMaterialTextbox2.Text != "" && metroCheckBox1.Checked)
                bunifuMaterialTextbox2.isPassword = true;
            else bunifuMaterialTextbox2.isPassword = false;
            if (bunifuMaterialTextbox3.Text != "" && metroCheckBox1.Checked)
                bunifuMaterialTextbox3.isPassword = true;
            else bunifuMaterialTextbox3.isPassword = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            this.mycheck();
            this.canSave(bunifuMaterialTextbox2.TabIndex);
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            this.mycheck();
            this.canSave(bunifuMaterialTextbox3.TabIndex);
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.mycheck();
        }

        void canSave(int index)
        {
            if (bunifuMaterialTextbox1.Text == "" && bunifuMaterialTextbox1.TabIndex < index)
            {
                bunifuMaterialTextbox1.LineIdleColor = Color.Red;
                bunifuMaterialTextbox1.LineFocusedColor = Color.Red;
                bunifuMaterialTextbox1.LineMouseHoverColor = Color.Red;
            }
            else
            {
                bunifuMaterialTextbox1.LineIdleColor = Color.FromArgb(31, 58, 87);
                bunifuMaterialTextbox1.LineFocusedColor = Color.FromArgb(31, 58, 87);
                bunifuMaterialTextbox1.LineMouseHoverColor = Color.FromArgb(31, 58, 87);
            }

            if (bunifuMaterialTextbox2.Text == "" && bunifuMaterialTextbox2.TabIndex < index)
            {
                bunifuMaterialTextbox2.LineIdleColor = Color.Red;
                bunifuMaterialTextbox2.LineFocusedColor = Color.Red;
                bunifuMaterialTextbox2.LineMouseHoverColor = Color.Red;
            }
            else
            {
                bunifuMaterialTextbox2.LineIdleColor = Color.FromArgb(31, 58, 87);
                bunifuMaterialTextbox2.LineFocusedColor = Color.FromArgb(31, 58, 87);
                bunifuMaterialTextbox2.LineMouseHoverColor = Color.FromArgb(31, 58, 87);
            }

            if (!bunifuMaterialTextbox2.Text.Equals(bunifuMaterialTextbox3.Text))
            {
                bunifuMaterialTextbox3.LineIdleColor = Color.Red;
                bunifuMaterialTextbox3.LineFocusedColor = Color.Red;
                bunifuMaterialTextbox3.LineMouseHoverColor = Color.Red;
                label7.Text = "لا يوجد تطابق";
            }
            else
            {
                bunifuMaterialTextbox3.LineIdleColor = Color.FromArgb(31, 58, 87);
                bunifuMaterialTextbox3.LineFocusedColor = Color.FromArgb(31, 58, 87);
                bunifuMaterialTextbox3.LineMouseHoverColor = Color.FromArgb(31, 58, 87);
                label7.Text = "";
            }

            if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == ""
                || !bunifuMaterialTextbox2.Text.Equals(bunifuMaterialTextbox3.Text))
            {
                //MessageBox.Show("error");
                button1.Enabled = false;
                //return false; 
            }
            else
            {
                //MessageBox.Show("خطاء في المدخلات \n يرجى مراجعة البيانات ثم اعادة المحاولة");
                button1.Enabled = true;// MessageBox.Show("noerror");
                //return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    sql = "update users set name = '" + bunifuMaterialTextbox1.Text + "'"
                        + ", full_name = '" + bunifuMaterialTextbox4.Text + "'"
                        + ", password = '" + bunifuMaterialTextbox2.Text + "'"
                        //+ ", picture = " + bunifuImageButton1.Image + ""
                        + " where id = " + pk + "";
                    dcon1.ExecuteAnyQurey(sql);
                    sql = "select name from users where id = " + pk;
                    dt = dcon1.GetTable(sql);
                    ebdaaMS.Properties.Settings.Default.current_user = dt.Rows[0]["name"].ToString();
                    this.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return;
                }            
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            this.canSave(bunifuMaterialTextbox4.TabIndex);
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            this.canSave(bunifuMaterialTextbox2.TabIndex);
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            this.canSave(bunifuMaterialTextbox3.TabIndex);
        }

    }
}
