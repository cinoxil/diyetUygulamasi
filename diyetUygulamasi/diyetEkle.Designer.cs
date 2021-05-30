
namespace diyetUygulamasi
{
    partial class diyetEkle
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtDiyet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSabah = new System.Windows.Forms.TextBox();
            this.txtOgle = new System.Windows.Forms.TextBox();
            this.txtAksam = new System.Windows.Forms.TextBox();
            this.cmbGunler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(288, 138);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Diyet Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtDiyet
            // 
            this.txtDiyet.Location = new System.Drawing.Point(144, 12);
            this.txtDiyet.Name = "txtDiyet";
            this.txtDiyet.Size = new System.Drawing.Size(244, 20);
            this.txtDiyet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diyet Adi :";
            // 
            // txtSabah
            // 
            this.txtSabah.Location = new System.Drawing.Point(144, 47);
            this.txtSabah.Name = "txtSabah";
            this.txtSabah.Size = new System.Drawing.Size(244, 20);
            this.txtSabah.TabIndex = 2;
            this.txtSabah.Text = "Sabah";
            this.txtSabah.Enter += new System.EventHandler(this.txtSabah_Enter);
            // 
            // txtOgle
            // 
            this.txtOgle.Location = new System.Drawing.Point(144, 73);
            this.txtOgle.Name = "txtOgle";
            this.txtOgle.Size = new System.Drawing.Size(244, 20);
            this.txtOgle.TabIndex = 3;
            this.txtOgle.Text = "Ogle";
            this.txtOgle.Enter += new System.EventHandler(this.txtOgle_Enter);
            // 
            // txtAksam
            // 
            this.txtAksam.Location = new System.Drawing.Point(144, 99);
            this.txtAksam.Name = "txtAksam";
            this.txtAksam.Size = new System.Drawing.Size(244, 20);
            this.txtAksam.TabIndex = 4;
            this.txtAksam.Text = "Aksam";
            this.txtAksam.Enter += new System.EventHandler(this.txtAksam_Enter);
            // 
            // cmbGunler
            // 
            this.cmbGunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGunler.FormattingEnabled = true;
            this.cmbGunler.Items.AddRange(new object[] {
            "Pazartesi",
            "Sali",
            "Carsamba",
            "Persembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.cmbGunler.Location = new System.Drawing.Point(18, 73);
            this.cmbGunler.Name = "cmbGunler";
            this.cmbGunler.Size = new System.Drawing.Size(121, 21);
            this.cmbGunler.TabIndex = 1;
            // 
            // diyetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 177);
            this.Controls.Add(this.cmbGunler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAksam);
            this.Controls.Add(this.txtOgle);
            this.Controls.Add(this.txtSabah);
            this.Controls.Add(this.txtDiyet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "diyetEkle";
            this.Text = "urunlerim";
            this.Load += new System.EventHandler(this.urunlerim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtDiyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSabah;
        private System.Windows.Forms.TextBox txtOgle;
        private System.Windows.Forms.TextBox txtAksam;
        private System.Windows.Forms.ComboBox cmbGunler;
    }
}