
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
            this.gbUrunTxt = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbUrunTxt
            // 
            this.gbUrunTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbUrunTxt.Location = new System.Drawing.Point(-3, -10);
            this.gbUrunTxt.Name = "gbUrunTxt";
            this.gbUrunTxt.Size = new System.Drawing.Size(241, 198);
            this.gbUrunTxt.TabIndex = 5;
            this.gbUrunTxt.TabStop = false;
            // 
            // urunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 162);
            this.Controls.Add(this.gbUrunTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunEkle";
            this.Text = "urunEkle";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbUrunTxt;
    }
}