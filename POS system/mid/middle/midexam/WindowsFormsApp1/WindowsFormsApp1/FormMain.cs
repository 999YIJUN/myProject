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

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "examDB";
            scsb.IntegratedSecurity = true;
            GlobalVar.strExamDBconnectionString = scsb.ConnectionString;

            lblEmployee.Text = "Job Title: " + GlobalVar.jobTitle +"\n" +"EmployeeName: " + GlobalVar.employeeName;
            

            if((GlobalVar.jobTitle == "Engineer") || (GlobalVar.jobTitle == "Manager") || (GlobalVar.jobTitle == "AssistantManager"))
            {
                btnProInfo.Enabled = true;
                btnMemberInfo.Enabled = true;
                btnStaff.Enabled = true;
            }
            else
            {
                btnProInfo.Enabled= false;
                btnMemberInfo.Enabled= false;
                btnStaff.Enabled = false;
            }

            if (lblEmployee.Text == "Job Title: " + "" + "\n" + "EmployeeName: " + "")
            {
                btnOUT.Visible = false;
            }
            else
            {
                btnOUT.Visible = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormPOS frmMenu = new FormPOS();
            frmMenu.ShowDialog();
        }

        private void btnMenberInfo_Click(object sender, EventArgs e)
        {
            FormMember formMM = new FormMember();
            formMM.ShowDialog();
        }

        private void btnProInfo_Click(object sender, EventArgs e)
        {
            FormPManagement formProduct = new FormPManagement();
            formProduct.ShowDialog();
        }

        private void BtnSLogin_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormStaff frmStaff = new FormStaff();
            frmStaff.ShowDialog();
        }

        private void cbexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            lblEmployee.Text = "Job Title: " + "" + "\n" + "EmployeeName: " + "";

            
        }
    }
}
