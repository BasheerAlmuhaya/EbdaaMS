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
    public partial class ADDC : Form
    {
        dcon dcon1 = new dcon();
       
        public ADDC()
        {
            InitializeComponent();
        }

     

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void ADDC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Ebda_aDataSet.DEPLOMS' table. You can move, or remove it, as needed.
            this.dEPLOMSTableAdapter.Fill(this._Ebda_aDataSet.DEPLOMS);
          this.cOURSESTableAdapter.Fill(this._Ebda_aDataSet.COURSES);
          //   // TODO: This line of code loads data into the '_Ebda_aDataSet.COURSES' table. You can move, or remove it, as needed.
            

        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
       
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savec_Click(object sender, EventArgs e)
        {
            string sql4= "select isnull( max(id),0) from courses ";
            int pk = dcon1.ExecuteAnyQurey(sql4)+1;
           sql4  = "insert into COURSES  (id , name , type , deplomeid , requires , hourse , notes ) values ( " +
                     pk+ " , '" + textnamec.Text + " ' , ' " + texttypec.Text + "'," +  Convert.ToInt32( deplomeidComboBox.SelectedValue) + "," +
                     Convert.ToInt32( requiresComboBox.SelectedValue) + ", ' " + texthoursec.Text + "' ,' " + textnotes.Text + " '  ) ";
            dcon1.ExecuteAnyQurey(sql4);
        }

   
      
    }
}
