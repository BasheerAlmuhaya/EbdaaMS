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
    public partial class CertificateFormcs : Form
    {
        public CertificateFormcs()
        {
            InitializeComponent();
        }

        private HelpProvider hlpProvider;



        private void CreateHelpProvider()
        {

            hlpProvider = new System.Windows.Forms.HelpProvider();

            hlpProvider.SetShowHelp(altoTextBox2, true);

            hlpProvider.SetHelpString(altoTextBox2, "Enter a valid text here.");



            hlpProvider.SetShowHelp(altoTextBox2, true);

            hlpProvider.SetHelpString(altoTextBox2, "Click this button.");



            // Help file

            hlpProvider.HelpNamespace = "C:\\Users\\Awsan\\Desktop\\help.docx";



            hlpProvider.SetHelpNavigator(altoTextBox2, HelpNavigator.TableOfContents);



        }

        private void altoTextBox2_Click(object sender, EventArgs e)
        {
            CreateHelpProvider();
        }
    }
}
