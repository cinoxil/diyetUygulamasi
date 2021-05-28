using diyetUygulamasi.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class admin : kisi, IEkleme
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public admin() 
        {
            isAdmin = true;
        }

        public void kisiEkle(kisi kisi)
        {
            db.diyetsiyenler.Add((diyetisyen)kisi);
        }
            
            
    }
}