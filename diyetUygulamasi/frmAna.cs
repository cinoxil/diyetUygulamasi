using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using diyetUygulamasi.PanelIslemleri;
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

            hastalik hastalik = new hastalik("Obez");
            db.hastaliklar.Add(hastalik);
            hastalik = new hastalik("Colyak");
            db.hastaliklar.Add(hastalik);
            hastalik = new hastalik("Seker");
            db.hastaliklar.Add(hastalik);

            diyet diyet = new diyet("Akdeniz");
            db.diyetler.Add(diyet);
            diyet = new diyet("Gluten Free");
            db.diyetler.Add(diyet);
            diyet = new diyet("Deniz Urunleri");
            db.diyetler.Add(diyet);
            diyet = new diyet("Yesillikler Dunyasi");
            db.diyetler.Add(diyet);



            diyetisyen diyetisyen = new diyetisyen("23587421548", "ugur", "adw", "ugur", "123");
            db.admin.kisiEkle(diyetisyen);

        
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
            paraEkle.Location = new Point(133, 75);
            panelIslemleri.pencereleriKapat();
            paraEkle.Show();
        }

        private void btnHastalikEkle_Click(object sender, EventArgs e)
        {
            var satinAl = new hastalikEkle();
            satinAl.MdiParent = this; //Form1i satinAl formunun MdiParrentı olarak belirliyor.
            satinAl.StartPosition = FormStartPosition.Manual;
            satinAl.Location = new Point(350, 170);
            panelIslemleri.pencereleriKapat();
            satinAl.Show();
        }

        private void btnDiyetEkle_Click(object sender, EventArgs e)
        {
            var urunlerim = new diyetEkle();
            urunlerim.MdiParent = this; //Form1i urunlerim formunun MdiParrentı olarak belirliyor.
            urunlerim.StartPosition = FormStartPosition.Manual;
            urunlerim.Location = new Point(350, 170);
            panelIslemleri.pencereleriKapat();
            urunlerim.Show();
        }



    }
}

    
