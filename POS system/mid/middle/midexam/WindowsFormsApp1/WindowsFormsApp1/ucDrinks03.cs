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
    public partial class ucDrinks03 : UserControl
    {
        public ucDrinks03()
        {
            InitializeComponent();
        }

        private void ucDrinks03_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;

            price = 1480;

            GlobalVar.price03 = price;

            dessertName = "Blueberry Cheese Cake";
            GlobalVar.strDessertName03 = dessertName;
        }
    }
}
