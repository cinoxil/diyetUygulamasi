using diyetUygulamasi.database;
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
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var kullaniciKontrol = new frmKullaniciGiris();
            kullaniciKontrol.MdiParent = this; //Form1i frmKullanıcıGiris formunun MdiParrentı olarak belirliyor.
            kullaniciKontrol.StartPosition = FormStartPosition.Manual;
            kullaniciKontrol.Location = new Point(280, 130);
            kullaniciKontrol.Show();
            


            //admin a = new admin();
            db.admin.kisiEkle(new diyetisyen("12375965214", "ugur", "ongun", "ugur", "123"));

            hasta hasta = new hasta("54896312458", "okan", "erciyas");

            diyetisyenFacade.hastaEkle(hasta);
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            
            panelIslemleri.pencereleriKapat();
            panelIslemleri.oturumuKapat();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            var frmEkle = new hastaEkle();
            frmEkle.MdiParent = this; //Form1i frmEkle formunun MdiParrentı olarak belirliyor.
            frmEkle.StartPosition = FormStartPosition.Manual;
            frmEkle.Location = new Point(330, 120);
            panelIslemleri.pencereleriKapat();
            frmEkle.Show();
        }

        private void btnHastaIslemleri_Click(object sender, EventArgs e)
        {
            var paraEkle = new hastaIslemleri();
            paraEkle.MdiParent = this; //Form1i paraEkle formunun MdiParrentı olarak belirliyor.
            paraEkle.StartPosition = FormStartPosition.Manual;
            paraEkle.Location = new Point(300, 160);
            panelIslemleri.pencereleriKapat();
            paraEkle.Show();
        }

        private void btnHastalikEkle_Click(object sender, EventArgs e)
        {
            var satinAl = new hastalikEkle();
            satinAl.MdiParent = this; //Form1i satinAl formunun MdiParrentı olarak belirliyor.
            satinAl.StartPosition = FormStartPosition.Manual;
            satinAl.Location = new Point(125, 80);
            panelIslemleri.pencereleriKapat();
            satinAl.Show();
        }

        private void btnDiyetEkle_Click(object sender, EventArgs e)
        {
            var urunlerim = new diyetEkle();
            urunlerim.MdiParent = this; //Form1i urunlerim formunun MdiParrentı olarak belirliyor.
            urunlerim.StartPosition = FormStartPosition.Manual;
            urunlerim.Location = new Point(275, 75);
            panelIslemleri.pencereleriKapat();
            urunlerim.Show();
        }



    }
}

    
