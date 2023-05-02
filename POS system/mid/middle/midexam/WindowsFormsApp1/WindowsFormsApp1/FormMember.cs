using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class FormMember : Form
    {
        List<int> searchID = new List<int>();
        public FormMember()
        {
            InitializeComponent();
        }
        private void FormMember_Load(object sender, EventArgs e)
        {
            generateC_Info();

            cbFilter.Items.Add("NAME");
            cbFilter.Items.Add("[CONTACT NUMBER]");
            cbFilter.Items.Add("COUNTRY");
            cbFilter.Items.Add("GENDER");
            cbFilter.Items.Add("MAILBOX");
            cbFilter.SelectedIndex = 0;
        }

        void generateC_Info()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            string strField = "select ID, NAME, [CONTACT NUMBER], COUNTRY, GENDER, MAILBOX, BIRTH, POINT from MM;";
            SqlCommand cmd = new SqlCommand(strField, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvCustomerInfo.DataSource = dt;
            }


        }

        private void dgvCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectID = dgvCustomerInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                if (selectID > 0)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                    con.Open();
                    string strID = "select * from MM where ID = @selectID ";
                    SqlCommand cmd = new SqlCommand(strID, con);
                    cmd.Parameters.AddWithValue("@selectID", selectID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        GlobalVar.ID = reader["ID"].ToString();
                        GlobalVar.Name = reader["Name"].ToString();
                        GlobalVar.ContactNumber = reader["CONTACT NUMBER"].ToString();
                        GlobalVar.Country = reader["COUNTRY"].ToString();
                        GlobalVar.Gender = reader["GENDER"].ToString();
                        GlobalVar.Birth = Convert.ToDateTime(reader["BIRTH"]);
                        GlobalVar.MailBOx = reader["MAILBOX"].ToString();
                        GlobalVar.Point = reader["POINT"].ToString();
                    }

                    reader.Close();
                    con.Close();

                }
            }
        }

        //void clearRecord()
        //{
        //    labelID.Text = "";
        //    txtName.Clear();
        //    txtContact.Clear();
        //    txtCountry.Clear();
        //    cbGender.SelectedIndex = 0;
        //    txtMail.Clear();
        //    dtpBirth.Value = DateTime.Now;
        //    txtPoint.Clear();
        //}

        private void lbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSearch.SelectedIndex >= 0)
            {
                int findId = searchID[lbSearch.SelectedIndex];
                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strSearch = "select * from MM where ID = @searchID;";
                SqlCommand cmd = new SqlCommand(strSearch, con);
                cmd.Parameters.AddWithValue("@searchID", findId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    GlobalVar.ID = reader["ID"].ToString();
                    GlobalVar.Name = reader["NAME"].ToString();
                    GlobalVar.ContactNumber = reader["[CONTACT NUMBER]"].ToString();
                    GlobalVar.Country = reader["COUNTRY"].ToString();
                    GlobalVar.Gender = reader["GENDER"].ToString();
                    GlobalVar.MailBOx = reader["MAILBOX"].ToString();
                    GlobalVar.Birth = Convert.ToDateTime(reader["BIRTH"]);
                    GlobalVar.Point = reader["POINT"].ToString();
                }

                reader.Close();
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text != "")
            {
                lbSearch.Items.Clear();
                searchID.Clear();
                string search = cbFilter.SelectedItem.ToString();
                
                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strSearch = "select * from MM where " + search + " like @searchKeyword and BIRTH >= @birthStart and BIRTH <= @birthEnd ";
                SqlCommand cmd = new SqlCommand(strSearch, con);
                cmd.Parameters.AddWithValue("@searchKeyword", $"%{txtFilter.Text.Trim()}%");
                cmd.Parameters.AddWithValue("@birthStart", dtpStartD.Value);
                cmd.Parameters.AddWithValue("@birthEnd", dtpEndD.Value);

                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read() == true)
                {
                    searchID.Add((int)reader["ID"]);
                    lbSearch.Items.Add($@"{reader["ID"]} \NAME:{reader["NAME"]} \NUMBER:{reader["CONTACT NUMBER"]} \COUNTRY:{reader["COUNTRY"]} \GENDER:{reader["GENDER"]}");   // show listbox text
                    count++;
                }

                if (count == 0)
                {
                    MessageBox.Show("NOT FOUND");
                    //clearRecord();
                }
                reader.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("Please, Enter the KeyWord");
            }
        }

        private void btnMemberAdd_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            //con.Open();
            //string strRows = "insert into MM values (@newName, @newContact, @newCountry, @newGender, @newEMail, @newBirth, @newPoint)";
            //SqlCommand cmd = new SqlCommand(strRows, con);
            addMembercs addOne = new addMembercs();
            addOne.ShowDialog();
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            FormSearch formEdit = new FormSearch();
            formEdit.ShowDialog();
        }
    }
}
