using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormOrderList : Form
    {
        int beforePrice;

        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            lblCusInfo.Text = "Customer Name:" + GlobalVar.cusName + "\nContact Number:" + GlobalVar.cusContact;

            foreach(ArrayList orders in GlobalVar.listCustomerOrder)
            {
                string dessertName = (string)orders[0];
                int priceNu = (int)orders[1];
                int nuQuan = (int)orders[2];
                int sumOfPrice = (int)orders[3];

                string Info = string.Format("{0} Price:{1}NTD  QTY:{2}  Sub Total:{3} NTD", dessertName, priceNu, nuQuan, sumOfPrice);

                listboxOrderDetail.Items.Add(Info);
            }
            Total();
        }

        void Total()
        {
            int totalPrice = 0;

            foreach(ArrayList All in GlobalVar.listCustomerOrder)
            {
                int sumOfPrice = (int)All[3];
                totalPrice += sumOfPrice;
            }

            beforePrice = totalPrice;
            lblTotalPrice.Text = string.Format("TOTAL PRICE:{0}  NTD", totalPrice);
            //beforePrice = totalPrice;
            //lblAfterDiscount.Text = "";
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(listboxOrderDetail.SelectedIndices.Count > 0)
            {
                for(int i =(listboxOrderDetail.SelectedIndices.Count -1); i >= 0; i--)
                {
                    GlobalVar.listCustomerOrder.RemoveAt(listboxOrderDetail.SelectedIndices[i]);
                    listboxOrderDetail.Items.RemoveAt(listboxOrderDetail.SelectedIndices[i]);
                    
                }
                lblAfterDiscount.Text = "";
                Total();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listboxOrderDetail.Items.Clear();
            GlobalVar.listCustomerOrder.Clear();
            GlobalVar.cusName = "";
            GlobalVar.cusContact = "";
            lblCusInfo.Text = "";
            lblAfterDiscount.Text = "";
            Total();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormOrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R = MessageBox.Show("Close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(R == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel= true;
            }
        }


        private void btnMember_Click(object sender, EventArgs e)
        {
            int afterDiscount = 0;

            if (lblTotalPrice.Text != "")
            {
                afterDiscount = Convert.ToInt32(beforePrice * 0.9);
               
            }
            lblAfterDiscount.Text = string.Format("After Discount:{0} NTD", afterDiscount);
        }

        private void btnBirth_Click(object sender, EventArgs e)
        {
           int afterDiscount = 0;

            if (lblTotalPrice.Text != "")
            {
                afterDiscount = Convert.ToInt32(beforePrice * 0.8);
                Total();
            }
            lblAfterDiscount.Text = string.Format("After Discount:{0} NTD", afterDiscount);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            int afterDiscount = 0;

            if (lblTotalPrice.Text != "")
            {
                afterDiscount = Convert.ToInt32(beforePrice * 0.85);

            }
            lblAfterDiscount.Text = string.Format("After Discount:{0} NTD", afterDiscount);
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            int afterDiscount = 0;

            if (lblTotalPrice.Text != "")
            {
                afterDiscount = Convert.ToInt32(beforePrice * 0);

            }
            lblAfterDiscount.Text = string.Format("After Discount:{0} NTD", afterDiscount);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblAfterDiscount.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
