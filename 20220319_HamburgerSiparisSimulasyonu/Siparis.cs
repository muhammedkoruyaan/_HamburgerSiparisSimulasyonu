using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220319_HamburgerSiparisSimulasyonu
{
     abstract class Siparis
    {
        public enum Dimensions
        {
            Küçük, Orta, Büyük
        }
            
        public abstract string MenuName { get; set; }
        public  int OrderNumber { get; set; }
        public abstract Dimensions Dimension { get; set; }
        public abstract double Price();
       


    }
}
