namespace GorselProg22024.DosyaKlasorIslemleri
{
    partial class FrmFileInfo
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
            this.LstBoxDosyalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstBoxDosyalar
            // 
            this.LstBoxDosyalar.FormattingEnabled = true;
            this.LstBoxDosyalar.ItemHeight = 16;
            this.LstBoxDosyalar.Location = new System.Drawing.Point(13, 13);
            this.LstBoxDosyalar.Name = "LstBoxDosyalar";
            this.LstBoxDosyalar.Size = new System.Drawing.Size(775, 196);
            this.LstBoxDosyalar.TabIndex = 0;
            // 
            // FrmFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstBoxDosyalar);
            this.Name = "FrmFileInfo";
            this.Text = "FrmFileInfo";
            this.Load += new System.EventHandler(this.FrmFileInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxDosyalar;
    }
}