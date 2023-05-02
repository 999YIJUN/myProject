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
using System.Drawing.Text;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class FormPOS : Form
    {
        int beforePrice = 0;
        string pay = "";
        
        
        public FormPOS()
        {
            InitializeComponent();
        }

        static FormPOS _obj;
        public static FormPOS Instance1
        {
            get { if(_obj == null) { _obj = new FormPOS(); } return _obj; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            _obj = this;
            dgvPaymentInfo.BorderStyle = BorderStyle.FixedSingle;
            addCategory();
            menuPanel.Controls.Clear();

            loadProduct();

            lblCNAME.Text = GlobalVar.employeeName;
        }

        private void addCategory()
        {
            SqlConnection con =new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            string qry = "select * from Category";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            categoryPanel.Controls.Clear();

            Guna.UI2.WinForms.Guna2Button btn2 = new Guna.UI2.WinForms.Guna2Button();
            btn2.FillColor = Color.FromArgb(55, 55, 55);
            btn2.Size = new Size(130, 50);
            btn2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn2.Text = "ALL CATEGORIES";
            btn2.CheckedState.FillColor = Color.FromArgb(125, 55, 90);
            btn2.Click += new EventHandler(_Click);
            categoryPanel.Controls.Add(btn2);

            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                    btn.FillColor = Color.FromArgb(55,55,55);
                    btn.Size = new Size(130, 50);
                    btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    btn.Text = row["CategoryName"].ToString();

                    btn.Click += new EventHandler(_Click);

                    categoryPanel.Controls.Add(btn);
                }
            }
            
            con.Close();
        }
        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if(btn.Text == "ALL CATEGORIES")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }
            foreach (var item in menuPanel.Controls)
            {
                var pro = (ucDessert)item;
                pro.Visible = pro.pCatogory.ToLower().Contains(btn.Text.Trim().ToLower());
            }
        }

        private void addItem(string id,String proID, string Name, string category, string price, Image pimage)
        {
            var w = new ucDessert()
            {
                pID = Convert.ToInt32(proID),
                pName = Name,
                pPrice = price,
                pCatogory = category,
                pImage = pimage,
                
            };

            menuPanel.Controls.Add(w);

            w.onselect += (ss, ee) =>
            {
                var wdg = (ucDessert)ss;
                foreach (DataGridViewRow item in dgvPaymentInfo.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvpid"].Value) == wdg.pID)
                    {
                        item.Cells["dgvQTY"].Value = int.Parse(item.Cells["dgvQTY"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQTY"].Value.ToString()) * int.Parse(item.Cells["dgvPrice"].Value.ToString());
                        getTotal();
                        return;
                    }
                }
                dgvPaymentInfo.Rows.Add(new object[] { 0, 0,wdg.pID, wdg.pName, wdg.pPrice, 1, wdg.pPrice });
                getTotal();
            };
        }

        private void loadProduct()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            string qry = "select * from products ";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow item in dt.Rows)
            {
                string imageName = "";
                //Byte[] imagearray = (byte[])item["PImage"];
                //byte[] imagebytearray = imagearray;
                imageName = item["Image"].ToString();
                string imageFullPath = GlobalVar.image_Dir + imageName;
                Image image = Image.FromFile(imageFullPath);

                //addItem(item["ProductID"].ToString(), item["ProductName"].ToString(), item["CategoryName"].ToString(), item["Price"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
                addItem("0",item["ProductID"].ToString(), item["ProductName"].ToString(), item["CategoryName"].ToString(), item["Price"].ToString(), image);
            }

            con.Close();
        }

        private void dgvPaymentInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach(DataGridViewRow row in dgvPaymentInfo.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public void getTotal()
        {
           int total = 0;
            
            lblTotal.Text = "";
            
            foreach (DataGridViewRow item in dgvPaymentInfo.Rows)
            {
                total += int.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            pay = total.ToString();
            lblTotal.Text = string.Format("TOTAL PRICE:{0}  NTD", total);
            beforePrice = total;
            GlobalVar.strTotal = lblTotal.Text;
            GlobalVar.beforeDiscount = beforePrice;

            lblAfter.Text = "";
            //lblAfter.Text = string.Format("TOTAL PRICE:{0}  NTD", GlobalVar.afterdis);
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in categoryPanel.Controls)
            {
                if(item is Guna.UI2.WinForms.Guna2Button)
                {
                    Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)item;
                    btn.Checked = false;
                }
            }

            foreach(var item in menuPanel.Controls)
            {
                var pro = (ucDessert)item;
                pro.Visible = pro.pName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            FormDiscount frmdiscount = new FormDiscount();
            // frmdiscount.ShowDialog();
            GlobalVar.BlurBackGround(frmdiscount);
            //lblAfter.Text = string.Format("After discount: {0}  NTD", GlobalVar.afterdis);
            lblAfter.Text = GlobalVar.strA;
        }

        private void FormPOS_Activated(object sender, EventArgs e)
        {
           //lblAfter.Text = "no discount";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvPaymentInfo.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    dgvPaymentInfo.Rows.Remove(r);
                }
            }

            getTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvPaymentInfo.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    dgvPaymentInfo.Rows.Clear();
                }
            }

            getTotal();
        }
        public int id = 0;
        public int mainID = 0;
        //internal static readonly object Instance;

        private void btnBill_Click(object sender, EventArgs e)
        {
            FormBillListView frm = new FormBillListView();
            //    frm.ShowDialog();
            GlobalVar.BlurBackGround(frm);

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                mainID = frm.MainID;
                loadEntries();
            }
        }

        private void loadEntries()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            string qry = @"select * from OrderDetail as od inner join Products as PP on pp.ProductID = od.ProductID  inner join Orders as o on o.OrderID = od.OrderID where od.OrderID = " + id + "";

            SqlCommand cmd2 = new SqlCommand(qry, con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            dgvPaymentInfo.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {
                string detailid = item["OrderDetailID"].ToString();
                string proid = item["Productid"].ToString();
                string proName = item["ProductName"].ToString();
                string qty = item["Quantity"].ToString();
                string price = item["price"].ToString();
                string subTotal = item["SubTotal"].ToString();

                object[] obj = { 0, detailid ,proid, proName, price, qty, subTotal};
                dgvPaymentInfo.Rows.Add(obj);
            }
            con.Close();

            getTotal();

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckOut frm = new FormCheckOut();
            frm.MainID = id;

            if(lblAfter.Text != "")
            {
                frm.amt = Convert.ToInt32(GlobalVar.intA);
            }
            else
            {
                frm.amt = Convert.ToInt32(pay);
            }

            

            GlobalVar.BlurBackGround(frm);
            //frm.ShowDialog();
            // Console.WriteLine(id);
            mainID = 0;
            dgvPaymentInfo.Rows.Clear();
            lblTotal.Text = "";
            lblAfter.Text = "";
        }

        private void btnTOgo_Click(object sender, EventArgs e)
        {
            
            //string sql = "insert into ";
            //SqlCommand cmd = new SqlCommand(sql, con);
            string qry1 = "";
            string qry2 = "";
            
            int detailID = 0;
            Console.WriteLine(detailID);
            Console.WriteLine(mainID);
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            if (mainID == 0)
            {
                //qry1 = @"insert into  Orders values(@newName, @time , @newEName , @newTotal,@newReceive,@newChange); Select SCOPE_IDENTITY()";
                qry1 = @"insert into Orders (mm.ID, Employee.EmployeeID) select MM.ID, Employee.EmployeeID from MM , Employee where mm.NAME =@newName  and Employee.EmployeeName = @newEName;";
            }
            else
            {
                qry1 = @"update Orders set orderdate=@time,  TotalPrice = @newTotal, Received = @newReceive, change = @newChange ,status = @newStatus where OrderID = @newID";
            }
            SqlCommand cmd = new SqlCommand(qry1, con);
            
            cmd.Parameters.AddWithValue("@newID", mainID);
            
            cmd.Parameters.AddWithValue("@newName",  txtName.Text);
            cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@newEName", lblCNAME.Text);
            cmd.Parameters.AddWithValue("@newTotal", pay);
            cmd.Parameters.AddWithValue("@newStatus", "unpaid");
            cmd.Parameters.AddWithValue("@newReceive", Convert.ToInt32(0));
            cmd.Parameters.AddWithValue("@newChange", Convert.ToInt32(0));

            if (con.State == ConnectionState.Closed) { con.Open(); }
            if (mainID == 0) { mainID = Convert.ToInt32( cmd.ExecuteScalar() ); } else { cmd.ExecuteNonQuery(); }
           
            if (con.State == ConnectionState.Open) { con.Close(); }

            foreach (DataGridViewRow row in dgvPaymentInfo.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvID"].Value);

                if (detailID == 0)
                {
                    qry2 = @"insert into OrderDetail values (@mainID, @newProID, @newQty, @NewSubTotal)";
                }
                else
                {
                    qry2 = @"update OrderDetail set OrderID = @mainID, ProductID = @newProID, Quantity = @newQty, SubTotal = @NewSubTotal where OrderDetailID = @newID;";
                }
            SqlCommand cmd2 = new SqlCommand(qry2 ,con);
                cmd2.Parameters.AddWithValue("@newID", detailID);
                cmd2.Parameters.AddWithValue("@mainID", mainID);
                cmd2.Parameters.AddWithValue("@newProID", Convert.ToInt32(row.Cells["dgvpid"].Value));
                cmd2.Parameters.AddWithValue("@newQty", Convert.ToInt32(row.Cells["dgvQTY"].Value));
                cmd2.Parameters.AddWithValue("@NewSubTotal", Convert.ToInt32(row.Cells["dgvAmount"].Value));

                if (con.State == ConnectionState.Closed) { con.Open(); }
            cmd2.ExecuteNonQuery();
            if (con.State == ConnectionState.Open) { con.Close(); }
           // con.Close();
            }

            messagePOS.Show("Saved Successfully");
            mainID = 0;
            detailID = 0;
            dgvPaymentInfo.Rows.Clear();
            txtName.Text = "";
            lblAfter.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
          
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
