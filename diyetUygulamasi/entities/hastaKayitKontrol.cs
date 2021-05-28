using diyetUygulamasi.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public static class hastaKayitKontrol
    {
        public static bool isHastaKayitli(hasta hasta)
        {
            
            hasta bulunanHasta = null;
            foreach (diyetisyen item in db.diyetisyenler)
            {
                bulunanHasta = item.hastalar.Where(x => x.tc == hasta.tc).FirstOrDefault();
            }
            
            if (bulunanHasta != null)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
