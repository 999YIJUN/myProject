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
    public partial class ucDessert : UserControl
    {
        public event EventHandler onselect = null; 
        public ucDessert()
        {
            InitializeComponent();
        }

        public int pID { get; set; }
        public string pPrice { get; set; }
        public string pCatogory { get; set; }
        public string pName
        {
            get { return lblPName.Text; }
            set { lblPName.Text = value; }
        }

        public Image pImage 
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onselect?.Invoke(this, e);
        }
    }
}
