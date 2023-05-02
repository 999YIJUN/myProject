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
    public partial class ucDrinks08 : UserControl
    {
        public ucDrinks08()
        {
            InitializeComponent();
        }

        private void ucDrinks08_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;

            price = 1680;

            GlobalVar.price08 = price;

            dessertName = "Earl Grey Mille Crêpes - 1 piece";
            GlobalVar.strDessertName08 = dessertName;
        }
    }
}
