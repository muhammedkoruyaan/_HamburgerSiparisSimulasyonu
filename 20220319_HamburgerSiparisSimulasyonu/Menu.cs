using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace _20220319_HamburgerSiparisSimulasyonu
{

    public class Menu : BaseClass
    {
        public Menu(Hamburger SelectedH,Drinks SelectedD,int Selectednumber,RadioButton rdBtnK, RadioButton rdBtnM, RadioButton rdBtnB,DateTime datetime)
        {
            SelectedHamburger = SelectedH;
            SelectedDrink = SelectedD;
            SizesMethod(rdBtnK, rdBtnM, rdBtnB);
            Adet = Selectednumber;
            DateTime = datetime.ToString();
            
        }
        public Menu()
        {
           
        }

        public enum Sizes
        {
            Küçük, Orta=2, Büyük=4
        }
        public Hamburger SelectedHamburger { get; set; }
        public Drinks SelectedDrink { get; set; }
        private Sizes _size;
        public Sizes Size
        {
            get
            {
                return _size;
            }
            set
            {
                switch (value)
                {
                    case Sizes.Küçük: _size = Sizes.Küçük; break;
                    case Sizes.Orta: _size = Sizes.Orta; break;
                    case Sizes.Büyük: _size = Sizes.Büyük; break;
                }
            }
        }
        public void SizesMethod(RadioButton firstRadio, RadioButton secondRadio, RadioButton ThirdRadio,out double fiyat)
        {
            fiyat = 0;
            if (firstRadio.Checked == true)
            {
               Size = (Sizes)Enum.Parse(typeof(Sizes), firstRadio.Text);
            }
            else if (secondRadio.Checked == true)
            {
              Size = (Sizes)Enum.Parse(typeof(Sizes), secondRadio.Text);
              fiyat += (double)Sizes.Orta;
            }
            else if (ThirdRadio.Checked == true)
            {
              Size = (Sizes)Enum.Parse(typeof(Sizes), ThirdRadio.Text);
              fiyat += (double)Sizes.Büyük;
            }
        }
        public void SizesMethod(RadioButton firstRadio, RadioButton secondRadio, RadioButton ThirdRadio)
        {
            if (firstRadio.Checked == true)
            {
                Size = (Sizes)Enum.Parse(typeof(Sizes), firstRadio.Text);
            }
            else if (secondRadio.Checked == true)
            {
                Size = (Sizes)Enum.Parse(typeof(Sizes), secondRadio.Text);
            }
            else if (ThirdRadio.Checked == true)
            {
                Size = (Sizes)Enum.Parse(typeof(Sizes), ThirdRadio.Text);
            }
        }
        public void SizesMethod(string Boyut,out double fiyat)
        {
            fiyat = 0;
            Size = (Sizes)Enum.Parse(typeof(Sizes), Boyut);
            if (Size==Sizes.Orta)
            {
                fiyat = 2;
            }
            if (Size == Sizes.Büyük)
            {
                fiyat = 4;
            }
        }
        private int _adet;
        public int Adet
        {
            get
            {
                return _adet;
            }
            set
            {
                _adet = value;

            }
        }
        public string DateTime { get; set; }
      
    }
}
