using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class diyet
    {
        public string adi { get; set; }
        public List<string> diyetListe { get; set; }

        public diyet(string _ad)
        {
            adi = _ad;
        }

        public override string ToString()
        {
            return adi;
        }
    }
}