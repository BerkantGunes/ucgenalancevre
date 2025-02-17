using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucgenalancevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taban, yukseklik, alan;

            taban = Convert.ToInt32(txtTaban.Text);
            yukseklik = Convert.ToInt32(txtYukseklik.Text);

            alan = (taban * yukseklik) / 2;

            MessageBox.Show("Ucgenin alani: " + alan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int taban, kenar2, kenar3, cevre;

            taban = Convert.ToInt32(txtTaban.Text);
            kenar2 = Convert.ToInt32(txtKenar2.Text);
            kenar3 = Convert.ToInt32(txtKenar3.Text);

            cevre = taban + kenar2 + kenar3;

            MessageBox.Show("Ucgenin cevresi: " +  cevre);
        }
    }
}
