using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220319_HamburgerSiparisSimulasyonu
{
    public partial class frmSiparisOlustur : Form
    {

        public frmSiparisOlustur()
        {
            InitializeComponent();

        }

        List<CheckBox> ChckBoxExtraMaterial = new List<CheckBox>();
        #region Hamburgers
        void Hamburgerler()//Default olarak hamburger ekleme,Her hamburger instance alınmıştır ve hamburger listesine atılmıştır
        {
            Hamburger SteakHouseBurger = new Hamburger("Steak House Burger", 24.75);
            Hamburger WhopperBurger = new Hamburger("Whopper Hamburger", 25.25);
            Hamburger ChildBurger = new Hamburger("Child Burger", 18.25);
            Hamburger ChickenBurger = new Hamburger("Chicken Hamburger", 21.00);
            Hamburger CaesarBurger = new Hamburger("Caesar Burger", 27.50);


            MyList.Hamburgers.Add(SteakHouseBurger.HamburgerName, SteakHouseBurger.HamburgerPrice);
            MyList.Hamburgers.Add(WhopperBurger.HamburgerName, WhopperBurger.HamburgerPrice);
            MyList.Hamburgers.Add(ChildBurger.HamburgerName, ChildBurger.HamburgerPrice);
            MyList.Hamburgers.Add(ChickenBurger.HamburgerName, ChildBurger.HamburgerPrice);
            MyList.Hamburgers.Add(CaesarBurger.HamburgerName, CaesarBurger.HamburgerPrice);

        }
        internal void HamburgerComboBox()
        {
            try
            {
                cmbMenü.Items.Clear();
                foreach (string hamburger in MyList.Hamburgers.Keys)
                {
                    cmbMenü.Items.Add(hamburger);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

            }


        } // Hamburgerlerin Combobox'a eklenmesi
        internal double HamburgerPrice()
        {
            double fiyat = 0;
            try
            {

                foreach (string hamburger in MyList.Hamburgers.Keys)
                {
                    if (hamburger == cmbMenü.Text)
                    {
                        MyList.Hamburgers.TryGetValue(hamburger, out double hamburgerFiyat);
                        fiyat = hamburgerFiyat;
                    }
                }
            }
            catch (ArgumentNullException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return fiyat;
        }
        #endregion
        #region Drinks
        void Drinks()
        {
            Drinks Cola = new Drinks("Cola", 5.5);
            Drinks Fanta = new Drinks("Fanta", 5.5);
            Drinks Sprite = new Drinks("Sprite", 5.5);
            Drinks IceTea = new Drinks("Ice Tea", 5.5);

            MyList.Drinks.Add(Cola.DrinksName, Cola.DrinksPrice);
            MyList.Drinks.Add(Fanta.DrinksName, Fanta.DrinksPrice);
            MyList.Drinks.Add(Sprite.DrinksName, Sprite.DrinksPrice);
            MyList.Drinks.Add(IceTea.DrinksName, IceTea.DrinksPrice);
        }
        internal void DrinksComboBox()
        {
            try
            {
                cmBoxDrink.Items.Clear();
                foreach (string drink in MyList.Drinks.Keys)
                {
                    cmBoxDrink.Items.Add(drink);
                }
            }
            catch (ArgumentNullException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        internal double DrinksPrice()
        {
            double fiyat = 0;
            try
            {

                foreach (string drink in MyList.Drinks.Keys)
                {
                    if (drink == cmBoxDrink.Text)
                    {
                        MyList.Drinks.TryGetValue(drink, out double drinkFiyat);
                        fiyat = drinkFiyat;
                    }
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

            return fiyat;
        }
        #endregion
        #region Extralar
        void Extra()
        {
            Extra Ketcap = new Extra("Ketçap", 1);
            Extra Mayonez = new Extra("Mayonez", 1);
            Extra RanchSos = new Extra("Ranch Sos", 1);
            Extra BarbeküSos = new Extra("Barbekü Sos", 1);

            MyList.Extras.Add(Ketcap.ExtraName, Ketcap.ExtraPrice);
            MyList.Extras.Add(Mayonez.ExtraName, Mayonez.ExtraPrice);
            MyList.Extras.Add(RanchSos.ExtraName, RanchSos.ExtraPrice);
            MyList.Extras.Add(BarbeküSos.ExtraName, BarbeküSos.ExtraPrice);
        }
        internal void ExtraCheckBox()
        {

            flpEkstraSos.Controls.Clear();
            foreach (string ex in MyList.Extras.Keys)
            {
                CheckBox exCheckBox = new CheckBox();
                exCheckBox.Text = ex;
                ChckBoxExtraMaterial.Add(exCheckBox);
                flpEkstraSos.Controls.Add(exCheckBox);
            }


        }
        string siparis = "";
        internal double ExtraPrice()
        {
            double fiyat = 0;

            siparis = "";
            foreach (CheckBox check in flpEkstraSos.Controls)
            {

                if (check.Checked)
                {
                    foreach (string ex in MyList.Extras.Keys)
                    {
                        if (ex == check.Text)
                        {
                            siparis += check.Text + ",";
                            MyList.Extras.TryGetValue(ex, out double extraFiyat);
                            fiyat += extraFiyat;
                        }
                    }

                }
            }



            return fiyat;
        }
        #endregion
        #region Menu
        double fiyat = 0;

        //void MenuDeneme(out int adet, out string seciliHamburger, out string seciliIcecek, out Menu menu)
        //{
        //    adet = 0;
        //    seciliHamburger = "";
        //    seciliIcecek = "";
        //    menu = new Menu();

        //    if (cmbMenü.SelectedItem != null)
        //    {
        //        if (cmBoxDrink.SelectedItem != null)
        //        {
        //            if (adet <= 0)
        //            {
        //                MessageBox.Show("Lütfen sıfır ve negatif sayıdan farklı bir adet giriniz!");
        //            }
        //            else
        //            {
        //                try
        //                {

        //                    adet = int.Parse(txtBoxMenüAdet.Text);
        //                    seciliHamburger = cmbMenü.SelectedItem.ToString();
        //                    seciliIcecek = cmBoxDrink.SelectedItem.ToString();

        //                    Hamburger MyHamburger = new Hamburger(seciliHamburger, HamburgerPrice());
        //                    Drinks MyDrinks = new Drinks(seciliIcecek, DrinksPrice());
        //                    menu = new Menu(MyHamburger, MyDrinks, adet, rdButtonSmall, rdButtonMiddle, rdButtonBig, datetime: DateTime.Now);
        //                    // string yeni2GUID = System.Guid.NewGuid().ToString();

        //                }
        //                catch (ArgumentNullException)
        //                {
        //                    MessageBox.Show("Lütfen bir tam sayı giriniz !");
        //                }
        //                catch (FormatException)
        //                {
        //                    MessageBox.Show("Lütfen bir tam sayı giriniz !");
        //                }
        //                catch (OverflowException hata)
        //                {
        //                    MessageBox.Show(hata.Message);
        //                }
        //                catch (NullReferenceException)
        //                {
        //                    MessageBox.Show("Hamburger veya İçeceği eksik girdiniz !");
        //                }
        //                catch (Exception hata)
        //                {
        //                    MessageBox.Show(hata.Message);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Lütfen bir içecek seçiniz !");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen bir hamburger seçiniz !");
        //    }

        //}
        //void MenuFiyat()
        //{
        //    MenuDeneme(out int adet, out string seciliHamburger, out string seciliIcecek, out Menu menu);

        //    if (adet <= 0)
        //    {
        //        MessageBox.Show("Lütfen sıfır ve negatif sayıdan farklı bir adet giriniz!");
        //    }
        //    else
        //    {

        //        menu.SizesMethod(rdButtonSmall, rdButtonMiddle, rdButtonBig, out double f);
        //        double hamburgerPriceNumber = HamburgerPrice() * adet;
        //        double DrinkPriceNumber = DrinksPrice() * adet;
        //        double SizePrice = f * adet;
        //        double ExtPrice = ExtraPrice() * adet;
        //        fiyat += hamburgerPriceNumber + DrinkPriceNumber + SizePrice + ExtPrice;
        //    }


        //}
        //void MenuYarat()
        //{

        //    MenuDeneme(out int adet, out string seciliHamburger, out string seciliIcecek, out Menu menu);
        //    MenuFiyat();
        //    MyList.Menus.Add(menu, fiyat);
        //    lblPrice.Text = fiyat.ToString(); //Fiyatın ekrana yazılması
        //    lstBoxMenu.Items.Add(menu.SelectedHamburger.HamburgerName + "," + menu.SelectedDrink.DrinksName + "," + menu.Size + "," + menu.Adet + "," + siparis + "," + menu.DateTime);
        //    MyList.OrderMenu.Add(menu.SelectedHamburger.HamburgerName + "," + menu.SelectedDrink.DrinksName + "," + menu.Size + "," + menu.Adet + "," + siparis + "," + menu.DateTime);

        //    MessageBox.Show("Menü Eklendi");

        //}
        void MenuCreated()
        {

            if (cmbMenü.SelectedItem != null)
            {
                if (cmBoxDrink.SelectedItem != null)
                {
                    try
                    {

                        int adet = int.Parse(txtBoxMenüAdet.Text);
                        string seciliHamburger = cmbMenü.SelectedItem.ToString();
                        string seciliIcecek = cmBoxDrink.SelectedItem.ToString();
                        if (adet <= 0)
                        {
                            MessageBox.Show("Lütfen sıfır ve negatif sayıdan farklı bir adet giriniz!");
                        }
                        else
                        {
                            Hamburger MyHamburger = new Hamburger(seciliHamburger, HamburgerPrice());
                            Drinks MyDrinks = new Drinks(seciliIcecek, DrinksPrice());
                            Menu menu = new Menu(MyHamburger, MyDrinks, adet, rdButtonSmall, rdButtonMiddle, rdButtonBig, datetime: DateTime.Now);
                            // string yeni2GUID = System.Guid.NewGuid().ToString();
                            menu.SizesMethod(rdButtonSmall, rdButtonMiddle, rdButtonBig, out double f);


                            double hamburgerPriceNumber = HamburgerPrice() * adet;
                            double DrinkPriceNumber = DrinksPrice() * adet;
                            double SizePrice = f * adet;
                            double ExtPrice = ExtraPrice() * adet;
                            fiyat += hamburgerPriceNumber + DrinkPriceNumber + SizePrice + ExtPrice;

                            //Fiyat hesaplanması

                            MyList.Menus.Add(menu, fiyat);
                            lblPrice.Text = fiyat.ToString(); //Fiyatın ekrana yazılması
                            lstBoxMenu.Items.Add(menu.SelectedHamburger.HamburgerName + "," + menu.SelectedDrink.DrinksName + "," + menu.Size + "," + menu.Adet + "," + siparis + "," + menu.DateTime);
                            MyList.OrderMenu.Add(menu.SelectedHamburger.HamburgerName + "," + menu.SelectedDrink.DrinksName + "," + menu.Size + "," + menu.Adet + "," + siparis + "," + menu.DateTime);

                            MessageBox.Show("Menü Eklendi");

                        }

                    }
                    catch (ArgumentNullException)
                    {
                        MessageBox.Show("Lütfen bir tam sayı giriniz !");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Lütfen bir tam sayı giriniz !");
                    }
                    catch (OverflowException hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Hamburger veya İçeceği eksik girdiniz !");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir içecek seçiniz !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir hamburger seçiniz !");
            }


        }

        void MenuRemove()
        {
            try
            {
                string lstBoxSelectedWord = lstBoxMenu.SelectedItem.ToString();
                MyList.OrderMenu.Remove(lstBoxSelectedWord);

                string[] siparisKaldir = new string[20];
                siparisKaldir = lstBoxSelectedWord.Split(',');
                int adet = int.Parse(siparisKaldir[3]);
                for (int i = 0; i < siparisKaldir.Length; i++)
                {
                    foreach (string e in MyList.Extras.Keys)
                    {
                        if (siparisKaldir[i] == e)
                        {
                            MyList.Extras.TryGetValue(e, out double extraFiyat);
                            fiyat -= (extraFiyat * adet);
                        }
                    }
                    foreach (Menu s in MyList.Menus.Keys)
                    {
                        if (s.DateTime == siparisKaldir[i])
                        {
                            if (s.SelectedHamburger.HamburgerName == siparisKaldir[0])
                            {
                                fiyat = fiyat - (s.SelectedHamburger.HamburgerPrice * adet);

                            }
                            if (s.SelectedDrink.DrinksName == siparisKaldir[1])
                            {
                                fiyat = fiyat - (s.SelectedDrink.DrinksPrice * adet);
                            }
                            string[] Boyutlar = Enum.GetNames(typeof(Menu.Sizes));
                            foreach (string boyut in Boyutlar)
                            {
                                if (siparisKaldir[2] == boyut)
                                {
                                    s.SizesMethod(boyut, out double f);
                                    fiyat -= (f * adet);
                                }
                            }
                        }
                    }
                }

            }

            catch (ArgumentNullException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch (ArgumentException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch (FormatException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch (OverflowException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            lblPrice.Text = fiyat.ToString();
            lstBoxMenu.Items.Remove(lstBoxMenu.SelectedItem);


        }
        #endregion
        void OrderCompleted()
        {
            for (int i = 0; i <= MyList.OrderMenu.Count - 1; i++)
            {
                MyList.AllOrder.Add(MyList.OrderMenu[i]);
            }

        }
        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
             MenuCreated();
            //MenuYarat();
        }
        private void frmSiparisOlustur_Load(object sender, EventArgs e)
        {
            Hamburgerler();
            HamburgerComboBox();

            Drinks();
            DrinksComboBox();

            Extra();
            ExtraCheckBox();
            lstBoxMenu.HorizontalScrollbar = true;



        }
        private void btnSiparisKaldir_Click(object sender, EventArgs e)
        {
            if (lstBoxMenu.SelectedItem != null)
            {
                MenuRemove();
                MessageBox.Show("Menü Kaldırıldı");
            }
        }
        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {


            OrderCompleted();
            MyList.fiyatım[0] = fiyat;
            MyList.OrderMenu.Clear();
            lstBoxMenu.Items.Clear();
            fiyat = 0;
            lblPrice.Text = "";
        }

        #endregion




    }
}
