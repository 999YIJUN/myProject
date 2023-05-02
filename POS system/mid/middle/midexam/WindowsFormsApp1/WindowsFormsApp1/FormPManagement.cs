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
    public partial class FormPManagement : Form
    {
        
        List<int> listID = new List<int>();
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<string> listCategories = new List<string>();


        public FormPManagement()
        {
            InitializeComponent();
        }

        private void FormPManagement_Load(object sender, EventArgs e)
        {
            readDB();
            picMode();
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

            while(reader.Read() == true)
            {
                listID.Add((int)reader["ProductID"]);
                listName.Add((string)reader["ProductName"].ToString());
                listCategories.Add((string)reader["CategoryName"].ToString());
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
            lvProductDisplay.Clear();
            lvProductDisplay.View = View.LargeIcon;
            ilProductPic.ImageSize = new Size(120, 120);
            lvProductDisplay.LargeImageList = ilProductPic;

            for (int i = 0; i < ilProductPic.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("Constantia", 12, FontStyle.Regular);
                item.Text = $"{listName[i]}{listPrice[i]}NTD";
                item.Tag = listID[i];// 
                lvProductDisplay.Items.Add(item);
            }
        }

        void listmode()
        {
            lvProductDisplay.Clear();
            lvProductDisplay.LargeImageList = null;
            lvProductDisplay.SmallImageList = null;
            lvProductDisplay.View = View.Details; //列表模式
            lvProductDisplay.Columns.Add("id", 100);
            lvProductDisplay.Columns.Add("Product Name", 200);
            lvProductDisplay.Columns.Add("CategoryName", 100);
            lvProductDisplay.Columns.Add("Price", 100);
            lvProductDisplay.GridLines = true;
            lvProductDisplay.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listID[i].ToString();
                item.SubItems.Add(listName[i]);
                item.SubItems.Add(listCategories[i].ToString());
                item.SubItems.Add(listPrice[i].ToString());
                item.Tag = listID[i];
                item.ForeColor = Color.DarkBlue;

                lvProductDisplay.Items.Add(item);
            }
        }

        private void btnAddNewP_Click(object sender, EventArgs e)
        {
            formP_info addNewP = new formP_info();
            addNewP.ShowDialog();
        }

        private void lvProductDisplay_ItemActivate(object sender, EventArgs e)
        {
            formP_info addNewP = new formP_info();
            addNewP.selectID = (int)lvProductDisplay.SelectedItems[0].Tag;
            addNewP.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            formP_info addNewP = new formP_info();
            addNewP.ShowDialog();
        }

        private void btnListMode_Click(object sender, EventArgs e)
        {
            listmode();
        }

        private void btnPicMode_Click(object sender, EventArgs e)
        {
            picMode();
        }
    }
}
