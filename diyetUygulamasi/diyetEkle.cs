using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using System;
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
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (diyetKontrol(txtDiyet.Text))
            {
                diyet diyet = new diyet(txtDiyet.Text);
                db.diyetler.Add(diyet);
            }
        }

        private bool diyetKontrol(string ad)
        {
            
            if (!(db.diyetler.Find(x => x.adi == ad) == null))
            {
                MessageBox.Show("Bu diyet turu daha once eklenmis");
                return false;
            }
            else
            {
                return true;
            }



        }
    }
}