using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class diyetGunu
    {
        public int id { get; set; }
        public string sabah { get; set; }
        public string oglen { get; set; }
        public string aksam { get; set; }

        public diyetGunu(int _id,string _sabah, string _oglen, string _aksam)
        {
            id = _id;
            sabah = _sabah;
            oglen = _oglen;
            aksam = _aksam;
        }
    }
}
