using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220319_HamburgerSiparisSimulasyonu
{
    public class Hamburger
    {
        
        public Hamburger(string burgerName, double burgerPrice)
        {
            HamburgerName = burgerName;
            HamburgerPrice = burgerPrice;
        }

        public bool IsChickenMeat { get; set; }
        public int MeatWeight { get; set; }
        public string Material { get; set; }

        private string _hamburgerName;
        public string HamburgerName
        {
            get
            {
                return _hamburgerName;
            }
            set
            {
                _hamburgerName = value;

            }
        }
        public double _hamburgerPrice;
        public double HamburgerPrice
        {
            get
            {
                return _hamburgerPrice;
            }
            set
            {
                _hamburgerPrice = value;
            }

        }
    }
}

