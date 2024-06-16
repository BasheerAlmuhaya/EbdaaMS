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
    public partial class editor : Form
    {
        dcon dcon1 = new dcon();
        DataTable dt1 = new DataTable();
        public editor(String s)
        {
            InitializeComponent();
            textidc.Text = s;
            string sql5 = "select * from courses where id = " + Int32.Parse(textidc.Text)+"";
            SqlCommand  scm= dcon1.edite_table(sql5);

            SqlDataReader sdr = scm.ExecuteReader();
            while (sdr.Read())
            {
                texttypec.Text = sdr[2].ToString();
                textnamec.Text = sdr[1].ToString();
                texthoursec.Text =sdr[5].ToString();
                textnotes.Text = sdr[6].ToString();

            }

            sdr.Close();


        }

      

        private void saveec_Click(object sender, EventArgs e)
        {

            string sql5 = "update  courses set name = '" + textidc.Text + "', type ='" + texttypec.Text + "  ' ,  hourse = " + Int32.Parse(texthoursec.Text) + " , notes= ' " + textnotes.Text +" ' where id =" +  Int32.Parse( textidc.Text) + " ";
            dcon1.ExecuteAnyQurey(sql5);

           

        }

        private void cancelc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textidc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Ebda_aDataSet.DEGREE' table. You can move, or remove it, as needed.
            this.dEGREETableAdapter.Fill(this._Ebda_aDataSet.DEGREE);
            // TODO: This line of code loads data into the '_Ebda_aDataSet.DEPLOMS' table. You can move, or remove it, as needed.
            this.dEPLOMSTableAdapter.Fill(this._Ebda_aDataSet.DEPLOMS);
            // TODO: This line of code loads data into the '_Ebda_aDataSet.COURSES' table. You can move, or remove it, as needed.
            this.cOURSESTableAdapter.Fill(this._Ebda_aDataSet.COURSES);

        }
    }
}
