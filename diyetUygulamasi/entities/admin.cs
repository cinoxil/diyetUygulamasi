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

        public admin(string _tc, string _ad, string _soyad, string _id, string _sifre) 
        {
            tc = _tc;
            ad = _ad;
            soyad = _soyad;
            kullaniciAdi = _id;
            sifre = _sifre;
            isAdmin = true;
        }

        public void kisiEkle(kisi kisi)
        {
            db.diyetisyenler.Add((diyetisyen)kisi);
            
        }
            
    }
}