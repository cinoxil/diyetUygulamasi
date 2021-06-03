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
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        public hasta hasta;

        private void frmRapor_Load(object sender, EventArgs e)
        {
            txtTc.Text = hasta.tc;
            txtAd.Text = hasta.ad;
            txtSoyad.Text = hasta.soyad;
            txtHastalik.Text = hasta.hastalik.adi;
            txtDiyet.Text = hasta.diyet.adi;

            dgDiyet.AllowUserToDeleteRows = false;

            dgDiyet.ColumnCount = 3;
            dgDiyet.Columns[0].Name = "Sabah";
            dgDiyet.Columns[1].Name = "Oglen";
            dgDiyet.Columns[2].Name = "Aksam";

            dgDiyet.RowCount = 7;

            diyetListele(dgDiyet);



        }


        diyetGunu tempDiyetGunu = null;
        private void diyetListele(DataGridView dg)
        {
            
            diyetGunu diyetGunu = hasta.diyet.diyetListe.LastOrDefault().diyetGunu;
            for (int i = 0; i <= diyetGunu.id; i++)
            {
                if (hasta.diyet.diyetListe.Where(x => x.diyetGunu.id == i).FirstOrDefault() != null)
                {
                    tempDiyetGunu = hasta.diyet.diyetListe.Where(x => x.diyetGunu.id == i).FirstOrDefault().diyetGunu;
                }

                if (i == tempDiyetGunu.id)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 0)
                        {
                            dg.Rows[i].Cells[j].Value = hasta.diyet.diyetListe.Where(x => x.diyetGunu.id == i).FirstOrDefault().diyetGunu.sabah;
                        }
                        else if (j == 1)
                        {
                            dg.Rows[i].Cells[j].Value = hasta.diyet.diyetListe.Where(x => x.diyetGunu.id == i).FirstOrDefault().diyetGunu.oglen;
                        }
                        else
                        {
                            dg.Rows[i].Cells[j].Value = hasta.diyet.diyetListe.Where(x => x.diyetGunu.id == i).FirstOrDefault().diyetGunu.aksam;
                        }


                    }
                }
            }
        }
    }
}













