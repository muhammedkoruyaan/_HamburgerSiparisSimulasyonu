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
    public partial class DrinksAdd : Form
    {
        public DrinksAdd()
        {
            InitializeComponent();
        }
        void drinkAdd()
        {
            try
            {
                if (txtBoxDrink.Text != "")
                {
                    string drinkName = txtBoxDrink.Text;
                    double drinkPrice = double.Parse(txtBoxDrinksFiyat.Text);

                    if (!MyList.Drinks.ContainsKey(drinkName))
                    {
                        if (drinkPrice <= 0)
                        {
                            MessageBox.Show("Lütfen 0'dan ve Negatif değerlerden farklı bir fiyat giriniz.");

                        }
                        else
                        {
                            Drinks drinkAdd = new Drinks(drinkName, drinkPrice);
                            MyList.Drinks.Add(drinkName, drinkPrice);
                            MessageBox.Show("Başarı ile eklendi");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu içecek halihazırda mevcuttur!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir içecek adı giriniz!");
                }

            }
            catch (InvalidOperationException hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            drinkAdd();
        }
    }
}
