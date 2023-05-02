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
    public partial class ucDrinks02 : UserControl
    {
        public ucDrinks02()
        {
            InitializeComponent();
        }

        private void ucDrinks02_Load(object sender, EventArgs e)
        {
            int price;
            string dessertName;

            price = 280;

            GlobalVar.price02 = price;

            dessertName = "Earl Grey Mille Crêpes - 1 piece";
            GlobalVar.strDessertName02 = dessertName;
        }
    }
}
