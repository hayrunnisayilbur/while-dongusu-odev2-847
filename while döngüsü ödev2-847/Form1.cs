using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_döngüsü_ödev2_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbSayilar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sayi = 1;
            do
            {
                lbSayilar1.Items.Add(sayi);
                sayi++;
            } while (sayi <= 10);
        }
    }
}
