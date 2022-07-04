using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220319_HamburgerSiparisSimulasyonu
{
  public static class MyList
    {
        public static Dictionary<Menu, double> Menus = new Dictionary<Menu, double>();
        public static Dictionary<string,double> Hamburgers = new Dictionary<string,double>();
        public static Dictionary<string,double> Drinks = new Dictionary<string,double>();
        public static Dictionary<string,double> Extras = new Dictionary<string, double>();
        public static List<string> OrderMenu = new List<string>();
        public static List<string> AllOrder = new List<string>();
        public static double[] fiyatım = new double[1];
    }
}
