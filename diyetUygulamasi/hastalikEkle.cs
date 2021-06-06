using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using diyetUygulamasi.PanelIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace diyetUygulamasi
{
    public partial class hastalikEkle : Form
    {
        public hastalikEkle()
        {
            InitializeComponent();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (panelIslemleri.girdiKontrol(Application.OpenForms["hastalikEkle"]))
            {
                if (hastalikKontrol(txtHastalik.Text))
                {
                    hastalik hastalik = new hastalik(txtHastalik.Text);
                    db.hastaliklar.Add(hastalik);
                }
            }
        }

        private bool hastalikKontrol(string ad)
        {
            if (!(db.hastaliklar.Find(x => x.adi == ad) == null))
            {
                MessageBox.Show("Bu hastalik daha once eklenmis");
                return false;
            }
            else
            {
                return true;
            }



        }
    }
}