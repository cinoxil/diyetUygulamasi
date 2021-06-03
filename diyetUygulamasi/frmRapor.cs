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
        private string[] gunler = new string[7] {"Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"};

        private void frmRapor_Load(object sender, EventArgs e)
        {
            txtTc.Text = hasta.tc;
            txtAd.Text = hasta.ad;
            txtSoyad.Text = hasta.soyad;
            txtHastalik.Text = hasta.hastalik.adi;
            txtDiyet.Text = hasta.diyet.adi;

            dgDiyet.AllowUserToDeleteRows = false;

            dgDiyet.ColumnCount = 4;
            dgDiyet.Columns[0].Name = "";
            dgDiyet.Columns[1].Name = "Sabah";
            dgDiyet.Columns[2].Name = "Oglen";
            dgDiyet.Columns[3].Name = "Aksam";

            dgDiyet.RowCount = 7;

            diyetListele(dgDiyet);
        }


        diyetGunu tempDiyetGunu = null;
        private void diyetListele(DataGridView dg)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    dg.Rows[i].Cells[j].Value = gunler[i];
                }
            }

            diyetGunu diyetGunu = hasta.diyet.diyetListe.LastOrDefault().diyetGunu;
            for (int i = 0; i <= diyetGunu.id; i++)
            {
                if (hasta.diyet.diyetListe.Where(x => x.diyetGunu.id == i).FirstOrDefault() != null)
                {
                    tempDiyetGunu = hasta.diyet.diyetListe.Where(x => x.diyetGunu.id == i).FirstOrDefault().diyetGunu;
                }

                if (i == tempDiyetGunu.id)
                {
                    for (int j = 1; j < 4; j++)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                worksheet.Cells[1, 1] = "TC";
                worksheet.Cells[1, 2] = hasta.tc.ToString();
                worksheet.Cells[2, 1] = "ad";
                worksheet.Cells[2, 2] = hasta.ad;
                worksheet.Cells[3, 1] = "soyad";
                worksheet.Cells[3, 2] = hasta.soyad;
                worksheet.Cells[4, 1] = "hastalık";
                worksheet.Cells[4, 2] = hasta.hastalik.adi;
                worksheet.Cells[5, 1] = "diyet";
                worksheet.Cells[5, 2] = hasta.diyet.adi;
                worksheet.Columns.ColumnWidth = 12;
                for (int i = 1; i < dgDiyet.Columns.Count + 1; i++)
                {
                    worksheet.Cells[9, i] = dgDiyet.Columns[i - 1].HeaderText;
                }
                for (int i = 8; i < dgDiyet.Rows.Count + 8; i++)
                {
                    for (int j = 0; j < dgDiyet.Columns.Count; j++)
                    {
                        if (dgDiyet.Rows[i-8].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgDiyet.Rows[i-8].Cells[j].Value.ToString();
                        }
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }
}