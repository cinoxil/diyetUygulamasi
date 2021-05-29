
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
            ((System.ComponentModel.ISupportInitialize)(this.dgHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHastalar
            // 
            this.dgHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHastalar.Location = new System.Drawing.Point(12, 12);
            this.dgHastalar.Name = "dgHastalar";
            this.dgHastalar.Size = new System.Drawing.Size(631, 217);
            this.dgHastalar.TabIndex = 0;
            this.dgHastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHastalar_CellClick);
            // 
            // cmbHastaliklar
            // 
            this.cmbHastaliklar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastaliklar.FormattingEnabled = true;
            this.cmbHastaliklar.Location = new System.Drawing.Point(69, 250);
            this.cmbHastaliklar.Name = "cmbHastaliklar";
            this.cmbHastaliklar.Size = new System.Drawing.Size(121, 21);
            this.cmbHastaliklar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hastalik :";
            // 
            // cmbDiyetler
            // 
            this.cmbDiyetler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiyetler.FormattingEnabled = true;
            this.cmbDiyetler.Location = new System.Drawing.Point(264, 250);
            this.cmbDiyetler.Name = "cmbDiyetler";
            this.cmbDiyetler.Size = new System.Drawing.Size(121, 21);
            this.cmbDiyetler.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diyet :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(513, 240);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 39);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Hastayi Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // hastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 286);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDiyetler);
            this.Controls.Add(this.cmbHastaliklar);
            this.Controls.Add(this.dgHastalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}