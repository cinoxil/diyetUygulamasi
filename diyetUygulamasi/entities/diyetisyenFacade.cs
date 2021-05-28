using diyetUygulamasi.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public static class diyetisyenFacade
    {
        public static void hastaEkle(hasta hasta)
        {
            if (hastaKayitKontrol.isHastaKayitli(hasta))
            {
                db.gecerliKullanici.kisiEkle(hasta);
            }
        }
            

    }
}
