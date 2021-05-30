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
        public List<diyetListesi> diyetListe = new List<diyetListesi>();

        public diyet(string _ad, string _sabah, string _oglen, string _aksam,int _id)
        {
            adi = _ad;
            diyetListesi dl = new diyetListesi(_id,_sabah, _oglen, _aksam);
            diyetListe.Add(dl);
        }
            
            

        public override string ToString()
        {
            return adi;
        }
    }
}