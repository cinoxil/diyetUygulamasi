
using System.Collections.Generic;

namespace diyetUygulamasi
{
    partial class frmRapor
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
            this.gbKisisel = new System.Windows.Forms.GroupBox();
            this.txtDiyet = new System.Windows.Forms.TextBox();
            this.txtHastalik = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDiyet = new System.Windows.Forms.GroupBox();
            this.dgDiyet = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbKisisel.SuspendLayout();
            this.gbDiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiyet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKisisel
            // 
            this.gbKisisel.Controls.Add(this.txtDiyet);
            this.gbKisisel.Controls.Add(this.txtHastalik);
            this.gbKisisel.Controls.Add(this.txtSoyad);
            this.gbKisisel.Controls.Add(this.txtAd);
            this.gbKisisel.Controls.Add(this.txtTc);
            this.gbKisisel.Controls.Add(this.label5);
            this.gbKisisel.Controls.Add(this.label4);
            this.gbKisisel.Controls.Add(this.label3);
            this.gbKisisel.Controls.Add(this.label2);
            this.gbKisisel.Controls.Add(this.label1);
            this.gbKisisel.Location = new System.Drawing.Point(12, 12);
            this.gbKisisel.Name = "gbKisisel";
            this.gbKisisel.Size = new System.Drawing.Size(480, 123);
            this.gbKisisel.TabIndex = 0;
            this.gbKisisel.TabStop = false;
            this.gbKisisel.Text = "Kisisel Bilgiler";
            // 
            // txtDiyet
            // 
            this.txtDiyet.Location = new System.Drawing.Point(357, 55);
            this.txtDiyet.Name = "txtDiyet";
            this.txtDiyet.ReadOnly = true;
            this.txtDiyet.Size = new System.Drawing.Size(100, 22);
            this.txtDiyet.TabIndex = 1;
            // 
            // txtHastalik
            // 
            this.txtHastalik.Location = new System.Drawing.Point(357, 28);
            this.txtHastalik.Name = "txtHastalik";
            this.txtHastalik.ReadOnly = true;
            this.txtHastalik.Size = new System.Drawing.Size(100, 22);
            this.txtHastalik.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(104, 82);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 55);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(104, 28);
            this.txtTc.Name = "txtTc";
            this.txtTc.ReadOnly = true;
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Diyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hastalik :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC :";
            // 
            // gbDiyet
            // 
            this.gbDiyet.Controls.Add(this.dgDiyet);
            this.gbDiyet.Location = new System.Drawing.Point(12, 153);
            this.gbDiyet.Name = "gbDiyet";
            this.gbDiyet.Size = new System.Drawing.Size(480, 349);
            this.gbDiyet.TabIndex = 0;
            this.gbDiyet.TabStop = false;
            this.gbDiyet.Text = "Diyet Bilgileri";
            // 
            // dgDiyet
            // 
            this.dgDiyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDiyet.Location = new System.Drawing.Point(3, 18);
            this.dgDiyet.Name = "dgDiyet";
            this.dgDiyet.ReadOnly = true;
            this.dgDiyet.RowHeadersWidth = 51;
            this.dgDiyet.Size = new System.Drawing.Size(474, 328);
            this.dgDiyet.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excell\'e Aktar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Excell\'e Aktar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRapor
            // 
            this.ClientSize = new System.Drawing.Size(495, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDiyet);
            this.Controls.Add(this.gbKisisel);
            this.Name = "frmRapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            this.gbKisisel.ResumeLayout(false);
            this.gbKisisel.PerformLayout();
            this.gbDiyet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiyet)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox gbKisisel;
        private System.Windows.Forms.TextBox txtDiyet;
        private System.Windows.Forms.TextBox txtHastalik;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDiyet;
        private System.Windows.Forms.DataGridView dgDiyet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}