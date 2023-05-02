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
    public partial class ucDrinks05 : UserControl
    {
        public ucDrinks05()
        {
            InitializeComponent();
        }

        private void ucDrinks05_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;

            price = 1480;

            GlobalVar.price05 = price;

            dessertName = "Kiwi Fruit Cheese Cake";
            GlobalVar.strDessertName05 = dessertName;
        }
    }
}
