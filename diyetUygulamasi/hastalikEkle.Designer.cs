
namespace diyetUygulamasi
{
    partial class hastalikEkle
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
            this.dgPazar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPazar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPazar
            // 
            this.dgPazar.AllowUserToAddRows = false;
            this.dgPazar.AllowUserToDeleteRows = false;
            this.dgPazar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPazar.Location = new System.Drawing.Point(12, 12);
            this.dgPazar.Name = "dgPazar";
            this.dgPazar.ReadOnly = true;
            this.dgPazar.RowHeadersWidth = 51;
            this.dgPazar.Size = new System.Drawing.Size(646, 215);
            this.dgPazar.TabIndex = 0;
            // 
            // satinAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 283);
            this.Controls.Add(this.dgPazar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "satinAl";
            this.Text = "alisSatis";
            this.Load += new System.EventHandler(this.satinAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPazar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPazar;
    }
}