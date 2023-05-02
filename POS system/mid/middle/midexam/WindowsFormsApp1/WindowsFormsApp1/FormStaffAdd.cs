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
    public partial class FormStaffAdd : Form
    {
        public FormStaffAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into Employee values(@newTitle ,@newName, @newContact, @newPassword)";
            }
            else
            {
                qry = "update Employee set JobTItle = @newTitle, EmployeeName = @newName, ContactNumber = @newContact, Password = @newPassword where EmployeeID = @newID";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@newID", id);
            ht.Add("@newTitle", cbJTitle.Text);
            ht.Add("@newName", txtName.Text);
            ht.Add("@newContact", txtContact.Text);
            ht.Add("@newPassword", txtPassword.Text);

            if(GlobalVar.Sql(qry, ht) > 0)
            {
                message.Show("Save Successfully");
                id = 0;
                txtName.Text = "";
                txtContact.Text = "";
                txtPassword.Text = "";
                cbJTitle.SelectedIndex = -1;
                txtName.Focus();
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
