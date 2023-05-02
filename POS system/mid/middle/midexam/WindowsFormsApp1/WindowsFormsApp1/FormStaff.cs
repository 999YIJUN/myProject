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
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            //SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            //con.Open();
            string sql = "select * from Employee where EmployeeName like '%" + txtSearch.Text + "%' ";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvSID);
            lb.Items.Add(dgvJtitle);
            lb.Items.Add(dgvSName);
            lb.Items.Add(dgvSContact);
            lb.Items.Add(dgvSpassword);

            GlobalVar.loadDate(sql, dgvSInfo, lb);

            //con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }
        private void btnSAdd_Click(object sender, EventArgs e)
        {

            FormStaffAdd frmSAdd = new FormStaffAdd();
            frmSAdd.ShowDialog();
            getData();
        }

        private void dgvSInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSInfo.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FormStaffAdd frmSAdd = new FormStaffAdd();
                frmSAdd.id = Convert.ToInt32(dgvSInfo.CurrentRow.Cells["dgvSID"].Value);
                frmSAdd.cbJTitle.Text = Convert.ToString(dgvSInfo.CurrentRow.Cells["dgvJtitle"].Value);
                frmSAdd.txtName.Text = Convert.ToString(dgvSInfo.CurrentRow.Cells["dgvSName"].Value);
                frmSAdd.txtContact.Text = Convert.ToString(dgvSInfo.CurrentRow.Cells["dgvSContact"].Value);
                frmSAdd.txtPassword.Text = Convert.ToString(dgvSInfo.CurrentRow.Cells["dgvSpassword"].Value);


                frmSAdd.ShowDialog();
                getData();
                
            }
            
            if (dgvSInfo.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                messageDel.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                messageDel.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if(messageDel.Show ("Are you sure that the Staff have been deleted?") == DialogResult.Yes)
                {
                    
                    int id = Convert.ToInt32(dgvSInfo.CurrentRow.Cells["dgvSID"].Value);
                    string qry = "delete from Employee where EmployeeID = " + id + "";
                    Hashtable ht = new Hashtable();
                    GlobalVar.Sql(qry, ht);

                    messageDel.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    messageDel.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    messageDel.Show("Deleted Successfully");

                    getData();

                }



            }
        }

    }
}
