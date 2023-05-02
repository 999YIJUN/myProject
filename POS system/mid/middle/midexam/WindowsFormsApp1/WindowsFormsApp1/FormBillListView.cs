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
    public partial class FormBillListView : Form
    {
        public int MainID = 0;
        public FormBillListView()
        {
            InitializeComponent();
        }
        
        private void FormBillListView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            string qry = "select o.OrderID,  m.NAME, o.TotalPrice, o.OrderDate ,e.EmployeeName, o.status from Orders as o inner join Employee as e on o.EmployeeID = e.EmployeeID inner join MM as m on m.ID = o.ID;";
            //SqlCommand cmd = new SqlCommand(qry, con);
            //cmd.Parameters.AddWithValue("@NewOID", dgvOid.Tag.ToString());
            ListBox lb = new ListBox();
            lb.Items.Add(dgvOid);
            lb.Items.Add(dgvCus);
            lb.Items.Add(dgvTotal);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvEmployee);
            lb.Items.Add(dgvStatus);

            GlobalVar.loadDate(qry, dgvBillList, lb);

            con.Close();
        }

        private void dgvBillList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach(DataGridViewRow row in dgvBillList.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void dgvBillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvBillList.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                MainID = Convert.ToInt32(dgvBillList.CurrentRow.Cells["dgvOid"].Value);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
