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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(GlobalVar.isValid(txtName.Text.Trim(), txtPassword.Text.Trim()) == false)
            {
                messageWarning.Show("not Found");
                return;

            }
            else
            {
                Hide();
                FormMain pManagement = new FormMain();
                pManagement.ShowDialog();

                //FormMember member = new FormMember();
                //member.ShowDialog();
            }
            
        }
    }
}
