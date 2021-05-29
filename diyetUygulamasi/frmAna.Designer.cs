
using System;

namespace diyetUygulamasi
{
    partial class frmAna
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
            this.grpBoxIslemListe = new System.Windows.Forms.GroupBox();
            this.btnHastaIslemleri = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.btnDiyetEkle = new System.Windows.Forms.Button();
            this.btnHastalikEkle = new System.Windows.Forms.Button();
            this.pnlIslemler = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.grpBoxIslemListe.SuspendLayout();
            this.pnlIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxIslemListe
            // 
            this.grpBoxIslemListe.Controls.Add(this.btnHastaIslemleri);
            this.grpBoxIslemListe.Controls.Add(this.btnHastaEkle);
            this.grpBoxIslemListe.Controls.Add(this.btnOturumKapat);
            this.grpBoxIslemListe.Controls.Add(this.btnDiyetEkle);
            this.grpBoxIslemListe.Controls.Add(this.btnHastalikEkle);
            this.grpBoxIslemListe.Location = new System.Drawing.Point(6, 108);
            this.grpBoxIslemListe.Name = "grpBoxIslemListe";
            this.grpBoxIslemListe.Size = new System.Drawing.Size(115, 206);
            this.grpBoxIslemListe.TabIndex = 1;
            this.grpBoxIslemListe.TabStop = false;
            this.grpBoxIslemListe.Text = "İşlem Listesi";
            // 
            // btnHastaIslemleri
            // 
            this.btnHastaIslemleri.Enabled = false;
            this.btnHastaIslemleri.Location = new System.Drawing.Point(6, 55);
            this.btnHastaIslemleri.Name = "btnHastaIslemleri";
            this.btnHastaIslemleri.Size = new System.Drawing.Size(102, 28);
            this.btnHastaIslemleri.TabIndex = 1;
            this.btnHastaIslemleri.Text = "Hasta Islemleri";
            this.btnHastaIslemleri.UseVisualStyleBackColor = true;
            this.btnHastaIslemleri.Click += new System.EventHandler(this.btnHastaIslemleri_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Enabled = false;
            this.btnHastaEkle.Location = new System.Drawing.Point(6, 21);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(102, 28);
            this.btnHastaEkle.TabIndex = 0;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // btnOturumKapat
            // 
            this.btnOturumKapat.Enabled = false;
            this.btnOturumKapat.Location = new System.Drawing.Point(7, 157);
            this.btnOturumKapat.Name = "btnOturumKapat";
            this.btnOturumKapat.Size = new System.Drawing.Size(102, 28);
            this.btnOturumKapat.TabIndex = 4;
            this.btnOturumKapat.Text = "Oturumu Kapat";
            this.btnOturumKapat.UseVisualStyleBackColor = true;
            this.btnOturumKapat.Click += new System.EventHandler(this.btnOturumKapat_Click);
            // 
            // btnDiyetEkle
            // 
            this.btnDiyetEkle.Enabled = false;
            this.btnDiyetEkle.Location = new System.Drawing.Point(6, 123);
            this.btnDiyetEkle.Name = "btnDiyetEkle";
            this.btnDiyetEkle.Size = new System.Drawing.Size(102, 28);
            this.btnDiyetEkle.TabIndex = 3;
            this.btnDiyetEkle.Text = "Diyet Ekle";
            this.btnDiyetEkle.UseVisualStyleBackColor = true;
            this.btnDiyetEkle.Click += new System.EventHandler(this.btnDiyetEkle_Click);
            // 
            // btnHastalikEkle
            // 
            this.btnHastalikEkle.Enabled = false;
            this.btnHastalikEkle.Location = new System.Drawing.Point(7, 89);
            this.btnHastalikEkle.Name = "btnHastalikEkle";
            this.btnHastalikEkle.Size = new System.Drawing.Size(102, 28);
            this.btnHastalikEkle.TabIndex = 2;
            this.btnHastalikEkle.Text = "Hastalik Ekle";
            this.btnHastalikEkle.UseVisualStyleBackColor = true;
            this.btnHastalikEkle.Click += new System.EventHandler(this.btnHastalikEkle_Click);
            // 
            // pnlIslemler
            // 
            this.pnlIslemler.Controls.Add(this.lblId);
            this.pnlIslemler.Controls.Add(this.grpBoxIslemListe);
            this.pnlIslemler.Location = new System.Drawing.Point(1, 0);
            this.pnlIslemler.Name = "pnlIslemler";
            this.pnlIslemler.Size = new System.Drawing.Size(124, 449);
            this.pnlIslemler.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 406);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "id";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlIslemler);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyetisyen Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxIslemListe.ResumeLayout(false);
            this.pnlIslemler.ResumeLayout(false);
            this.pnlIslemler.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.GroupBox grpBoxIslemListe;
        private System.Windows.Forms.Button btnHastaIslemleri;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Button btnHastalikEkle;
        private System.Windows.Forms.Panel pnlIslemler;
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDiyetEkle;
    }
}

