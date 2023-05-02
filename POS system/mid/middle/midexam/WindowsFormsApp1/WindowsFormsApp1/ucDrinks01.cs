using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucDrinks01 : UserControl
    {
        int price01;
        string dessertName01;

        public ucDrinks01()
        {
            InitializeComponent();
        }

        private void ucDrinks01_Load(object sender, EventArgs e)
        {
            price01 = 280;

            GlobalVar.price01 = price01;

            dessertName01 = "Green Tea Mille Crêpes - 1 piece";
            GlobalVar.strDessertName01 = dessertName01;
        }
    }
}
