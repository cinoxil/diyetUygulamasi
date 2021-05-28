
using System;

namespace diyetUygulamasi
{
    partial class Form1
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
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.btnUrunlerim = new System.Windows.Forms.Button();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.pnlIslemler = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.grpBoxIslemListe.SuspendLayout();
            this.pnlIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxIslemListe
            // 
            this.grpBoxIslemListe.Controls.Add(this.btnParaEkle);
            this.grpBoxIslemListe.Controls.Add(this.btnUrunEkle);
            this.grpBoxIslemListe.Controls.Add(this.btnOturumKapat);
            this.grpBoxIslemListe.Controls.Add(this.btnUrunlerim);
            this.grpBoxIslemListe.Controls.Add(this.btnSatinAl);
            this.grpBoxIslemListe.Location = new System.Drawing.Point(6, 108);
            this.grpBoxIslemListe.Name = "grpBoxIslemListe";
            this.grpBoxIslemListe.Size = new System.Drawing.Size(115, 206);
            this.grpBoxIslemListe.TabIndex = 1;
            this.grpBoxIslemListe.TabStop = false;
            this.grpBoxIslemListe.Text = "İşlem Listesi";
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.Enabled = false;
            this.btnParaEkle.Location = new System.Drawing.Point(6, 55);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(102, 28);
            this.btnParaEkle.TabIndex = 1;
            this.btnParaEkle.Text = "Hasta Islemleri";
            this.btnParaEkle.UseVisualStyleBackColor = true;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Enabled = false;
            this.btnUrunEkle.Location = new System.Drawing.Point(6, 21);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(102, 28);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Hasta Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
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
            // btnUrunlerim
            // 
            this.btnUrunlerim.Enabled = false;
            this.btnUrunlerim.Location = new System.Drawing.Point(6, 123);
            this.btnUrunlerim.Name = "btnUrunlerim";
            this.btnUrunlerim.Size = new System.Drawing.Size(102, 28);
            this.btnUrunlerim.TabIndex = 3;
            this.btnUrunlerim.Text = "Diyet Ekle";
            this.btnUrunlerim.UseVisualStyleBackColor = true;
            this.btnUrunlerim.Click += new System.EventHandler(this.btnUrunlerim_Click);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Enabled = false;
            this.btnSatinAl.Location = new System.Drawing.Point(7, 89);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(102, 28);
            this.btnSatinAl.TabIndex = 2;
            this.btnSatinAl.Text = "Hastalik Ekle";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlIslemler);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alım - Satım Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxIslemListe.ResumeLayout(false);
            this.pnlIslemler.ResumeLayout(false);
            this.pnlIslemler.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.GroupBox grpBoxIslemListe;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Panel pnlIslemler;
        private System.Windows.Forms.Button btnOturumKapat;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUrunlerim;
    }
}

