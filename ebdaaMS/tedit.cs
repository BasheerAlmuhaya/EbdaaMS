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
    public partial class tedit : Form
    {
        int pk, max;
        static string server = "DESKTOP-7FGHCAF";
        string sqlstr = "";
        dcon dconn = new dcon();
        

        public tedit(string id)
        {
            InitializeComponent();
        try 
	{	        
		    pk = int.Parse(id);
            
            sqlstr = "select max(id) from teachers ";
            max = dconn.ExecuteAnyQurey(sqlstr);
            refreshing();
	}
		
		 catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

	};

        }

       

        private void tabunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void taddFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (tabunifuMaterialTextbox1.Text != "" || qualcombobox.SelectedText != "" || tabunifuMaterialTextbox3.Text != "" || tabunifuMaterialTextbox4.Text != "")
                {
                    sqlstr = "update teachers set name = '" +
                        tabunifuMaterialTextbox1.Text + "',qualification = '" + qualcombobox.SelectedItem + "', address = '" +
                        tabunifuMaterialTextbox3.Text + "', phonenumber = '" + tabunifuMaterialTextbox4.Text + "' where id = " + pk + "";
                    dconn.ExecuteAnyQurey(sqlstr);


                }

                else
                {
                    errorlabel.Text = " يجب عليك مليء كل الحقول  ";


                }
            }
             catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tbunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (pk > 1)
            {
                pk--;
                refreshing();
            }
        }

        private void tbunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (pk < max)
            {
                pk++;
                refreshing();
            }
        }

        public void refreshing()
        {
            try
            {


                DataTable dt = new DataTable();
                sqlstr = "select * from teachers where id = " + pk + "";
                dt = dconn.GetTable(sqlstr);
                tabunifuMaterialTextbox1.Text = dt.Rows[0]["name"].ToString();
                qualcombobox.Text = dt.Rows[0]["qualification"].ToString();
                tabunifuMaterialTextbox3.Text = dt.Rows[0]["address"].ToString();
                tabunifuMaterialTextbox4.Text = dt.Rows[0]["phonenumber"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tapanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            errorlabel.Text = dconn.CheckText(e);
            if (errorlabel.Text == "")
                tabunifuMaterialTextbox1.LineFocusedColor = Color.Black;
            else
                tabunifuMaterialTextbox1.LineFocusedColor = Color.Red;

        }

        private void tabunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tabunifuMaterialTextbox3_Keypress(object sender, KeyPressEventArgs e)
        {
            try
            {
                errorlabel.Text = "";
                int num;
                if (int.TryParse(tabunifuMaterialTextbox3.Text, out num))
                    errorlabel.Text = "لايقبل حقل العنوان أرقام فقط";
                //else
                //    errorlabel.Text = "";

                //  errorlabel.Text = dconn.CheckText(e);

                if (errorlabel.Text == "")
                    tabunifuMaterialTextbox3.LineFocusedColor = Color.Black;
                else
                    tabunifuMaterialTextbox3.LineFocusedColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tabunifuMaterialTextbox4_Keypress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (tabunifuMaterialTextbox4.Text.Length <= 8 || e.KeyChar == (char)Keys.Back)
                    errorlabel.Text = dconn.CheckNumber(e);

                else if (tabunifuMaterialTextbox4.Text.Length > 8)
                {
                    e.Handled = true;
                    errorlabel.Text = " رقم التلفون يجب أن لا يكون اكبر من 9 ارقام";
                }

                if (errorlabel.Text == "")
                    tabunifuMaterialTextbox4.LineFocusedColor = Color.Black;
                else
                    tabunifuMaterialTextbox4.LineFocusedColor = Color.Red;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
    }
}
