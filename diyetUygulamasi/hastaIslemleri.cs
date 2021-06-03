using diyetUygulamasi.control;
using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using System;
using System.Drawing;
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ////paraMiktar boş mu ve textBoxSayiControl sayı mı diye kontrol ediyor.
            //if (!string.IsNullOrEmpty(txtParaMiktar.Text) && textBoxSayiControl())
            //    new paraIstek(int.Parse(txtParaMiktar.Text),cmb_paraBirimi.Text);
            ////Eğer değilse hata veriyor.
            //else
            //    MessageBox.Show("Lütfen eklemek istediğiniz miktarı giriniz");
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

            cmbHastaliklar.DataSource = db.hastaliklar;
            cmbDiyetler.DataSource = db.diyetler;

        }

        //ParaMiktar sayı mı diye kontrol ediyor.
        //private bool textBoxSayiControl()
        //{
        //    //txtParaMiktar texboxu sayı mı diye bakıyor ve sayı ise txtKontrol değişkenine true yazıyor.
        //    var txtKontrol = txtParaMiktar.Text.All(char.IsDigit);
        //    //Eğer sayı değilse hata veriyor.
        //    if (!txtKontrol) MessageBox.Show("Lütfen sayısal değer giriniz");

        //    return txtKontrol;
        //}

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

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            hasta hasta = kullaniciKontrol.gecerliDiyetisyen.hastalar.Where(x => x.tc == hastaTc).FirstOrDefault();
            reportClass.hasta = hasta;

            var reportView = new reportView();
            reportView.hastaTc = hastaTc;
            reportView.hasta = hasta;
            reportView.StartPosition = FormStartPosition.Manual;
            reportView.Location = new Point(330, 120);
            reportView.Show();

        }


    }
}