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

namespace WindowsFormsApp1
{
    public partial class ucDrinks : UserControl
    {
        
       
        public ucDrinks()
        {
            InitializeComponent();
        }

        private void ucDrinks_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;
            
            price = 280;

            GlobalVar.price = price;

            dessertName = "Signature Mille Crêpe - 1 piece";
            GlobalVar.strDessertName = dessertName;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            //price01 = GlobalVar.price01;
            //GlobalVar.strPrice = string.Format("{0}", GlobalVar.price01);

        }


       
    }
}
