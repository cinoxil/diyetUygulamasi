﻿
namespace diyetUygulamasi
{
    partial class frmAdmin
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
            this.btnOturumKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOturumKapat
            // 
            this.btnOturumKapat.Location = new System.Drawing.Point(694, 415);
            this.btnOturumKapat.Name = "btnOturumKapat";
            this.btnOturumKapat.Size = new System.Drawing.Size(94, 23);
            this.btnOturumKapat.TabIndex = 0;
            this.btnOturumKapat.Text = "Oturumu Kapat";
            this.btnOturumKapat.UseVisualStyleBackColor = true;
            this.btnOturumKapat.Click += new System.EventHandler(this.btnOturumKapat_Click_1);
            // 
            // frmAdmin
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOturumKapat);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnOturumKapat;
    }
}