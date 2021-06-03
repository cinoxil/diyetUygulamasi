using diyetUygulamasi.control;
using diyetUygulamasi.entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyetUygulamasi
{
    public partial class reportView : Form
    {
        public reportView()
        {
            InitializeComponent();
        }

        public string hastaTc;
        public hasta hasta;
            
        private void reportView_Load(object sender, EventArgs e)
        {
            
            



            hastaBindingSource.DataSource = hasta;
            diyetBindingSource.DataSource = hasta.diyet;
            hastalikBindingSource.DataSource = hasta.hastalik;
            diyetBindingSource.DataSource = hasta.diyet.diyetListe.ToList();
            


            this.reportViewer1.RefreshReport();
            
            
        }

        
            

            
         

        
    }
}
