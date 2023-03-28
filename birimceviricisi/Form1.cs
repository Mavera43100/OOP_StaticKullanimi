using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birimceviricisi
{
    public partial class Form1 : Form
    {
        class Cevirici
        {
            public const double inc = 2.54;
            static public string uzunlukCevir(double uzunluk, int hangisi)
            {
                if (hangisi == 0)
                    return (uzunluk * inc).ToString();
                else
                    return (uzunluk / inc).ToString();
            }
            static public string kapasiteCevir(int b1, int b2, double deger)
            {
                double temp = deger;
                if (b1 < b2)
                {
                    int fark = b2 - b1;
                    for (int i = 0; i < fark; i++)
                    {
                        temp /= 1024;
                        //temp = temp / 1024;
                    }

                }
                else
                {
                    int fark = b1 - b2;
                    for (int i = 0; i < fark; i++)
                    {
                        temp *= 1024;
                        //temp = temp * 1024;
                    }
                }
                return temp.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnKapasiteCevir_Click(object sender, EventArgs e)
        {
            int b1 = comboBox1.SelectedIndex;
            int b2 = comboBox2.SelectedIndex;
            double temp = double.Parse(txtDeger.Text);
          
            lblSonuc.Text = Cevirici.kapasiteCevir(b1, b2, temp);


        }
        private void incCm_Click(object sender, EventArgs e)
        {
            lblUzunluk.Text = Cevirici.uzunlukCevir(double.Parse(txtUzunluk.Text), 0);
        }

        private void cmInc_Click(object sender, EventArgs e)
        {
            lblUzunluk.Text = uzunlukCevir(double.Parse(txtUzunluk.Text), 1);
        }
    }
}
