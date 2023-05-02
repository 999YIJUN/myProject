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
    public partial class formP_info : Form
    {
        public int selectID = 0;
        string imageName = "";
        bool isModify = false;

        public static Size Instance { get; internal set; }

        public formP_info()
        {
            InitializeComponent();
        }

        private void formP_info_Load(object sender, EventArgs e)
        {
            if(selectID > 0)
            {
                btnUpdate.Visible = true;
                btnStore.Visible = false;
            }
            else
            {
                btnUpdate.Visible = false;
                btnStore.Visible = true;
            }

            p_info();
        }

        void p_info()
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strProduct = "select * from Products where ProductID = @searchID ";
                SqlCommand cmd = new SqlCommand(strProduct, con);
                cmd.Parameters.AddWithValue("@searchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read() == true)
                {
                    lblProductID.Text = reader["ProductID"].ToString();
                    txtProductName.Text = reader["ProductName"].ToString();
                    txtProductPrice.Text = reader["Price"].ToString();
                    txtProductDesc.Text = reader["Description"].ToString();
                    txtCatogroies.Text = reader["CategoryName"].ToString();
                    txtUnit.Text = reader["Unit"].ToString();
                    imageName = reader["image"].ToString();
                    string picFullPath = GlobalVar.image_Dir + imageName;
                    pbProduct.Image = Image.FromFile(picFullPath);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "fileType(*.jpg, *.jpeg, *.png,)| *.jpeg; *.jpg; *.png";

            DialogResult R = f.ShowDialog();

            if(R == DialogResult.OK)
            {pbProduct.Image = Image.FromFile(f.FileName);
            }
            string fileExtension = System.IO.Path.GetExtension(f.SafeFileName);
            Random rnd = new Random();
            imageName = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(1000, 10000).ToString() + fileExtension;
            isModify = true;
            Console.WriteLine(imageName);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtProductName.Text != "") && (txtProductPrice.Text != "") && (txtProductDesc.Text != "") && (pbProduct.Image != null))
            {
                if(isModify == true)
                {
                    pbProduct.Image.Save(GlobalVar.image_Dir + imageName);
                    isModify = false;
                }

                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strUpdate = "update Products set ProductName = @newName,Price = @newPrice,Description =@newDesc ,image= @newImage where ProductID = @searchID;";
                SqlCommand cmd = new SqlCommand(strUpdate, con);
                cmd.Parameters.AddWithValue("@searchID", lblProductID.Text);
                cmd.Parameters.AddWithValue("@newName", txtProductName.Text);
                int intPrice = 0;
                Int32.TryParse(txtProductPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@newPrice", intPrice);
                cmd.Parameters.AddWithValue("@newDesc", txtProductDesc.Text);
                cmd.Parameters.AddWithValue("@newImage", imageName);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("do not have empty");
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            if ((txtProductName.Text != "") && (txtProductPrice.Text != "") && (txtProductDesc.Text != "") && (pbProduct.Image != null))
            {
                if(isModify == true)
                {
                    pbProduct.Image.Save(GlobalVar.image_Dir + imageName);
                    isModify = false;
                }

                SqlConnection con = new SqlConnection(GlobalVar.strExamDBconnectionString);
                con.Open();
                string strStore = "insert into Products(ProductName, Price,Description,CategoryName, image) values (@newName ,@newPrice , @newDesc, @category,@newImage)";
                SqlCommand cmd = new SqlCommand(strStore, con);
                cmd.Parameters.AddWithValue("@newName", txtProductName.Text);
                int intPrice = 0;
                Int32.TryParse(txtProductPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@newPrice", intPrice);
                cmd.Parameters.AddWithValue("@newDesc", txtProductDesc.Text);
                cmd.Parameters.AddWithValue("@category", txtCatogroies.Text);
                cmd.Parameters.AddWithValue("@newImage", imageName);
                int rows = cmd.ExecuteNonQuery();

                
                con.Close();

            }
            else
            {
                MessageBox.Show("do not empty");
            }

            
        }
    }
}
