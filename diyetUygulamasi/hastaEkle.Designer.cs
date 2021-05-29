
namespace diyetUygulamasi
{
    partial class hastaEkle
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
            this.gbHastaTxt = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHastaTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHastaTxt
            // 
            this.gbHastaTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbHastaTxt.Controls.Add(this.txtSoyad);
            this.gbHastaTxt.Controls.Add(this.txtAd);
            this.gbHastaTxt.Controls.Add(this.label3);
            this.gbHastaTxt.Controls.Add(this.txtTc);
            this.gbHastaTxt.Controls.Add(this.label2);
            this.gbHastaTxt.Controls.Add(this.btnEkle);
            this.gbHastaTxt.Controls.Add(this.label1);
            this.gbHastaTxt.Location = new System.Drawing.Point(-3, -10);
            this.gbHastaTxt.Name = "gbHastaTxt";
            this.gbHastaTxt.Size = new System.Drawing.Size(270, 217);
            this.gbHastaTxt.TabIndex = 5;
            this.gbHastaTxt.TabStop = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 109);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 83);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad :";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(108, 57);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(133, 135);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC :";
            // 
            // hastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 197);
            this.Controls.Add(this.gbHastaTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hastaEkle";
            this.Text = "urunEkle";
            this.gbHastaTxt.ResumeLayout(false);
            this.gbHastaTxt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbHastaTxt;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
    }
}