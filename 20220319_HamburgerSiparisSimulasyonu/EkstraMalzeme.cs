using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20220319_HamburgerSiparisSimulasyonu
{
    public class EkstraMalzeme:Menu
    {
      public List<string> soslarList = new List<string>();
        public List<string> Soslar()
        {
            soslarList.Add("Ketçap");
            soslarList.Add("Mayonez");
            soslarList.Add("Hardal Sos");
            soslarList.Add("Ranch Sos");
            soslarList.Add("Barbekü");
            return soslarList;
        }
        public List<string> SosEkle(string SosName)
        {
            soslarList.Add(SosName);
            return soslarList;
        }

    }
}
