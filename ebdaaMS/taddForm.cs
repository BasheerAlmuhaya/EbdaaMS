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
    public partial class taddForm : Form
    {
        int pk;
        static string server = "DESKTOP-7FGHCAF";
        string sqlstr = "";
        dcon dconn = new dcon();
       

        public taddForm()
        {
            InitializeComponent();

            tabunifuMaterialTextbox1.Text = "";
            tabunifuMaterialTextbox3.Text = "";

            tabunifuMaterialTextbox4.Text = "";


            
        }

       

        private void taddFlatButton2_Click(object sender, EventArgs e)
        {
            if (tabunifuMaterialTextbox1.Text != "" || qualcombobox.SelectedItem != null || tabunifuMaterialTextbox3.Text != "" || tabunifuMaterialTextbox4.Text != "")
            {
                sqlstr = "select isnull(max(id),0) from teachers";
                pk = dconn.ExecuteAnyQurey(sqlstr) + 1;

                sqlstr = "insert into teachers (id,name,qualification,address,phonenumber)" + "values(" + pk + ",'" +
                    tabunifuMaterialTextbox1.Text + "','" + qualcombobox.SelectedItem + "','" +
                    tabunifuMaterialTextbox3.Text + "','" + tabunifuMaterialTextbox4.Text + "')";
                dconn.ExecuteAnyQurey(sqlstr);
            }
            else
                errorlabel.Text = " يجب عليك مليء كل الحقول  ";


            
        }

        private void tabunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();            
        }

        private void tabunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            errorlabel.Text = dconn.CheckText(e);
            if (errorlabel.Text == "")
                tabunifuMaterialTextbox1.LineFocusedColor = Color.Black;
            else
                tabunifuMaterialTextbox1.LineFocusedColor = Color.Red;
        }
        //private void tabunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    errorlabel.Text = dconn.CheckText(e);
        //    if (errorlabel.Text == "")
        //        tabunifuMaterialTextbox2.LineFocusedColor = Color.Black;
        //    else
        //        tabunifuMaterialTextbox2.LineFocusedColor = Color.Red;
        //}
        private void tabunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorlabel.Text = "";
            int num ;
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
        private void tabunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabunifuMaterialTextbox4.Text.Length <=8 ||e.KeyChar==(char)Keys.Back)
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



        private void tapanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
