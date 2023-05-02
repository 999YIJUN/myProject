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
    public partial class ucDrinks07 : UserControl
    {
        public ucDrinks07()
        {
            InitializeComponent();
        }

        private void ucDrinks07_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;

            price = 1580;

            GlobalVar.price07 = price;

            dessertName = "Black Sesame Peanuts Cheese Cake";
            GlobalVar.strDessertName07 = dessertName;
        }
    }
}
