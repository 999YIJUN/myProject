using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace WindowsFormsApp1
{
    public partial class FormCheckOut : Form
    { 
        public int amt;
        public int MainID = 0;
        
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {//Console.WriteLine(txtBillAmount.Text);
            int amt;
            int.TryParse(txtBillAmount.Text, out amt);
            int receipt;
            int.TryParse(txtReceived.Text, out receipt);

            int change = Math.Abs(amt - receipt);
            txtChange.Text = change.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            string qry = "update Orders set TotalPrice = @newPrice, Received = @newReceived, change = @newChange, status = 'paid' where OrderID = @newID;";


            Hashtable ht = new Hashtable();
            ht.Add("@newID", MainID);
            ht.Add("@newPrice", txtBillAmount.Text);
            ht.Add("@newReceived", txtReceived.Text);
            ht.Add("@newChange", txtChange.Text);
            

            if(GlobalVar.Sql(qry, ht) > 0)
            {
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Show("SAVED SUCCESSFULL");
                Close();
            }

            con.Close();
        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
            //Console.WriteLine(amt);
        }
    }
       
}
