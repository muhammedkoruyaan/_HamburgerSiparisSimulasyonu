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
    public partial class HamburgerEkle : Form
    {
        public HamburgerEkle()
        {
            InitializeComponent();
        }
       
        void HamburgerEkleMethod()
        {
            try
            {
                if (txtBoxHamburger.Text != "")
                {
                    string hamburgerName = txtBoxHamburger.Text;
                    double hamburgerPrice = double.Parse(txtBoxFiyat.Text);
                    if (!MyList.Hamburgers.ContainsKey(hamburgerName))
                    {
                        if (hamburgerPrice <= 0)
                        {
                            MessageBox.Show("Lütfen 0'dan ve Negatif değerlerden farklı bir fiyat giriniz.");

                        }
                        else
                        {
                            Hamburger hamburgerEkle = new Hamburger(hamburgerName, hamburgerPrice);
                            MyList.Hamburgers.Add(hamburgerName, hamburgerEkle.HamburgerPrice);
                            MessageBox.Show("Başarı ile eklendi");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu hamburger halihazırda mevcuttur!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir hamburger adı giriniz!");
                }
               



            }
            catch (InvalidOperationException hata)
            {

                MessageBox.Show(hata.ToString()) ;
            }
            

            
          
          
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HamburgerEkleMethod();
        }

        
    }
}
