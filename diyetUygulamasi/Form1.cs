using diyetUygulamasi.database;
using diyetUygulamasi.entities;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            admin a = new admin();
            a.kisiEkle(new diyetisyen("12375965214", "ugur", "ongun","ugur","123"));

            diyetisyen diyetisyen = db.diyetsiyenler.Where(x => x.kullaniciAdi == "ugur").FirstOrDefault();

            diyetisyen.kisiEkle(new hasta("54896312458", "okan", "erciyas"));
        }
    }
}
