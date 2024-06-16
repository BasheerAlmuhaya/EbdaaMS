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
using System.Data.OleDb;


namespace ebdaaMS
{
    public partial class Form1 : Form
    {

        private static SqlConnection cn;
        private static SqlCommand cd;
        private static SqlDataReader dr;
       // private static DataSet ds;


        public Form1()
        {
          
            InitializeComponent();
          //  panel1.BackColor = Color.FromArgb(125, 31, 58, 87);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "أدخل الأسم";
            //textBox2.Text = "أدخل كلمة السر";
            //textBox1.ForeColor = Color.LightGray;
            //textBox1.ForeColor = Color.LightGray;
            comboBox1.SelectedItem = "مسؤول";
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cn = new SqlConnection(@"Data Source=DESKTOP-7FGHCAF;Initial Catalog=Ebda'a;Integrated Security=True");
                          cn.Open();
///////////////////////// admins////////////////////////////////////////
                                        

            ///////////////////////// admins////////////////////////////////////////
                        if (comboBox1.SelectedItem.Equals("مسؤول"))
                        {


                            cd = new SqlCommand("select * from users where privilige='مسؤول' ", cn);


                            dr = cd.ExecuteReader();

                            while (dr.Read())
                            {
                                if (textBox1.Text.Equals(dr["name"]))
                                {
                                    if (textBox2.Text.Equals(dr["password"]))
                                    {
                                        MessageBox.Show("تم الاتصال بنجاح ", "con", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        string s = textBox1.Text;




                                        ebdaaMS.Properties.Settings.Default.current_user = s;

                                        dr.Close();
                                        cd.ExecuteNonQuery();


                                       
                                        new UserForm().Show();
                                        this.Hide();
                                        break;

                                    }
                                    else
                                    {
                                        MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                //else
                                //    MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            dr.Close();

                        }



            //////////////////////////////////////////////////////////////



                        //////////////////// users////////////////////////////////

                        if (comboBox1.SelectedItem.Equals("مستخدم"))
                        {
                            cd = new SqlCommand("select * from users where privilige='مستخدم' ", cn);
                            dr = cd.ExecuteReader();
                            while (dr.Read())
                            {
                                if (textBox1.Text.Equals(dr["name"]))
                                {
                                    if (textBox2.Text.Equals(dr["password"]))
                                    {
                                        MessageBox.Show("تم الاتصال بنجاح ", "con", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        string s = textBox1.Text;


                                        ebdaaMS.Properties.Settings.Default.current_user = s;


                                      
                                        new UserForm().Show();
                                        this.Hide();
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                    MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            dr.Close();

                        }
                        /////////////////////////////////////


            cn.Close();

///////////////////////////





            }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //if (textBox1.Text == "أدخل الإسم")
            //{
            //    textBox1.Text = "";

            //}

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    //textBox1.Text = "أدخل الإسم";
            //    textBox1.ForeColor = Color.LightGray;
            //}
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //if (textBox2.Text == "أدخل كلمة السر")
            //{
            //    textBox2.Text = "";
            //    textBox2.isPassword = true;
            //}

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    textBox2.isPassword = false;
            //    //textBox2.Text = "أدخل كلمة السر";
            //    textBox2.ForeColor = Color.LightGray;
            //}
        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_OnValueChanged(object sender, EventArgs e)
        {
            //if (textBox2.Text != "")

            //    textBox2.isPassword = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=" + ebdaaMS.Properties.Settings.Default.Server_name+ ";Initial Catalog=Ebda'a;Integrated Security=True");
            cn.Open();
            ///////////////////////// admins////////////////////////////////////////


            ///////////////////////// admins////////////////////////////////////////
            if (comboBox1.SelectedItem.Equals("مسؤول"))
            {


                cd = new SqlCommand("select * from users where privilige='مسؤول' ", cn);


                dr = cd.ExecuteReader();

                while (dr.Read())
                {
                    if (textBox1.Text.Equals(dr["name"]))
                    {
                        if (textBox2.Text.Equals(dr["password"]))
                        {
                            MessageBox.Show("تم الاتصال بنجاح ", "con", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string s = textBox1.Text;




                            ebdaaMS.Properties.Settings.Default.current_user = s;

                            dr.Close();
                            cd.ExecuteNonQuery();



                            new UserForm().Show();
                            this.Hide();
                            break;

                        }
                        else
                        {
                            MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dr.Close();

            }



            //////////////////////////////////////////////////////////////



            //////////////////// users////////////////////////////////

            if (comboBox1.SelectedItem.Equals("مستخدم"))
            {
                cd = new SqlCommand("select * from users where privilige='مستخدم' ", cn);
                dr = cd.ExecuteReader();
                while (dr.Read())
                {
                    if (textBox1.Text.Equals(dr["name"]))
                    {
                        if (textBox2.Text.Equals(dr["password"]))
                        {
                            MessageBox.Show("تم الاتصال بنجاح ", "con", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string s = textBox1.Text;


                            ebdaaMS.Properties.Settings.Default.current_user = s;



                            new UserForm().Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح", "notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dr.Close();

            }
            /////////////////////////////////////


            cn.Close();

            ///////////////////////////


        }

        private void textBox2_OnValueChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.isPassword = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    

}




