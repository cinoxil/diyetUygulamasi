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

        public static string gecerliKullanici;

        public static admin admin = new admin("45896214589", "kadir", "can", "kadir", "123");
        public static List<diyetisyen> diyetisyenler = new List<diyetisyen>();

        //public static diyetisyen gecerliKullanici = diyetsiyenler.Where(x => x.kullaniciAdi == "ugur").FirstOrDefault();
    }
}
