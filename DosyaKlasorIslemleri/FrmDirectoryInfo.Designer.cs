namespace GorselProg22024.DosyaKlasorIslemleri
{
    partial class FrmDirectoryInfo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LstBoxKlasorler = new System.Windows.Forms.ListBox();
            this.TxtKlasorAdi = new System.Windows.Forms.TextBox();
            this.BtnAltKlasorOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(286, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 212);
            this.listBox1.TabIndex = 0;
            // 
            // LstBoxKlasorler
            // 
            this.LstBoxKlasorler.FormattingEnabled = true;
            this.LstBoxKlasorler.ItemHeight = 16;
            this.LstBoxKlasorler.Location = new System.Drawing.Point(12, 12);
            this.LstBoxKlasorler.Name = "LstBoxKlasorler";
            this.LstBoxKlasorler.Size = new System.Drawing.Size(195, 212);
            this.LstBoxKlasorler.TabIndex = 1;
            // 
            // TxtKlasorAdi
            // 
            this.TxtKlasorAdi.Location = new System.Drawing.Point(580, 12);
            this.TxtKlasorAdi.Name = "TxtKlasorAdi";
            this.TxtKlasorAdi.Size = new System.Drawing.Size(143, 22);
            this.TxtKlasorAdi.TabIndex = 2;
            // 
            // BtnAltKlasorOlustur
            // 
            this.BtnAltKlasorOlustur.Location = new System.Drawing.Point(580, 92);
            this.BtnAltKlasorOlustur.Name = "BtnAltKlasorOlustur";
            this.BtnAltKlasorOlustur.Size = new System.Drawing.Size(143, 23);
            this.BtnAltKlasorOlustur.TabIndex = 3;
            this.BtnAltKlasorOlustur.Text = "Alt Klasör Oluştur";
            this.BtnAltKlasorOlustur.UseVisualStyleBackColor = true;
            // 
            // FrmDirectoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAltKlasorOlustur);
            this.Controls.Add(this.TxtKlasorAdi);
            this.Controls.Add(this.LstBoxKlasorler);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmDirectoryInfo";
            this.Text = "FrmDirectoryInfo";
            this.Load += new System.EventHandler(this.FrmDirectoryInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox LstBoxKlasorler;
        private System.Windows.Forms.TextBox TxtKlasorAdi;
        private System.Windows.Forms.Button BtnAltKlasorOlustur;
    }
}