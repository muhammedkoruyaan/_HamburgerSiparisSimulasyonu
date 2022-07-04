using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220319_HamburgerSiparisSimulasyonu
{
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        void ExtraEkleMethod()
        {
            try
            {
                if (txtMalzemeAdı.Text != "")
                {
                    string extraName = txtMalzemeAdı.Text;
                    double extraPrice = double.Parse(txtBoxExtraFiyat.Text);

                    if (!MyList.Extras.ContainsKey(extraName))
                    {
                        if (extraPrice <= 0)
                        {
                            MessageBox.Show("Lütfen 0'dan ve Negatif değerlerden farklı bir fiyat giriniz.");

                        }
                        else
                        {
                            Extra extraEkle = new Extra(extraName, extraPrice);
                            MyList.Extras.Add(extraName, extraPrice);
                            MessageBox.Show("Başarı ile eklendi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu extra halihazırda mevcuttur.");
                    }
                }
                else
                {
                    MessageBox.Show("Bu extra malzeme halihazırda mevcuttur!");
                }
               



            }
            catch (InvalidOperationException hata)
            {
                MessageBox.Show(hata.ToString());
            }
            







        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ExtraEkleMethod();
        }
    }
}
