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
    public partial class deplomsForm : Form
    {        
        int pk,myChoice;
        bool isadd;
       
        string sqlstr = "";
        dcon dconn = new dcon();
        
        public deplomsForm(int choice)
        {
            InitializeComponent();
            this.deplomscomboBox_Load();
            isadd = true;
            this.myChoice = choice;
            switch (choice)
            {
                case 1: { groupBox1.Visible = true; break; }//groupBox2.Visible = false; groupBox3.Visible = false; break; }
                case 3: { /*groupBox1.Visible = false; groupBox2.Visible = false;*/ groupBox3.Visible = true; break; }
                default: { /*groupBox1.Visible = false;*/ groupBox2.Visible = true; /*groupBox3.Visible = false;*/ break; }
            }
        }

        public deplomsForm(int choice,string id)
        {
            InitializeComponent();
            this.deplomscomboBox_Load();
            isadd = false;
            pk = int.Parse(id);
            this.myChoice = choice;
            myRefreshdeploms();
        }


        public void myRefreshdeploms()
        {
            try
            {
                DataTable dt = new DataTable();
                switch (myChoice)
                {
                    case 1:
                        {
                            groupBox1.Visible = true;
                            sqlstr = "select * from programs where id =" + pk + "";
                            dt = dconn.GetTable(sqlstr);
                            bunifuMaterialTextbox5.Text = dt.Rows[0]["name"].ToString();
                            break;
                        }
                    case 3:
                        {
                            groupBox3.Visible = true;
                            sqlstr = "select name,isnull(course,'-1')course,hours from levels where id =" + pk + "";
                            dt = dconn.GetTable(sqlstr);
                            bunifuMaterialTextbox1.Text = dt.Rows[0]["name"].ToString();
                            //if(!dt.Rows[0]["course"].Equals(null))
                            deplomcomboBox1.SelectedValue = dt.Rows[0]["course"].ToString();
                            numericUpDown1.Value = int.Parse(dt.Rows[0]["hours"].ToString());
                            break;
                        }
                    default:
                        {
                            groupBox2.Visible = true;
                            sqlstr = "select name,E_name,isnull(program,'-1')program from courses where id =" + pk + "";
                            dt = dconn.GetTable(sqlstr);
                            deplomsabunifuMaterialTextbox1.Text = dt.Rows[0]["name"].ToString();
                            deplomsabunifuMaterialTextbox2.Text = dt.Rows[0]["E_name"].ToString();
                            deplomcomboBox2.SelectedValue = dt.Rows[0]["program"].ToString();
                            break;
                        }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void deplomsaddFlatButton2_Click(object sender, EventArgs e)
        {
            switch (myChoice)
            {
                case 1:
                    {
                        if (isadd) addprogram();
                        else editprogram();
                        break;
                    }
                case 3:
                    {
                        if (isadd) addlevel();
                        else editlevel();
                        break;
                    }
                default:
                    {
                        if (isadd) addDeplom();
                        else editDeplom();
                        break;
                    }
            }
        }

        void addprogram()
        {
            try
            {
                sqlstr = "select isnull(max(id),0) from programs";
                pk = dconn.ExecuteAnyQurey(sqlstr) + 1;
                sqlstr = "insert into programs (id,name)" + "values(" + pk + ",'" +
                    bunifuMaterialTextbox5.Text + "')";
                dconn.ExecuteAnyQurey(sqlstr);
                MessageBox.Show("تمت الاضافة بنجاح");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void editprogram()
        {
            try
            {
                sqlstr = "update programs set name = '" + bunifuMaterialTextbox5.Text
                    + "' where id = " + pk + "";
                dconn.ExecuteAnyQurey(sqlstr);
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void addDeplom() {
            try
            {
            sqlstr = "select isnull(max(id),0) from courses";
            pk = dconn.ExecuteAnyQurey(sqlstr) + 1;
            string insert1 ;
            string insert2 ;
            if (deplomcomboBox2.SelectedItem == null)
            {
                insert1 = "insert into deploms (id,name,E_name)";
                insert2 = "";
            }
            else
            {
                insert1 = "insert into deploms (id,name,E_name,program)";
                insert2 = "," + deplomcomboBox2.SelectedValue.ToString();
            }
            sqlstr = insert1 + "values(" + pk + ",'" +
                deplomsabunifuMaterialTextbox1.Text + "','" + 
                deplomsabunifuMaterialTextbox2.Text + "'" + insert2 + ")";
            dconn.ExecuteAnyQurey(sqlstr);
            MessageBox.Show("تمت الاضافة بنجاح");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void editDeplom()
        {
            try
            {
            string value;
            if (deplomcomboBox2.SelectedItem == null) value = "";
            else value = ",program = " + deplomcomboBox2.SelectedValue.ToString();

            sqlstr = "update courses set name = '" + deplomsabunifuMaterialTextbox1.Text
                + "',E_name = '" + deplomsabunifuMaterialTextbox2.Text + "'"
                +value + " where id = " + pk + "";
            dconn.ExecuteAnyQurey(sqlstr);
            MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void addlevel()
        {
            try
            {
            sqlstr = "select isnull(max(id),0) from levels";
            pk = dconn.ExecuteAnyQurey(sqlstr) + 1;
            string insert1 ;
            string insert2 ;
            if (deplomcomboBox1.SelectedItem == null)
            {
                insert1 = "insert into levels (id,name,hours)";
                insert2 = "";
            }
            else
            {
                insert1 = "insert into levels (id,name,course,hours)";
                insert2 = "," + deplomcomboBox1.SelectedValue.ToString();
            }
            sqlstr = insert1 + "values(" + pk + ",'" +
                bunifuMaterialTextbox1.Text + "'" + insert2 +
                "," + numericUpDown1.Text + ")";
            dconn.ExecuteAnyQurey(sqlstr);
            MessageBox.Show("تمت الاضافة بنجاح");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void editlevel()
        {
            try
            {
            string value;
            if (deplomcomboBox1.SelectedItem == null) value = "";
            else value = ",course = " + deplomcomboBox1.SelectedValue.ToString();
            
            sqlstr = "update levels set name = '" + bunifuMaterialTextbox1.Text
                + "'"+ value
                + ",hours = " + numericUpDown1.Text
                + " where id = " + pk + "";
            dconn.ExecuteAnyQurey(sqlstr);
            MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void deplomsabunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deplomscomboBox_Load()
        {
            try
            {
                sqlstr = "select * from programs";
                deplomcomboBox2.DataSource = dconn.GetTable(sqlstr);
                deplomcomboBox2.DisplayMember = "name";
                deplomcomboBox2.ValueMember = "id";
                deplomcomboBox2.SelectedItem = null;

                sqlstr = "select * from courses";
                deplomcomboBox1.DataSource = dconn.GetTable(sqlstr);
                deplomcomboBox1.DisplayMember = "name";
                deplomcomboBox1.ValueMember = "id";
                deplomcomboBox1.SelectedItem = null;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }



    }
}
