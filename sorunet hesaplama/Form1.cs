using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorunet_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double dogru, yanlis, net;
            dogru = Convert.ToDouble(cmbDogru.Text);
            yanlis = Convert.ToDouble(cmbYanlis.Text);

            net = dogru - yanlis / 4;
             lblSonuc.Text=net.ToString();




        }
    }
}
