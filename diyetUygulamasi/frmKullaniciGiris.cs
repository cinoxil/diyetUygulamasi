using diyetUygulamasi.entities;
using diyetUygulamasi.PanelIslem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetUygulamasi
{
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Texboxlardan bilgiler alınıp kullanıcı classı altındaki kullaniciGirisKontrol fonsiyonuna gönderiliyor.
            kisi.kullaniciGirisKontrol(txtKullaniciAdi.Text, txtSifre.Text,Application.OpenForms["frmKullaniciGiris"]);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            panelIslemleri.kayitOlPencereGoster();
        }
    }
}
