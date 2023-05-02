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

namespace WindowsFormsApp1
{
    public partial class FormSearch : Form
    {
        
        
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

            cbGender.Items.Add("");
            cbGender.Items.Add("MALE");
            cbGender.Items.Add("FEMALE");
            cbGender.SelectedIndex = 0;
            //GlobalVar.ID = labelID_1.Text;
            //GlobalVar.Name = txtName_1.Text;
            //GlobalVar.ContactNumber = txtContact_1.Text;
            //GlobalVar.Country = txtCountry.Text;
            //GlobalVar.Gender = cbGender.Text;
            //GlobalVar.Birth = dtpBirth.Value;
            //GlobalVar.MailBOx = txtMail.Text;
            //GlobalVar.Point = txtPoint.Text;

            labelID.Text = GlobalVar.ID;
            txtName.Text = GlobalVar.Name;
            txtContact.Text = GlobalVar.ContactNumber;
            txtCountry.Text = GlobalVar.Country;
            cbGender.Text = GlobalVar.Gender;
            dtpBirth.Value = GlobalVar.Birth;
            txtMail.Text = GlobalVar.MailBOx;
            txtPoint.Text = GlobalVar.Point;
        }

        

       

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(labelID.Text, out intID);

            if((intID > 0 ) && (txtName.Text != "") && (txtContact.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strCorrect = "update MM set NAME=@newName,[CONTACT NUMBER]=@NewContact,COUNTRY=@newCountry,GENDER=@newGender,mailbox=@newMail,BIRTH=@newBirth,POINT=@newPoint where ID = @searchID;";
                SqlCommand cmd = new SqlCommand(strCorrect, con);
                cmd.Parameters.AddWithValue("@searchID", intID);
                cmd.Parameters.AddWithValue("@newName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@NewContact", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@newCountry", txtCountry.Text.Trim());
                cmd.Parameters.AddWithValue("@newGender", cbGender.Text);
                cmd.Parameters.AddWithValue("@newMail", txtMail.Text.Trim());
                cmd.Parameters.AddWithValue("@newBirth", dtpBirth.Value);
                int points = 0;
                Int32.TryParse(txtPoint.Text, out points);
                cmd.Parameters.AddWithValue("@newPoint", points);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Correct Information Complete");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(labelID.Text, out intID);

            if(intID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strDelete = "delete from MM where id = @deleteID ";
                SqlCommand cmd = new SqlCommand(strDelete, con);
                cmd.Parameters.AddWithValue("@deleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                clearRecord();
                MessageBox.Show("Delete Information Complete");
            }
        }

        void clearRecord()
        {
            labelID.Text = "";
            txtName.Clear();
            txtContact.Clear();
            txtCountry.Clear();
            cbGender.SelectedIndex = 0;
            txtMail.Clear();
            dtpBirth.Value = DateTime.Now;
            txtPoint.Clear();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
