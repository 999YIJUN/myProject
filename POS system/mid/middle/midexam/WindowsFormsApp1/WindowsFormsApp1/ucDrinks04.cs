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
    public partial class ucDrinks04 : UserControl
    {
        public ucDrinks04()
        {
            InitializeComponent();
        }

        private void ucDrinks04_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;

            price = 1180;

            GlobalVar.price04 = price;

            dessertName = "Chocolate Cheese Cake";
            GlobalVar.strDessertName04 = dessertName;
        }
    }
}
