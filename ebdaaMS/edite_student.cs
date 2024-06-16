using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebdaaMS
{
    public partial class edite_student : Form
    {
        int pk, max;
        string sqlstr = "";
        dcon dconn = new dcon();
        string  filePath="";
        string filename="";
        DataTable dt = new DataTable();
        String sql = "";

        //public edite_student(string id , byte [] imge)
        //{
        //    InitializeComponent();
        // pk = int.Parse(id);
        // img = imge;

        // sqlstr = "select max(id) from STUDENTS ";
        //    max = dconn.ExecuteAnyQurey(sqlstr);
        //    refreshing();
        //    refreshdata();
        //}

        public edite_student(string id)
        {
            InitializeComponent();
            pk = int.Parse(id);
            getCountries();

            sqlstr = "select max(id) from STUDENTS ";
            max = dconn.ExecuteAnyQurey(sqlstr);
            refreshing();
            //refreshdata();

          //  lableError.Visible = false;
        }


        public void getCountries()
        {

            try
            {

                sql = "select * from nationalaty";


                dt = dconn.GetTable(sql);
                nationality.DataSource = dt;
                nationality.DisplayMember = "name";
                nationality.ValueMember = "id";

               // nationality.Text = "YEMEN";
                
            }

            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void refreshing()
        {

            try
            {

                DataTable dt = new DataTable();
                sqlstr = "select * from STUDENTS where id =" + pk;
                
                dt = dconn.GetTable(sqlstr);

                if (dt.Rows.Count > 0)
                {
                    string sqlstr2 = "select * from STUDENTS where [picture] is not null and id= " + pk;
                    DataTable dt2 = new DataTable();
                    dt2 = dconn.GetTable(sqlstr2);
                   
                    if (dt2.Rows.Count > 0)
                    {
                        byte[] b = (byte[])dt2.Rows[0]["picture"];
                        MemoryStream ms = new MemoryStream(b);
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    //bunifuMaterialTextbox14.Text = dt.Rows[0]["ID"].ToString();
                    // bunifuMaterialTextbox9.Text = dt.Rows[0]["burndate"].ToString();
                    bunifuMaterialTextbox11.Text = dt.Rows[0]["phonenumber"].ToString();
                    bunifuMaterialTextbox13.Text = dt.Rows[0]["cardnumber"].ToString();
                    bunifuMaterialTextbox9.Text = dt.Rows[0]["burnplace"].ToString();
                    int gender = Convert.ToInt32( dt.Rows[0]["gender"] );
                    string qualfica = dt.Rows[0]["qualification"].ToString();
                    int nation = Convert.ToInt32(dt.Rows[0]["nationality"]);
                    bunifuMetroTextbox1.Text = dt.Rows[0]["notes"].ToString();
                    bunifuMaterialTextbox7.Text = dt.Rows[0]["enfirst"].ToString();
                    bunifuMaterialTextbox6.Text = dt.Rows[0]["ensecond"].ToString();
                    bunifuMaterialTextbox5.Text = dt.Rows[0]["enthird"].ToString();
                    bunifuMaterialTextbox8.Text = dt.Rows[0]["enfourth"].ToString();
                    bunifuMaterialTextbox1.Text = dt.Rows[0]["arfirst"].ToString();
                    bunifuMaterialTextbox2.Text = dt.Rows[0]["arsecond"].ToString();
                    bunifuMaterialTextbox3.Text = dt.Rows[0]["arthird"].ToString();
                    bunifuMaterialTextbox4.Text = dt.Rows[0]["arfoutrh"].ToString();


                    if (gender == 1)
                        radioButton1.Checked = true;

                    if (gender == 0)
                        radioButton2.Checked = true;


                    nationality.SelectedValue = nation;
                    comboBox1.Text = qualfica;
                }
                
                    
                //string sqlstr2 = "select * from STUDENTS where [picture] is not null";
                //DataTable dt2 = new DataTable();
                //dt2 = dconn.GetTable(sqlstr2);

                //if (dt2.Rows.Count > 0)
                //{
                //    Console.WriteLine("hello");
                //    byte[] b = (byte[])dt2.Rows[0]["picture"];
                //    MemoryStream ms = new MemoryStream(b);
                //    pictureBox2.Image = Image.FromStream(ms);
                //}

            }

            catch (Exception e) {
            

            }


        }


        public void update1() {

            int gender = 1;

            if (radioButton1.Checked == true) { gender = 1; }
            else if (radioButton2.Checked == true) { gender = 0; }

            string sql =
                     "UPDATE STUDENTS SET [burndate] = ' " + "1997-04-03 ' " +
                     " ,[phonenumber] = ' " + bunifuMaterialTextbox11.Text + "' " +
                     " ,[cardnumber] = " + bunifuMaterialTextbox13.Text +
                     " ,[burnplace] = ' " + bunifuMaterialTextbox9.Text + "' " +
                     " ,[gender] =" + gender +
                     " ,[qualification] = ' " + comboBox1.SelectedText + "' " +
                     " ,[nationality] =" + nationality.SelectedValue+
                     " ,[notes] = ' " + bunifuMetroTextbox1.Text + "' " +
                     " ,[picture] =  (SELECT * FROM OPENROWSET(BULK N'" + filePath + "', SINGLE_BLOB) AS CategoryImage)" +
                     " ,[enfirst] = ' " + bunifuMaterialTextbox7.Text + "' " +
                     " ,[ensecond] = ' " + bunifuMaterialTextbox6.Text + "' " +
                     " ,[enthird] = ' " + bunifuMaterialTextbox5.Text + "' " +
                     " ,[enfourth] =  ' " + bunifuMaterialTextbox8.Text + "' " +
                     " ,[arfirst] =  ' " + bunifuMaterialTextbox1.Text + "' " +
                     " ,[arsecond] =  ' " + bunifuMaterialTextbox2.Text + "' " +
                     " ,[arthird] =  ' " + bunifuMaterialTextbox3.Text + "' " +
                     " ,[arfoutrh] = ' " + bunifuMaterialTextbox4.Text + "' " +
                     "WHERE id = " + pk + ";";

            dconn.ExecuteAnyQurey(sql);
        
        
        }

        public void update2() {

            int gender = 1;

            if (radioButton1.Checked == true) { gender = 1; }
            else if (radioButton2.Checked == true) { gender = 0; }

            string sql =
                "UPDATE STUDENTS SET [burndate] = ' " + "1997-04-03 ' " +
                " ,[phonenumber] = ' " + bunifuMaterialTextbox11.Text + "' " +
                " ,[cardnumber] = " + bunifuMaterialTextbox13.Text +
                " ,[burnplace] = ' " + bunifuMaterialTextbox9.Text + "' " +
                " ,[gender] =" + gender +
                " ,[qualification] = ' " + comboBox1.SelectedText + "' " +
                " ,[nationality] =" + nationality.SelectedValue +
                " ,[notes] = ' " + bunifuMetroTextbox1.Text + "' " +

                " ,[enfirst] = ' " + bunifuMaterialTextbox7.Text + "' " +
                " ,[ensecond] = ' " + bunifuMaterialTextbox6.Text + "' " +
                " ,[enthird] = ' " + bunifuMaterialTextbox5.Text + "' " +
                " ,[enfourth] =  ' " + bunifuMaterialTextbox8.Text + "' " +
                " ,[arfirst] =  ' " + bunifuMaterialTextbox1.Text + "' " +
                " ,[arsecond] =  ' " + bunifuMaterialTextbox2.Text + "' " +
                " ,[arthird] =  ' " + bunifuMaterialTextbox3.Text + "' " +
                " ,[arfoutrh] = ' " + bunifuMaterialTextbox4.Text + "' " +
                "WHERE id = " + pk + ";";

            dconn.ExecuteAnyQurey(sql);
        
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            try
            {

                //string sqlstr2 = "select * from STUDENTS where [picture] is not null and id= " + pk;
                //    DataTable dt2 = new DataTable();
                //    dt2 = dconn.GetTable(sqlstr2);

                //    if (dt2.Rows.Count > 0)
                //    {


                int check;
                        if (filePath != "")
                        {


                            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "" &&
                    bunifuMaterialTextbox3.Text != "" && bunifuMaterialTextbox4.Text != "" &&
                    bunifuMaterialTextbox5.Text != "" && bunifuMaterialTextbox6.Text != "" &&
                    bunifuMaterialTextbox7.Text != "" && bunifuMaterialTextbox8.Text != "" &&
                    bunifuMaterialTextbox9.Text != "" &&
                    bunifuMaterialTextbox11.Text != "" && bunifuMaterialTextbox13.Text != "" 
                     &&(radioButton1.Checked == true || radioButton2.Checked == true))
                
                            {

                    if (!int.TryParse(bunifuMaterialTextbox1.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox2.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox3.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox4.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox5.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox6.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox7.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox8.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox9.Text, out check)
                        && int.TryParse(bunifuMaterialTextbox11.Text, out check)
                        && int.TryParse(bunifuMaterialTextbox13.Text, out check)
                       )
                    
                    {

                            update1();
                    }
                    else
                        MessageBox.Show("تم إدخال بيانات خاطئة تحقق من صحة البيانات المدخلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else
                                MessageBox.Show("لم تكمل إدخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        
                  
                        
                        else
                        {  
                            
                            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "" &&
                    bunifuMaterialTextbox3.Text != "" && bunifuMaterialTextbox4.Text != "" &&
                    bunifuMaterialTextbox5.Text != "" && bunifuMaterialTextbox6.Text != "" &&
                    bunifuMaterialTextbox7.Text != "" && bunifuMaterialTextbox8.Text != "" &&
                    bunifuMaterialTextbox9.Text != "" &&
                    bunifuMaterialTextbox11.Text != "" && bunifuMaterialTextbox13.Text != ""
                    &&(radioButton1.Checked == true || radioButton2.Checked == true))
                
                    
                 {

                    if (!int.TryParse(bunifuMaterialTextbox1.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox2.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox3.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox4.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox5.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox6.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox7.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox8.Text, out check)
                        && !int.TryParse(bunifuMaterialTextbox9.Text, out check)
                        && int.TryParse(bunifuMaterialTextbox11.Text, out check)
                        && int.TryParse(bunifuMaterialTextbox13.Text, out check)
                       )
                   
                    {
                            update2(); 
                    }
                      
                    else
                        MessageBox.Show("تم إدخال بيانات خاطئة تحقق من صحة البيانات المدخلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                    MessageBox.Show("لم تكمل إدخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                           
            }
              
           

            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            //if (pk > 1003)
            //{
            //    pk--;
            //    refreshing();
            //}
            
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //if (pk < max)
            //{
            //    pk++;
            //    refreshing();
            //}

        }

        //public void refreshdata()
        //{
        //    DataRow dr;

        //    String sql = "select * from STUDENTS ";

        //    DataTable dt = new DataTable();
        //    dt = dconn.GetTable(sql);

        //    dr = dt.NewRow();
        //    //dr.ItemArray = new object[] { 0, "اختر" };
        //    dt.Rows.InsertAt(dr, 0);

        //    comboBox1.ValueMember = "id";

        //    comboBox1.DisplayMember = "id";

        //    comboBox1.DataSource = dt;

        //    comboBox2.ValueMember = "enfirst";

        //    comboBox2.DisplayMember = "enfirst";

        //    comboBox2.DataSource = dt;

        //    dconn.close();
        //}    


        private void edite_student_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg|jpeg|*.jpeg|png|*.png|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);


                filePath = openFileDialog1.FileName;
                filename = Path.GetFileName(filePath);
            } 
        }

        

       
       

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox1.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox1.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox4.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox4.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox3.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox3.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox7.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox7.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox6.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox6.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox5.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox5.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox8.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox8.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox9.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox9.LineFocusedColor = Color.Red;
        }

     

        private void bunifuMaterialTextbox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bunifuMaterialTextbox11.Text.Length <= 8 || e.KeyChar == (char)Keys.Back)
                lableError.Text = dconn.CheckNumber(e);

            else if (bunifuMaterialTextbox11.Text.Length > 8)
            {
                e.Handled = true;
                lableError.Text = "رقم التلفون يجب أن لا يكون أكبر من 9 أرقام";
            }

            if (lableError.Text == "")
                bunifuMaterialTextbox11.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox11.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dconn.CheckNumber(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox13.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox13.LineFocusedColor = Color.Red;
        }
    }
}
