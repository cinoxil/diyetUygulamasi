using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetUygulamasi.entities
{
    public class kisi
    {
        private string _tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }


        public string tc
        {
            get
            {
                return this._tc;
            }
            set
            {
                if (value.Length == 11)
                {
                    this._tc = value;
                }
                else
                {
                    MessageBox.Show("TC Kimlik No 11 haneli olmalidir");
                }
            }
        }
    }
}