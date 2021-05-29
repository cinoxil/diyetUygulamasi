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

        public static admin admin = new admin("45896214589", "kadir", "can", "kadir", "123");
        public static List<diyetisyen> diyetisyenler = new List<diyetisyen>();

        public static List<hastalik> hastaliklar = new List<hastalik>();
        public static List<diyet> diyetler = new List<diyet>();



        
    }
}
