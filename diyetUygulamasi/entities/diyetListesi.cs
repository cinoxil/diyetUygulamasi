using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class diyetListesi
    {
        public diyetGunu diyetGunu { get; set; }

        public diyetListesi(int _id,string _sabah, string _oglen, string _aksam)
        {
            diyetGunu dg = new diyetGunu(_id,_sabah,_oglen,_aksam);
            diyetGunu = dg;
        }

    }
}
