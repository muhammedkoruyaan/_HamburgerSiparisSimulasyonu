using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220319_HamburgerSiparisSimulasyonu
{
    public class Drinks
    {
        public Drinks(string DrinkN,double DrinkP)
        {
            DrinksName = DrinkN;
            DrinksPrice = DrinkP;
        }
        public string DrinksName {get; set;}
        public double DrinksPrice {get;set;}

    }
}
