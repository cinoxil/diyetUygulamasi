using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class hasta : kisi
    {
        public List<hastalik> hastalik { get; set; }
        public diyet diyet { get; set; }

        public hasta(string _tc, string _ad, string _soyad)
        {
            tc = _tc;
            ad = _ad;
            soyad = _soyad;
        }


    }
}