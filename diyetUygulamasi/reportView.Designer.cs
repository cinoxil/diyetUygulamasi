
using System.Collections.Generic;

namespace diyetUygulamasi
{
    partial class reportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diyetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastalikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diyetListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diyetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diyetListesiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataSource = typeof(diyetUygulamasi.entities.hasta);
            // 
            // diyetBindingSource
            // 
            this.diyetBindingSource.DataSource = typeof(diyetUygulamasi.entities.diyet);
            // 
            // hastalikBindingSource
            // 
            this.hastalikBindingSource.DataSource = typeof(diyetUygulamasi.database.hastalik);
            // 
            // diyetListesiBindingSource
            // 
            this.diyetListesiBindingSource.DataSource = typeof(List<diyetUygulamasi.entities.diyetListesi>);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HastaDataSet";
            reportDataSource1.Value = this.hastaBindingSource;
            reportDataSource2.Name = "DiyetDataSet";
            reportDataSource2.Value = this.diyetBindingSource;
            reportDataSource3.Name = "HastalikDataSet";
            reportDataSource3.Value = this.hastalikBindingSource;
            reportDataSource4.Name = "DiyetGunuDataSet";
            reportDataSource4.Value = this.diyetListesiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "diyetUygulamasi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportView";
            this.Text = "reportView";
            this.Load += new System.EventHandler(this.reportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diyetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diyetListesiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private System.Windows.Forms.BindingSource diyetBindingSource;
        private System.Windows.Forms.BindingSource hastalikBindingSource;
        private System.Windows.Forms.BindingSource diyetListesiBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        
    }
}