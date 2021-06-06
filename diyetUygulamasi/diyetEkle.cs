using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using diyetUygulamasi.PanelIslemleri;
using System;
using System.Linq;
using System.Windows.Forms;


namespace diyetUygulamasi
{
    public partial class diyetEkle : Form
    {
        public diyetEkle()
        {
            InitializeComponent();
        }

        private void urunlerim_Load(object sender, EventArgs e)
        {
            cmbGunler.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (panelIslemleri.girdiKontrol(Application.OpenForms["diyetEkle"]))
            {
                int kontrol = diyetKontrol(txtDiyet.Text, cmbGunler.SelectedIndex);

                if (kontrol == 1)
                {
                    diyet diyet = new diyet(txtDiyet.Text, txtSabah.Text, txtOgle.Text, txtAksam.Text, cmbGunler.SelectedIndex);
                    db.diyetler.Add(diyet);
                }
                else if (kontrol == 2)
                {
                    db.diyetler.Find(x => x.adi == txtDiyet.Text).diyetListe.Add(new diyetListesi(cmbGunler.SelectedIndex, txtSabah.Text, txtOgle.Text, txtAksam.Text));
                }

                db.diyetler.Find(x => x.adi == txtDiyet.Text).diyetListe.Sort(delegate (diyetListesi u1, diyetListesi u2) { return u1.diyetGunu.id.CompareTo(u2.diyetGunu.id); });

                txtSabah.Text = "";
                txtOgle.Text = "";
                txtAksam.Text = "";
            }

        }

        private int diyetKontrol(string ad, int index)
        {

            if (!(db.diyetler.Find(x => x.adi == ad) == null))
            {

                foreach (diyetListesi item in db.diyetler.Find(x => x.adi == ad).diyetListe)
                {
                    if (!(item.diyetGunu.id == index))
                    {

                        if ((db.diyetler.Find(x => x.adi == ad).diyetListe.Count <= 7))
                        {

                            return 2;
                        }
                        else

                        {

                            MessageBox.Show("Bu diyet turu daha once eklenmis");
                            return 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu gun daha once eklenmis");
                        return 0;
                    }
                }

                return 0;
            }
            else
            {
                return 1;
            }



        }

        private void txtSabah_Enter(object sender, EventArgs e)
        {
            txtSabah.Text = "";
        }

        private void txtOgle_Enter(object sender, EventArgs e)
        {
            txtOgle.Text = "";
        }

        private void txtAksam_Enter(object sender, EventArgs e)
        {
            txtAksam.Text = "";
        }
    }
}