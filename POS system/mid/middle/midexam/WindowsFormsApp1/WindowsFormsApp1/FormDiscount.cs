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
using System.IdentityModel.Tokens;

namespace WindowsFormsApp1
{
    public partial class FormDiscount : Form
    {
        int afterDiscount = 0;
       

        public FormDiscount()
        {
            InitializeComponent();

        }
        private void FormDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btnMember_Click(object sender, EventArgs e)
        {

          
            if (GlobalVar.strTotal != "")
            {
                afterDiscount = Convert.ToInt32(GlobalVar.beforeDiscount * 0.9);
                
            }

            //GlobalVar.afterdis = afterDiscount;
            GlobalVar.intA = afterDiscount;
            GlobalVar.strA = string.Format("After discount: {0}  NTD", afterDiscount);
        }

        private void btnBirth_Click(object sender, EventArgs e)
        {
            if (GlobalVar.strTotal != "")
            {
                afterDiscount = Convert.ToInt32(GlobalVar.beforeDiscount * 0.8);
            }
            // GlobalVar.afterdis = afterDiscount;
            GlobalVar.intA = afterDiscount;
            GlobalVar.strA = string.Format("After discount: {0}  NTD", afterDiscount);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (GlobalVar.strTotal != "")
            {
                afterDiscount = Convert.ToInt32(GlobalVar.beforeDiscount * 0.7);

            }
            //GlobalVar.afterdis = afterDiscount;
            GlobalVar.intA = afterDiscount;
            GlobalVar.strA = string.Format("After discount: {0}  NTD", afterDiscount);
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {

            //GlobalVar.afterdis = afterDiscount;
            GlobalVar.intA = afterDiscount;
            GlobalVar.strA = string.Format("After discount: {0}  NTD", afterDiscount);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            GlobalVar.intA = afterDiscount;
            GlobalVar.strA = "";
        }

        private void cbCLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
