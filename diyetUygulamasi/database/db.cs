using diyetUygulamasi.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.database
{
    public static class db
    {
        
        public static diyetisyen gecerliKullanici = db.diyetsiyenler.Where(x => x.kullaniciAdi == "ugur").FirstOrDefault();

        public static List<diyetisyen> diyetsiyenler = new List<diyetisyen>();
    }
}
