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
    public partial class _20220319_SiparisBilgileri : Form
    {
        public _20220319_SiparisBilgileri()
        {

          
            InitializeComponent();
        }
        void Ekle()
        {
            
            for (int i = 0; i <= MyList.AllOrder.Count - 1; i++)
            {
                lstBoxSiparisBilgileri.Items.Add((MyList.AllOrder[i]).ToString());
            }
        }
       

        private void btnSiparisGüncelle_Click(object sender, EventArgs e)
        {
            lstBoxSiparisBilgileri.Items.Clear();
            
            Ekle();
            lstBoxSiparisBilgileri.Items.Add("FİYAT : " + MyList.fiyatım[0]);

        }
    }
}
