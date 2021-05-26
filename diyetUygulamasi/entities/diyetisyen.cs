using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class diyetisyen : kisi
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public List<hasta> hastalar { get; set; }


        public void hastaEkle(hasta hasta)
        {
            if (hastalar != null)
            {
                hastalar.Add(hasta);
            }
            else
            {
                hastalar = new List<hasta>();
                hastalar.Add(hasta);
            }


        }
    }
}