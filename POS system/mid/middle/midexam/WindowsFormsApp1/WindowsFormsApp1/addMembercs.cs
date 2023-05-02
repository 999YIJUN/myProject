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
    public partial class addMembercs : Form
    {
       

        public addMembercs()
        {
            InitializeComponent();
        }

        private void addMembercs_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("MALE");
            cbGender.Items.Add("FEMALE");
            cbGender.SelectedIndex = 0;
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strRows = "insert into MM values (@newName, @newContact, @newCountry, @newGender, @newEMail, @newBirth, @newPoint)";
                SqlCommand cmd = new SqlCommand(strRows, con);
                cmd.Parameters.AddWithValue("@newName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@newContact", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@newCountry", txtCountry.Text.Trim());
                cmd.Parameters.AddWithValue("@newGender", cbGender.Text);
                cmd.Parameters.AddWithValue("@newEMail", txtMail.Text.Trim());
                cmd.Parameters.AddWithValue("@newBirth", dtpBirth.Value);
                int intPoint = 0;
                Int32.TryParse(txtPoint.Text.Trim(), out intPoint);
                cmd.Parameters.AddWithValue("@newPoint", intPoint);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SUCCESSFUL");
            }
            else
            {
                MessageBox.Show("ENTER");
            }


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
