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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        frmSiparisOlustur SiparisEkle = new frmSiparisOlustur();
        _20220319_SiparisBilgileri siparisBilgileriForm = new _20220319_SiparisBilgileri();
        HamburgerEkle menüForm = new HamburgerEkle();
        EkstraMalzemeEkle ekstraForm= new EkstraMalzemeEkle();
        DrinksAdd ıcecekEkleForm = new DrinksAdd();

        void FormlarıSakla() 
        {
            SiparisEkle.Hide();
            menüForm.Hide();
            ekstraForm.Hide();
            ıcecekEkleForm.Hide();
            

        }
        
        
        
        private void BaseForm_Load(object sender, EventArgs e)
        {
            SiparisEkle.MdiParent = this;
            FormlarıSakla();
            SiparisEkle.Show();
            
        }
        private void menüBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menüForm.MdiParent = this;
            FormlarıSakla();
            menüForm.Show();

        }
        private void ekstraMalzemeBilgisi_Click(object sender, EventArgs e)
        {
            ekstraForm.MdiParent = this;
            FormlarıSakla();
            ekstraForm.Show();

        }
        private void siparisBilgileri_Click(object sender, EventArgs e)
        {
           
            siparisBilgileriForm.MdiParent = this;
           
            FormlarıSakla();
            siparisBilgileriForm.Show();

        }
        private void siparişEkleToStMe_Click(object sender, EventArgs e)
        {
            SiparisEkle.MdiParent = this;
            FormlarıSakla();
            SiparisEkle.HamburgerComboBox();
            SiparisEkle.DrinksComboBox();
            SiparisEkle.ExtraCheckBox();
            SiparisEkle.Show();
        }
        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ıcecekEkleForm.MdiParent = this;
            FormlarıSakla();
            ıcecekEkleForm.Show();

        }
    }
}
