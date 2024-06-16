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
    public partial class addabsence : Form
    {
        dcon dcon1 = new dcon();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public addabsence()
        {
            InitializeComponent();

        }

        public void refreshdata()
        {
            //get all students

            try
            {

                String sql = "select * from STUDENTS";


                dt = dcon1.GetTable(sql);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";

                sql = "select * from levels";


                dt2 = dcon1.GetTable(sql);
                
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";

            }

            catch (Exception ex)
            {

            }

        }
        private void tdeleteFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addabsence_Load(object sender, EventArgs e)
        {

        }
    }
}
