using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Management.Instrumentation;

namespace WindowsFormsApp1
{
    internal class GlobalVar
    {
        public static string strPrice = "";
        public static int price_1 = 0;
        public static List<ArrayList> listCustomerOrder= new List<ArrayList>();
        public static string cusName = "";
        public static string cusContact = "";
        public static string strTotal = "";
        public static int beforeDiscount = 0;
        public static int afterdis = 0;
        public static string strA = "";
        public static int intA = 0;
      
        
        /// <summary>
        /// Connect to SQL database
        /// </summary>
        public static string strExamDBconnectionString = "";
        //public static string image_Dir = @"C:\Users\iSpan\Desktop\middle\midexam\dessert\";
        public static string image_Dir = @"C:\Users\iSpan\Desktop\mid\dessert\";
        //C:\Users\iSpan\Desktop\middle\midexam\dessert

        public static string ID = "";
        public static string Name = "";
        public static string ContactNumber = "";
        public static string Country = "";
        public static string Gender = "";
        public static string MailBOx = "";
        public static DateTime Birth = DateTime.Now ;
        public static string Point = "";

        /// <summary>
        /// Dessert Order
        /// </summary>
        public static int price = 0;
        public static string strDessertName = "";
        public static int price01 = 0;
        public static string strDessertName01 = "";
        public static int price02 = 0;
        public static string strDessertName02 = "";
        public static int price03 = 0;
        public static string strDessertName03 = "";
        public static int price04 = 0;
        public static string strDessertName04 = "";
        public static int price05 = 0;
        public static string strDessertName05 = "";
        public static int price06 = 0;
        public static string strDessertName06 = "";
        public static int price07 = 0;
        public static string strDessertName07 = "";
        public static int price08 = 0;
        public static string strDessertName08 = "";


        public static bool isValid(string EmployeeName, string Password)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            bool isValid = false;
            //string strLogin = @"select * from Employee where EmployeeName = '" + EmployeeName + "' and Password = '" + Password + "' ";
            string strLogin = "select * from Employee where EmployeeName = @newName and Password = @newPass;";
            SqlCommand cmd = new SqlCommand(strLogin, con);
            cmd.Parameters.AddWithValue("@newName", EmployeeName);
            cmd.Parameters.AddWithValue("@newPass", Password);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.Read() == true)
            //{

            //}

            

            if(dt.Rows.Count > 0)
            {
                isValid = true;
                jobTitle = dt.Rows[0]["JobTitle"].ToString();
                employeeName = dt.Rows[0]["EmployeeName"].ToString();
                employeeID = dt.Rows[0]["EmployeeID"].ToString();
            }
            con.Close();
            return isValid;
        }

        public static string JTitle;

        public static string jobTitle
        {
            get { return JTitle; }
            private set { JTitle = value; }
        }

        public static string EName;

        public static string employeeName
        {
            get { return EName; }
            private set { EName = value; }
        }

        public static string EID;

        public static string employeeID
        {
            get { return EID; }
            private set { EID = value; }
        }

        public static string authorization = "";

        public static int Sql(string qry, Hashtable ht)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.Add(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }

        //for loading database
        public static void loadDate(string qry, DataGridView dgv, ListBox lb)
        {

            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNum = ((DataGridViewColumn)lb.Items[i]).Name;
                    dgv.Columns[colNum].DataPropertyName = dt.Columns[i].ToString();
                }
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }

        public static void BlurBackGround(Form model)
        {
            Form BackGround = new Form();
            using (model)
            {
                BackGround.StartPosition = FormStartPosition.Manual;
                BackGround.FormBorderStyle = FormBorderStyle.None;
                BackGround.Opacity = 0.5d;
                BackGround.BackColor = Color.Black;
                BackGround.Size = FormPOS.Instance1.Size;
                BackGround.Location = FormPOS.Instance1.Location;
                BackGround.ShowInTaskbar = false;
                BackGround.Show();
                model.Owner = BackGround;
                model.ShowDialog(BackGround);
                BackGround.Dispose();
            }
        }
    }
}
