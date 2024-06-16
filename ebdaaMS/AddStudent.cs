using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace ebdaaMS
{
    public partial class AddStudent : Form
    {
        dcon dcon1 = new dcon();
        DataTable dt = new DataTable();
        String sql="";
         

        string filename="" , filePath="" ;
        
        public AddStudent()
        {

            InitializeComponent();
           // lableError.Visible = false;
            getCountries();

        }

        public void getCountries() {

            try
            {

                sql = "select * from nationalaty";


                dt = dcon1.GetTable(sql);
                nationality.DataSource = dt;
                nationality.DisplayMember = "name";
                nationality.ValueMember = "id";

                nationality.Text = "YEMEN";
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{

                //    nationality.Items.Add(dt.Rows[i]["name"]);

                //}

               // dcon1.close();
            }

            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }

     

        private void burndateLabel_Click(object sender, EventArgs e)
        {

        }

        private void burndateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void phonenumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void phonenumberBunifuCustomTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardnumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void cardnumberBunifuCustomTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void burnplaceLabel_Click(object sender, EventArgs e)
        {

        }

        private void burnplaceBunifuCustomTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void qualificationLabel_Click(object sender, EventArgs e)
        {

        }

        private void qualificationBunifuCustomTextbox_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Ebda_aDataSet.NATIONALATY' table. You can move, or remove it, as needed.
          //  this.nATIONALATYTableAdapter.Fill(this._Ebda_aDataSet.NATIONALATY);
            // TODO: This line of code loads data into the '_Ebda_aDataSet.STUDENTS' table. You can move, or remove it, as needed.
           // this.sTUDENTSTableAdapter.Fill(this._Ebda_aDataSet.STUDENTS);

        }

        private void panel2_Click(object sender, EventArgs e)
        {

          
            
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {
            int check;
            lableError.Visible = false;
            if (int.TryParse(bunifuMaterialTextbox7.Text, out check))
            {
                lableError.Visible = true;
                lableError.Text = "هذا الحقل من المفترض أن لا يحتوي على أرقام ";
            }

            else

                lableError.Visible = false;
        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {
            int check;
            lableError.Visible = false;
            if (int.TryParse(bunifuMaterialTextbox9.Text, out check))
            {
                lableError.Visible = true;
                lableError.Text = "هذا الحقل من المفترض أن لا يحتوي على أرقام ";
            }

            else

                lableError.Visible = false;
        }

        private void bunifuMaterialTextbox11_OnValueChanged(object sender, EventArgs e)
        {
            
            //int check;
            //lableError.Visible = false;
            //if (!int.TryParse(bunifuMaterialTextbox11.Text, out check) && bunifuMaterialTextbox11.Text != "")
            //{
            //    lableError.Visible = true;
            //    lableError.Text = "هذا الحقل من المفترض أن لا يحتوي على حروف ";
            //}

            //else

            //    lableError.Visible = false;

            

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

       

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void nationality_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

       

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

  

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg|jpeg|*.jpeg|png|*.png|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                
                
                 filePath = openFileDialog1.FileName;


                 filename = Path.GetFileName(filePath);
                //FileStream fs = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
                //BinaryReader br = new BinaryReader(fs);
                //bytes = br.ReadBytes((Int32)fs.Length);
                //br.Close();
                //fs.Close();
            } 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void add1() {

            string c = ",";
            string s = "'";
            int gender=1 ;
            
            if (radioButton1.Checked == true) { gender = 1; }
            else if (radioButton2.Checked == true) { gender = 0; }

            string sql = " INSERT INTO STUDENTS " +
        "  ([burndate] ,[phonenumber] ,[cardnumber] ,[burnplace] ,[gender] ,[qualification],[nationality],[notes],[picture] " +
        ",[enfirst],[ensecond],[enthird],[enfourth],[arfirst],[arsecond],[arthird],[arfoutrh]) " +

          " VALUES ('1997-04-03'," + bunifuMaterialTextbox11.Text + c + bunifuMaterialTextbox13.Text + c + "'" + bunifuMaterialTextbox9.Text + "'" + c + gender +", " + s + comboBox1.SelectedItem + s + c + nationality.SelectedValue +",'none', (SELECT * FROM OPENROWSET(BULK N'" + filePath + "', SINGLE_BLOB) AS CategoryImage)" + "," +
          s + bunifuMaterialTextbox7.Text + s + c + s + bunifuMaterialTextbox6.Text + s + c + s + bunifuMaterialTextbox5.Text + s + c + s + bunifuMaterialTextbox8.Text + s + c + s + bunifuMaterialTextbox1.Text + s + c + s + bunifuMaterialTextbox2.Text + s + c + s + bunifuMaterialTextbox3.Text + s + c + s + bunifuMaterialTextbox4.Text + s + ")  ; ";
            dcon1.ExecuteAnyQurey(sql);

        
        }

        public void add2()
        {

            string c = ",";
            string s = "'";

            int gender = 1;

            if (radioButton1.Checked == true) { gender = 1; }
            else if (radioButton2.Checked == true) { gender = 0; }

            string sql = " INSERT INTO STUDENTS " +
        "  ([burndate] ,[phonenumber] ,[cardnumber] ,[burnplace] ,[gender] ,[qualification],[nationality],[notes] " +
        ",[enfirst],[ensecond],[enthird],[enfourth],[arfirst],[arsecond],[arthird],[arfoutrh]) " +

          " VALUES ('1997-04-03'," + bunifuMaterialTextbox11.Text + c + bunifuMaterialTextbox13.Text + c + "'" + bunifuMaterialTextbox9.Text + "'" + c + gender + ", " + s + comboBox1.SelectedText + s + c + nationality.SelectedValue + ",'none'" + c +
          s + bunifuMaterialTextbox7.Text + s + c + s + bunifuMaterialTextbox6.Text + s + c + s + bunifuMaterialTextbox5.Text + s + c + s + bunifuMaterialTextbox8.Text + s + c + s + bunifuMaterialTextbox1.Text + s + c + s + bunifuMaterialTextbox2.Text + s + c + s + bunifuMaterialTextbox3.Text + s + c + s + bunifuMaterialTextbox4.Text + s + ")  ; ";
            dcon1.ExecuteAnyQurey(sql);


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //string sql4 = "select isnull( max(id),0) from courses ";
            //int pk = dcon1.ExecuteAnyQurey(sql4) + 1;
            //sql4 = "insert into students  (id , arfirst , arsecond, arthird ,arfoutrh,enfirst,ensecond,enthird,enfourth,burnplace,burndate,qualification,nationality,phonenumber,cardnumber,notes ,gender ) values ( " +
            //       pk + " , '" + bunifuMaterialTextbox1.Text + " ' , ' " + bunifuMaterialTextbox2.Text + "',  '  " + bunifuMaterialTextbox3.Text + " ',' " + bunifuMaterialTextbox4.Text + " ',' " + bunifuMaterialTextbox5.Text + " ',' " + bunifuMaterialTextbox6.Text + " ', ' " + bunifuMaterialTextbox7.Text + " ',' " + bunifuMaterialTextbox8.Text + " ',' " + bunifuMaterialTextbox9.Text + " ',' " + bunifuMaterialTextbox10.Text + " ',' " + dateTimePicker1.Text.ToString() + " ', " + 5 + " ,' " + bunifuMaterialTextbox11.Text +"','"  + bunifuMaterialTextbox13.Text + " '  , '  " + bunifuMetroTextbox1.Text + "  ',   "+ 1 + "     )";
            //dcon1.ExecuteAnyQurey(sql4);


         //   string sql = " INSERT INTO STUDENTS " +
         //"  ([burndate] ,[phonenumber] ,[cardnumber] ,[burnplace] ,[gender] ,[qualification],[nationality] " +
         //",[enfirst],[ensecond],[enthird],[enfourth],[arfirst],[arsecond],[arthird],[arfoutrh]) " +
     
         //  " VALUES ('2019-04-03',735430734, 5012,'Taiz', 1, 'SecondaryShcool', 1," +
         //  " 'Ali','Ahmed','Hassan','Khaled','علي', 'أحمد', 'حسان','خالد')  ; " ;
         //   dcon1.ExecuteAnyQurey(sql);


            //Image img = pictureBox1.Image;
            //byte[] arr;
            //ImageConverter converter = new ImageConverter();
            //arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            try
            {

                int check;

                if (filePath != "")
                {
                    if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "" &&
                        bunifuMaterialTextbox3.Text != "" && bunifuMaterialTextbox4.Text != "" &&
                        bunifuMaterialTextbox5.Text != "" && bunifuMaterialTextbox6.Text != "" &&
                        bunifuMaterialTextbox7.Text != "" && bunifuMaterialTextbox8.Text != "" &&
                        bunifuMaterialTextbox9.Text != ""&&
                        bunifuMaterialTextbox11.Text != "" && bunifuMaterialTextbox13.Text != "" &&
                        (radioButton2.Checked == true || radioButton1.Checked == true))
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
                            add1();
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
                        bunifuMaterialTextbox9.Text != ""  &&
                        bunifuMaterialTextbox11.Text != "" && bunifuMaterialTextbox13.Text != "" &&
                        (radioButton1.Checked == true || radioButton2.Checked == true))
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
                            add2();
                        }

                        else
                            MessageBox.Show("تم إدخال بيانات خاطئة تحقق من صحة البيانات المدخلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                        MessageBox.Show("لم تكمل إدخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //SqlCommand cmd = new SqlCommand("INSERT INTO STUDENTS ([burndate] ,[phonenumber] ,[cardnumber] ,[burnplace] ,[gender] ,[qualification],[nationality],[picture],[enfirst],[ensecond],[enthird],[enfourth],[arfirst],[arsecond],[arthird],[arfoutrh]) VALUES(@burndate,@phonenumber,@cardnumber,@burnplace,@gender,@qualification,@nationality,@picture,@enfirst,@ensecond,@enthird,@enfourth,@arfirst,@arsecond,@arthird,@arfoutrh) ", dcon1.getConn());

            //cmd.Parameters.AddWithValue("@burndate", "'1997-04-03'");
            //cmd.Parameters.AddWithValue("@phonenumber", bunifuMaterialTextbox11.Text);
            //cmd.Parameters.AddWithValue("@cardnumber", bunifuMaterialTextbox13.Text);
            //cmd.Parameters.AddWithValue("@burnplace", bunifuMaterialTextbox9.Text);
            //cmd.Parameters.AddWithValue("@gender", "1");
            //cmd.Parameters.AddWithValue("@qualification", bunifuMaterialTextbox10.Text);
            //cmd.Parameters.AddWithValue("@nationality", "1");
            //cmd.Parameters.AddWithValue("@picture", bytes);
            //cmd.Parameters.AddWithValue("@enfirst", bunifuMaterialTextbox7.Text);
            //cmd.Parameters.AddWithValue("@ensecond", bunifuMaterialTextbox6.Text);
            //cmd.Parameters.AddWithValue("@enthird", bunifuMaterialTextbox5.Text);
            //cmd.Parameters.AddWithValue("@enfourth", bunifuMaterialTextbox8.Text);
            //cmd.Parameters.AddWithValue("@arfirst", bunifuMaterialTextbox1.Text);
            //cmd.Parameters.AddWithValue("@arsecond", bunifuMaterialTextbox2.Text);
            //cmd.Parameters.AddWithValue("@arthird", bunifuMaterialTextbox3.Text);
            //cmd.Parameters.AddWithValue("@arfoutrh", bunifuMaterialTextbox4.Text);

            //        dcon1.open();

            //cmd.ExecuteNonQuery();
            //        dcon1.close();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sTUDENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.sTUDENTSBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this._Ebda_aDataSet);

        }

        private void label19_Click(object sender, EventArgs e)
        {
            
        }

       

        private void bunifuMaterialTextbox11_KeyPress(object sender, KeyPressEventArgs e)
        {
           //lableError.Text = dcon1.CheckNumber(e); 

            if (bunifuMaterialTextbox11.Text.Length <= 8 || e.KeyChar == (char)Keys.Back)
                lableError.Text = dcon1.CheckNumber(e);

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
            lableError.Text = dcon1.CheckNumber(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox13.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox13.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);
            
            if (lableError.Text == "")
                bunifuMaterialTextbox1.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox1.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox2.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox2.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox3.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox3.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox4.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox4.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox7.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox7.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox6.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox6.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox5.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox5.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox8.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox8.LineFocusedColor = Color.Red;
        }

        private void bunifuMaterialTextbox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            lableError.Text = dcon1.CheckText(e);

            if (lableError.Text == "")
                bunifuMaterialTextbox9.LineFocusedColor = Color.Black;

            else
                bunifuMaterialTextbox9.LineFocusedColor = Color.Red;
        }

       
    }
}
