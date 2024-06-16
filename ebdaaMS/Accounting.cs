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
    public partial class Accounting : Form
    {
        public Accounting( int a)
        {
            InitializeComponent();
            if (a == 1)
            {

                bunifuImageButton1_Click(null, null);

            }
            else
            {
                bunifuImageButton2_Click(null, null);


            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            student_aconncs1.Visible = false;
            tacher_conn1.Visible = true;
            bunifuImageButton2.BackColor = Color.White;
            bunifuImageButton1.BackColor = Color.Transparent;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            student_aconncs1.Visible = true;
            tacher_conn1.Visible = false;
            bunifuImageButton1.BackColor = Color.White;
            bunifuImageButton2.BackColor = Color.Transparent;

        }

        private void tacher_conn1_Load(object sender, EventArgs e)
        {

        }
    }
}
