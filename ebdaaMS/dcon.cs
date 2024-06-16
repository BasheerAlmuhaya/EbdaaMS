using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ebdaaMS
{
   public class dcon
    {
       private  SqlConnection con;
       private  SqlCommand cd = new SqlCommand();
       private SqlDataAdapter adapter;
       private  DataTable dtaple = new DataTable();
      // private SqlDataReader sdr;

       
       
       public dcon()
       {

           con = new SqlConnection("server=" + ebdaaMS.Properties.Settings.Default.Server_name + ";Database=Ebda'a;integrated security=true;");//.\AWSANSERVER1
       }



       public SqlConnection getConn() { return con; }

      public   void open()
       {
           if (con.State != ConnectionState.Open)
           {
               con.Open();
           }
       }

       public   void close()
       {
           if (con.State != ConnectionState.Closed)
           {
               con.Close();
           }

       }

       public SqlCommand edite_table(string s)
       {
           con.Open();

          cd= new SqlCommand(s, con);

          
          return cd;

       }

  // send to this function the tabel you will appear in datagridview 
       public DataTable GetTable(string sql)
       {
           try
             {
               open();
               adapter = new SqlDataAdapter(sql, con);
               DataTable table = new DataTable();
               adapter.Fill(table);
               close();
               return table;
           }

           catch (Exception e)
           {
               MessageBox.Show(e.Message);
               return null;
           }
       }

       public  int  ExecuteAnyQurey(string sql) 
       {
           try
           {
               open();
               cd = new SqlCommand(sql, con);
               cd.ExecuteNonQuery();
               if (sql.Contains("max") || sql.Contains("count"))
               {
                   var max = cd.ExecuteScalar();
                   return Int32.Parse(max.ToString());
               }


               MessageBox.Show("تمت العملية بنجاح ");


               close();


           }

           catch (Exception e)
           {
               MessageBox.Show(e.Message);
               
           }


           return -1;
       }


       public int ExecuteAnyQurey2(string sql)
       {
           try
           {
               open();
               cd = new SqlCommand(sql, con);
               cd.ExecuteNonQuery();
               if (sql.Contains("max"))
               {
                   var max = cd.ExecuteScalar();


                   return Int32.Parse(max.ToString());

               }


             //  MessageBox.Show("تمت العملية بنجاح ");


               close();


           }

           catch (Exception e)
           {
               MessageBox.Show(e.Message);

           }


           return -1;
       }


       public string CheckNumber(KeyPressEventArgs e)
       {

           string text;

           if (e.KeyChar=='0'||e.KeyChar=='1'||e.KeyChar=='2'||e.KeyChar=='3'||
               e.KeyChar=='4'||e.KeyChar=='5'||e.KeyChar=='6'||e.KeyChar=='7'||
               e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == (char)Keys.Back)
           
           {
           
               e.Handled = false;
               text = "";
               return text; 
               
           }
               
           else
           {
               e.Handled = true;

               text = "هذا الحقل من المفترض أن لا يحتوي على حروف ";
               return text; 
               
           }

       }

       public string CheckText(KeyPressEventArgs e)
       {

           string text;

           if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' ||
               e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' ||
               e.KeyChar == '8' || e.KeyChar == '9')
           {
               e.Handled = true;

               text = "هذا الحقل من المفترض أن لا يحتوي على أرقام ";
               return text;

           }

           else
           {
               e.Handled = false;
               text = "";
               return text;

           }

       }
       }
    }

