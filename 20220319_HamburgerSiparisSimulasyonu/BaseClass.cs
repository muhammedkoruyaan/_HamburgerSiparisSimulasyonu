using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220319_HamburgerSiparisSimulasyonu
{
    public abstract class BaseClass
    {
        public  int OrderNumber { get; set; }
        public double Price()
        {
            return 1;
        }
    }
}
