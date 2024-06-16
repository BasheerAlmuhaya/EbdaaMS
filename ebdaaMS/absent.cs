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
    public partial class absent : UserControl
    {

        string sql = "";
        dcon dconn = new dcon();
        DataTable dt = new DataTable();
       

        public absent()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            refreshdata();

        }

        public void refreshdata()
        {


            String sql = "select * from ABSENCE";
            
            DataTable dt = new DataTable();
            dt = dconn.GetTable(sql);

            dataGridView1.DataSource = dt;
          

            dconn.close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new addabsence().ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            new addabsence().ShowDialog();
        }

             

        
    }
}
