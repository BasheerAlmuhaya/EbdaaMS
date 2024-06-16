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
namespace ebdaaMS
{
    public partial class UserForm : Form
    {




        public UserForm()
        {




            InitializeComponent();

            label4.Text = ebdaaMS.Properties.Settings.Default.current_user;

            timer1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            DateTime d = DateTime.Now;
            DateTime t = DateTime.Now;


        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            absent1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {


            pictureBox9.Image = ebdaaMS.Properties.Resources.bt1_hover;
            //   label1.ForeColor = Color.(195,195,216);


            pictureBox9.Size = new Size(284, 66);
        }

        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox9.Image = ebdaaMS.Properties.Resources.active;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = ebdaaMS.Properties.Resources.bt1;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            userControlStudent1.Visible = true;
            reigestion1.Visible = false;
            course_diss1.Visible = false;
            absent1.Visible = false;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            System.Environment.Exit(1);
        }
        int click = 1;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                click = 1;
                pictureBox3.Image = ebdaaMS.Properties.Resources.icons8_Normal_Screen_100px;

            }
            else
            {




                this.WindowState = FormWindowState.Normal;
                click = 0;
                pictureBox3.Image = ebdaaMS.Properties.Resources.icons8_Full_Screen_100px;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            reigestion1.Visible = true;
            userControlStudent1.Visible = false;
            course_diss1.Visible = false;
            tUserControl11.Visible = false;
            absent1.Visible = false;
            deplomsUserControl11.Visible = false;

            ////////////////////////////////////// مفعله

            pictureBox11.Image = ebdaaMS.Properties.Resources.left;
            pictureBox23.Visible = true;
          
            pictureBox18.BackColor = Color.FromArgb(135, 146, 166);
            label15.BackColor = Color.FromArgb(135, 146, 166);


            //////////////////// غير مفعله

            pictureBox9.Image = pictureBox12.Image = pictureBox13.Image = ebdaaMS.Properties.Resources.bt3;
            pictureBox8.Image = pictureBox19.Image = ebdaaMS.Properties.Resources.bt2_hover;
            pictureBox22.BackColor=pictureBox15.BackColor = pictureBox14.BackColor = pictureBox1.BackColor = pictureBox15.BackColor = Color.FromArgb(31, 58, 87);

            label16.BackColor =label11.BackColor = label13.BackColor = label12.BackColor = label17.BackColor = Color.FromArgb(31, 58, 87);

            pictureBox6.Visible = pictureBox7.Visible = pictureBox6.Visible = pictureBox24.Visible = pictureBox25.Visible = false;

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {


            reigestion1.Visible = false;
            userControlStudent1.Visible = false;
            course_diss1.Visible = true;
            tUserControl11.Visible = false;
            absent1.Visible = false;
            deplomsUserControl11.Visible = false;

            ////////////////////////////////////// مفعله

            pictureBox13.Image = ebdaaMS.Properties.Resources.right;
            pictureBox24.Visible = true;
            pictureBox1.BackColor = Color.FromArgb(135, 146, 166);
            label16.BackColor = Color.FromArgb(135, 146, 166);


            //////////////////// غير مفعله

            pictureBox8.Image = pictureBox11.Image = pictureBox19.Image = ebdaaMS.Properties.Resources.bt2_hover;
            pictureBox12.Image = pictureBox9.Image = ebdaaMS.Properties.Resources.bt3;
            pictureBox22.BackColor = pictureBox14.BackColor = pictureBox15.BackColor = pictureBox16.BackColor = pictureBox18.BackColor = Color.FromArgb(31, 58, 87);
            label12.BackColor = label13.BackColor = label15.BackColor = label17.BackColor = Color.FromArgb(31, 58, 87);

            pictureBox5.Visible = pictureBox7.Visible = pictureBox23.Visible = pictureBox6.Visible = pictureBox25.Visible  = false;

        }

        private void st_aconnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Accounting(1).Show();
        }

        private void te_aconnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Accounting(2).Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            userControlStudent1.Visible = true;
            reigestion1.Visible = false;
            course_diss1.Visible = false;
            tUserControl11.Visible = false;
            absent1.Visible = false;
            deplomsUserControl11.Visible = false;
                ////////////////////////////////////// مفعله

            pictureBox9.Image = ebdaaMS.Properties.Resources.right;
            pictureBox6.Visible = true;
            pictureBox14.BackColor = Color.FromArgb(135, 146, 166);
            label11.BackColor = Color.FromArgb(135, 146, 166);


            //////////////////// غير مفعله

            pictureBox8.Image = pictureBox11.Image = pictureBox19.Image = ebdaaMS.Properties.Resources.bt2_hover;
             pictureBox13.Image  = ebdaaMS.Properties.Resources.bt3;
            pictureBox22.BackColor = pictureBox1.BackColor = pictureBox15.BackColor = pictureBox16.BackColor = pictureBox18.BackColor = Color.FromArgb(31, 58, 87);
            label16.BackColor =label12.BackColor = label13.BackColor =  label15.BackColor = label17.BackColor = Color.FromArgb(31, 58, 87);

            pictureBox5.Visible = pictureBox7.Visible = pictureBox23.Visible = pictureBox24.Visible = pictureBox25.Visible  = false;

        }

   

        private void label12_Click(object sender, EventArgs e)
        {

            userControlStudent1.Visible = false;
            reigestion1.Visible = false;
            course_diss1.Visible = false;
            tUserControl11.Visible = true;
            deplomsUserControl11.Visible = false;
            ////////////////////////////////////// مفعله

            pictureBox8.Image = ebdaaMS.Properties.Resources.left;
            pictureBox5.Visible = true;
            pictureBox15.BackColor = Color.FromArgb(135, 146, 166);
            label12.BackColor = Color.FromArgb(135, 146, 166);


            //////////////////// غير مفعله

            pictureBox9.Image = pictureBox12.Image = pictureBox13.Image = ebdaaMS.Properties.Resources.bt3;
           pictureBox11.Image = pictureBox19.Image = ebdaaMS.Properties.Resources.bt2_hover;
           pictureBox22.BackColor=pictureBox14.BackColor = pictureBox1.BackColor = pictureBox14.BackColor = pictureBox16.BackColor = pictureBox18.BackColor = Color.FromArgb(31, 58, 87);

           label11.BackColor = label13.BackColor = label15.BackColor = label16.BackColor = label17.BackColor = Color.FromArgb(31, 58, 87);

            pictureBox6.Visible = pictureBox23.Visible = pictureBox24.Visible = pictureBox7.Visible = pictureBox25.Visible = false;

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            userControlStudent1.Visible = false;
            reigestion1.Visible = false;
            course_diss1.Visible = false;
            tUserControl11.Visible = false;
            absent1.Visible = true;
            deplomsUserControl11.Visible = false;

            ////////////////////////////////////// مفعله

            pictureBox19.Image = ebdaaMS.Properties.Resources.left;
            pictureBox25.Visible = true;
            pictureBox22.BackColor = Color.FromArgb(135, 146, 166);
            label17.BackColor = Color.FromArgb(135, 146, 166);


            //////////////////// غير مفعله

            pictureBox9.Image = pictureBox12.Image = pictureBox13.Image = ebdaaMS.Properties.Resources.bt3;
            pictureBox11.Image = pictureBox8.Image = ebdaaMS.Properties.Resources.bt2_hover;
            pictureBox14.BackColor = pictureBox16.BackColor = pictureBox18.BackColor = Color.FromArgb(31, 58, 87);

            label16.BackColor=label11.BackColor = label13.BackColor = label15.BackColor = label12.BackColor = Color.FromArgb(31, 58, 87);

            pictureBox6.Visible = pictureBox7.Visible = pictureBox23.Visible = pictureBox24.Visible = pictureBox5.Visible = false;

        }

        private void tUserControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new FormCertificate().ShowDialog();

            }
            catch (Exception ex)
            {
                
              MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {



            ////////////////////////////////////// مفعله

            pictureBox9.Image = ebdaaMS.Properties.Resources.right;
          

            //////////////////// غير مفعله

            pictureBox8.Image = pictureBox11.Image  = ebdaaMS.Properties.Resources.bt2_hover;
            pictureBox12.Image = pictureBox13.Image = ebdaaMS.Properties.Resources.bt3;
            pictureBox14.BackColor=pictureBox15.BackColor = pictureBox16.BackColor = pictureBox18.BackColor = Color.FromArgb(31, 58, 87);
             label11.BackColor= label12.BackColor = label13.BackColor = label15.BackColor = label17.BackColor = Color.FromArgb(31, 58, 87);

            pictureBox5.Visible = pictureBox7.Visible = pictureBox23.Visible = pictureBox24.Visible = pictureBox25.Visible = pictureBox6.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            userControlStudent1.Visible = false;
            reigestion1.Visible = false;
            course_diss1.Visible = false;
            tUserControl11.Visible = false;
            absent1.Visible = false;
            deplomsUserControl11.Visible = true;

            ////////////////////////////////////// مفعله

            pictureBox12.Image = ebdaaMS.Properties.Resources.right;
            pictureBox7.Visible = true;
            pictureBox16.BackColor = Color.FromArgb(135, 146, 166);
            label13.BackColor = Color.FromArgb(135, 146, 166);


            //////////////////// غير مفعله

            pictureBox8.Image = pictureBox11.Image = pictureBox19.Image = ebdaaMS.Properties.Resources.bt2_hover;
            pictureBox9.Image=pictureBox13.Image = ebdaaMS.Properties.Resources.bt3;
            pictureBox22.BackColor = pictureBox1.BackColor = pictureBox15.BackColor = pictureBox14.BackColor = pictureBox18.BackColor = Color.FromArgb(31, 58, 87);
            label12.BackColor = label11.BackColor = label15.BackColor = label16.BackColor = label17.BackColor = Color.FromArgb(31, 58, 87);

            pictureBox5.Visible = pictureBox6.Visible = pictureBox23.Visible = pictureBox24.Visible = pictureBox25.Visible = false;


        }

      

        

        private void chsettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new setting().ShowDialog();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new help().ShowDialog();
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSupport().ShowDialog();
        }

    }
}
