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
    public partial class student_aconncs : UserControl
    {
        public student_aconncs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new add_stdent_aconn().Show();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            new edite_student_aconn().Show();
        }
    }
}
