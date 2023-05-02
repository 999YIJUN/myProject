using System;
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
    public partial class ucDrinks06 : UserControl
    {
        public ucDrinks06()
        {
            InitializeComponent();
        }

        private void ucDrinks06_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;

            price = 1080;

            GlobalVar.price06 = price;

            dessertName = "Matcha Cheese Cake";
            GlobalVar.strDessertName06 = dessertName;
        }
    }
}
