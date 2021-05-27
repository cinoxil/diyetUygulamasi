using diyetUygulamasi.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class admin : IEkleme
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }


        public void kisiEkle(kisi kisi)
        {
            if (db.diyetsiyenler != null)
            {
                db.diyetsiyenler.Add((diyetisyen)kisi);
            }
            else
            {
                db.diyetsiyenler = new List<diyetisyen>();
                db.diyetsiyenler.Add((diyetisyen)kisi);
            }
        }
    }
}