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
    public partial class MenuBilgileri : Form
    {
        public MenuBilgileri()
        {
            InitializeComponent();
        }
        public void Hamburger()
        {
            Menu MenüEkle = new Menu();
            decimal s = nUDFiyat.Value;
            double s1 = Convert.ToDouble(s);
            MenüEkle.HamburgerEkle(txtBoxMenü.Text, s1);
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSiparisOlustur fr = new frmSiparisOlustur();
            fr.Show();
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hamburger();
            
        }
    }
}
