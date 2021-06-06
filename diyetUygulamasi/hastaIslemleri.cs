using diyetUygulamasi.control;
using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace diyetUygulamasi
{
    public partial class hastaIslemleri : Form
    {
        public hastaIslemleri()
        {
            InitializeComponent();
        }

        private void hastaIslemleri_Load(object sender, EventArgs e)
        {

            dgHastalar.AllowUserToDeleteRows = false;

            dgHastalar.ColumnCount = 5;
            dgHastalar.Columns[0].Name = "TC";
            dgHastalar.Columns[1].Name = "Ad";
            dgHastalar.Columns[2].Name = "Soyad";
            dgHastalar.Columns[3].Name = "Hastalik";
            dgHastalar.Columns[4].Name = "Diyet";

            hastalariListele(dgHastalar);

            for (int i = 0; i < db.hastaliklar.Count; i++)
            {
                hastalik kontrol = db.hastaliklar[i];

                for (int j = 0; j < db.hastaliklar.Count; j++)
                {
                    if (j != i)
                    {
                        if (kontrol.adi == db.hastaliklar[j].adi)
                        {
                            db.hastaliklar.RemoveAt(j);
                        }

                    }

                }

            }

            for (int i = 0; i < db.diyetler.Count; i++)
            {
                diyet kontrol = db.diyetler[i];

                for (int j = 0; j < db.diyetler.Count; j++)
                {
                    if (j != i)
                    {
                        if (kontrol.adi == db.diyetler[j].adi)
                        {
                            db.diyetler.RemoveAt(j);
                        }

                    }

                }

            }

            cmbHastaliklar.DataSource = db.hastaliklar;
            cmbDiyetler.DataSource = db.diyetler;

        }

        public static void hastalariListele(DataGridView dg)
        {
            for (int i = 0; i < kullaniciKontrol.gecerliDiyetisyen.hastalar.Count; i++)
            {
                dg.Rows.Add(kullaniciKontrol.gecerliDiyetisyen.hastalar[i].tc,
                             kullaniciKontrol.gecerliDiyetisyen.hastalar[i].ad,
                             kullaniciKontrol.gecerliDiyetisyen.hastalar[i].soyad,
                             kullaniciKontrol.gecerliDiyetisyen.hastalar[i].hastalik,
                             kullaniciKontrol.gecerliDiyetisyen.hastalar[i].diyet);

            }
        }

        public string hastaTc;


        private void dgHastalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1) dgHastalar.Rows[e.RowIndex].Selected = true;
            //kullanıcıIdye bir numaralı indexdeki idyi atıyor.
            hastaTc = dgHastalar.Rows[e.RowIndex].Cells[0].Value.ToString();
            //paraIstekIdye sıfır numaralı indexdeki idyi atıyor.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            hasta hasta = kullaniciKontrol.gecerliDiyetisyen.hastalar.Where(x => x.tc == hastaTc).FirstOrDefault();
            hasta.hastalik.adi = cmbHastaliklar.SelectedItem.ToString();
            hasta.diyet = db.diyetler.Find(x => x.adi == cmbDiyetler.SelectedItem.ToString());
            dgHastalar.Rows.Clear();
            hastalariListele(dgHastalar);
        }

        private void btnRaporAl1_Click(object sender, EventArgs e)
        {
            List<diyetisyen> diyetisyenler = new List<diyetisyen>();
            var jsonVerisi = ""; //Null hatası vermemesi için boş default değer atıyor.
            jsonVerisi = File.ReadAllText(@".\Diyetisyenler.json"); //Kullanicilar.json okuyup içindekileri jsonVerisi değişkenine atıyor.

            if (jsonVerisi != "")
            {
                diyetisyenler = JsonConvert.DeserializeObject<List<diyetisyen>>(jsonVerisi);//jsonVerisini list kullanıcı tipine dönüştürüp kullancılar listesine atıyor.


            }

            hasta hasta = (diyetisyenler.Where(x => x.kullaniciAdi == kullaniciKontrol.gecerliDiyetisyen.kullaniciAdi).FirstOrDefault()
                    .hastalar.Where(a => a.tc == hastaTc).FirstOrDefault());


            reportClass.hasta = hasta;

            var rapor = new frmRapor();

            rapor.hasta = hasta;
            rapor.StartPosition = FormStartPosition.Manual;
            rapor.Location = new Point(330, 120);
            rapor.Show();

        }

        private void btnRaporAl2_Click(object sender, EventArgs e)
        {
            hasta hasta = kullaniciKontrol.gecerliDiyetisyen.hastalar.Where(x => x.tc == hastaTc).FirstOrDefault();
            reportClass.hasta = hasta;

            var rapor = new frmRapor();
            GroupBox gbKisisel = (GroupBox)rapor.Controls["gbKisisel"];
            GroupBox gbDiyet = (GroupBox)rapor.Controls["gbDiyet"];

            gbKisisel.Location = new Point(12, 367);
            gbDiyet.Location = new Point(12, 12);

            rapor.hasta = hasta;
            rapor.StartPosition = FormStartPosition.Manual;
            rapor.Location = new Point(330, 120);
            rapor.Show();
        }
    }
}