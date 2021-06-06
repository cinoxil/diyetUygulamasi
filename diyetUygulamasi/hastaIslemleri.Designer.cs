
using System;

namespace diyetUygulamasi
{
    partial class hastaIslemleri
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
            this.dgHastalar = new System.Windows.Forms.DataGridView();
            this.cmbHastaliklar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDiyetler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnRaporAl1 = new System.Windows.Forms.Button();
            this.btnRaporAl2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHastalar
            // 
            this.dgHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHastalar.Location = new System.Drawing.Point(16, 15);
            this.dgHastalar.Margin = new System.Windows.Forms.Padding(4);
            this.dgHastalar.Name = "dgHastalar";
            this.dgHastalar.RowHeadersWidth = 51;
            this.dgHastalar.Size = new System.Drawing.Size(841, 267);
            this.dgHastalar.TabIndex = 0;
            this.dgHastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHastalar_CellClick);
            // 
            // cmbHastaliklar
            // 
            this.cmbHastaliklar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastaliklar.FormattingEnabled = true;
            this.cmbHastaliklar.Location = new System.Drawing.Point(92, 308);
            this.cmbHastaliklar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHastaliklar.Name = "cmbHastaliklar";
            this.cmbHastaliklar.Size = new System.Drawing.Size(160, 24);
            this.cmbHastaliklar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hastalik :";
            // 
            // cmbDiyetler
            // 
            this.cmbDiyetler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiyetler.FormattingEnabled = true;
            this.cmbDiyetler.Location = new System.Drawing.Point(352, 308);
            this.cmbDiyetler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiyetler.Name = "cmbDiyetler";
            this.cmbDiyetler.Size = new System.Drawing.Size(160, 24);
            this.cmbDiyetler.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diyet :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(693, 295);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(173, 48);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Hastayi Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnRaporAl1
            // 
            this.btnRaporAl1.Location = new System.Drawing.Point(520, 295);
            this.btnRaporAl1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporAl1.Name = "btnRaporAl1";
            this.btnRaporAl1.Size = new System.Drawing.Size(82, 48);
            this.btnRaporAl1.TabIndex = 3;
            this.btnRaporAl1.Text = "Rapor Al1";
            this.btnRaporAl1.UseVisualStyleBackColor = true;
            this.btnRaporAl1.Click += new System.EventHandler(this.btnRaporAl1_Click);
            // 
            // btnRaporAl2
            // 
            this.btnRaporAl2.Location = new System.Drawing.Point(610, 295);
            this.btnRaporAl2.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporAl2.Name = "btnRaporAl2";
            this.btnRaporAl2.Size = new System.Drawing.Size(82, 48);
            this.btnRaporAl2.TabIndex = 4;
            this.btnRaporAl2.Text = "Rapor Al2";
            this.btnRaporAl2.UseVisualStyleBackColor = true;
            this.btnRaporAl2.Click += new System.EventHandler(this.btnRaporAl2_Click);
            // 
            // hastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 352);
            this.Controls.Add(this.btnRaporAl2);
            this.Controls.Add(this.btnRaporAl1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDiyetler);
            this.Controls.Add(this.cmbHastaliklar);
            this.Controls.Add(this.dgHastalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hastaIslemleri";
            this.Text = "paraEkle";
            this.Load += new System.EventHandler(this.hastaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView dgHastalar;
        private System.Windows.Forms.ComboBox cmbHastaliklar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiyetler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnRaporAl1;
        private System.Windows.Forms.Button btnRaporAl2;
    }
}