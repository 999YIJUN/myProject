using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Web.ModelBinding;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //public int selectID = 0;
        int sumOfPrice;
        int nuQuan;
        int priceNu;
        string dessertOrder;

        List<int> listID = new List<int>();
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readDB();
            picMode();

        }

        private void ucDessert_1_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price);

            dessertOrder = GlobalVar.strDessertName;
            price();
        }

        //void price()
        //{
        //    if(lblUnitPrice.Text != "")
        //    {

        //    priceNu = int.Parse(lblUnitPrice.Text);
        //    nuQuan = (int)numericQuan.Value;
        //    sumOfPrice = priceNu * nuQuan;

        //    lblPriceTotal.Text = string.Format("{0}", sumOfPrice);
        //    }
        //}

        void price()
        {
            if (lblUnitPrice.Text != "")
            {

                priceNu = int.Parse(lblUnitPrice.Text);
                nuQuan = (int)numericQuan.Value;
                sumOfPrice = priceNu * nuQuan;

                lblPriceTotal.Text = string.Format("{0}", sumOfPrice);
            }
        }

        private void numericQuan_ValueChanged(object sender, EventArgs e)
        {
            price();
            
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if ((txtCusName.Text != "") && (txtContactNum.Text !="")) 
            { 
                ArrayList customerOrder= new ArrayList(); 
                customerOrder.Add(dessertOrder);
                customerOrder.Add(priceNu);
                customerOrder.Add(nuQuan);
                customerOrder.Add(sumOfPrice);
                //customerOrder.Add(ucDessert_1);

                GlobalVar.listCustomerOrder.Add(customerOrder);
                GlobalVar.cusName = txtCusName.Text;
                GlobalVar.cusContact = txtContactNum.Text;

                MessageBox.Show("added to OrderList");
            }
            else
            {
                MessageBox.Show("Please, Enter the Entire Customer Information");
            }
        }

        void readDB()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
            con.Open();
            string strReadDB = "select * from Products;";
            SqlCommand cmd = new SqlCommand(strReadDB, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string imageName = "";
            int count = 0;

            while (reader.Read() == true)
            {
                listID.Add((int)reader["ProductID"]);
                listName.Add((string)reader["ProductName"].ToString());
                listPrice.Add((int)reader["Price"]);
                imageName = reader["Image"].ToString();
                string imageFullPath = GlobalVar.image_Dir + imageName;
                Image image = Image.FromFile(imageFullPath);
                ilProductPic.Images.Add(image);

                count++;

            }
            reader.Close();
            con.Close();
        }

        void picMode()
        {
            //lvProductDisplay.Clear();
            lvDessert.View = View.LargeIcon;
            ilProductPic.ImageSize = new Size(120, 120);
            lvDessert.LargeImageList = ilProductPic;

            for (int i = 0; i < ilProductPic.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("Constantia", 12, FontStyle.Regular);
                item.Text = $"{listName[i]}{listPrice[i]}NTD";
                item.Tag = listID[i];// 
                lvDessert.Items.Add(item);
            }
        }

        private void lvDessert_ItemActivate(object sender, EventArgs e)
        {

        }
        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            FormOrderList myformOrderList = new FormOrderList();
            myformOrderList.ShowDialog();
        }

        

        private void ucDessert_2_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price01);

            dessertOrder = GlobalVar.strDessertName01;
            price();
        }

        private void ucDessert_3_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price02);

            dessertOrder = GlobalVar.strDessertName02;
            price();
            
        }

        private void ucDessert_4_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price03);

            dessertOrder = GlobalVar.strDessertName03;
            price();
        }

        private void ucDessert_5_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price04);

            dessertOrder = GlobalVar.strDessertName04;
            price();
        }

        private void ucDessert_6_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price05);

            dessertOrder = GlobalVar.strDessertName05;
            price();
        }

        private void ucDessert_7_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price06);

            dessertOrder = GlobalVar.strDessertName06;
            price();
        }

        private void ucDessert_8_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price07);

            dessertOrder = GlobalVar.strDessertName07;
            price();
        }

        private void ucDessert_9_Click(object sender, EventArgs e)
        {
            lblUnitPrice.Text = string.Format("{0}", GlobalVar.price08);

            dessertOrder = GlobalVar.strDessertName08;
            price();
        }

    }
}
