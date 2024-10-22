namespace GorselProg22024.DosyaKlasorIslemleri
{
    partial class FrmFile
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
            this.LstBoxMetinOkuma = new System.Windows.Forms.ListBox();
            this.TxtDosyaYazOku = new System.Windows.Forms.TextBox();
            this.BtnDosyaOlustur = new System.Windows.Forms.Button();
            this.BtnDosyaSil = new System.Windows.Forms.Button();
            this.BtnDosyaAdiDegistir = new System.Windows.Forms.Button();
            this.BtnDosyaKopyala = new System.Windows.Forms.Button();
            this.BtnMetinOku = new System.Windows.Forms.Button();
            this.BtnDosyadanOku = new System.Windows.Forms.Button();
            this.BtnDosyayaYaz = new System.Windows.Forms.Button();
            this.CmBoxUzantilar = new System.Windows.Forms.ComboBox();
            this.TxtDosyaAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstBoxDosyalar
            // 
            this.LstBoxDosyalar.FormattingEnabled = true;
            this.LstBoxDosyalar.ItemHeight = 16;
            this.LstBoxDosyalar.Location = new System.Drawing.Point(13, 13);
            this.LstBoxDosyalar.Name = "LstBoxDosyalar";
            this.LstBoxDosyalar.Size = new System.Drawing.Size(567, 132);
            this.LstBoxDosyalar.TabIndex = 0;
            // 
            // LstBoxMetinOkuma
            // 
            this.LstBoxMetinOkuma.FormattingEnabled = true;
            this.LstBoxMetinOkuma.ItemHeight = 16;
            this.LstBoxMetinOkuma.Location = new System.Drawing.Point(601, 214);
            this.LstBoxMetinOkuma.Name = "LstBoxMetinOkuma";
            this.LstBoxMetinOkuma.Size = new System.Drawing.Size(187, 132);
            this.LstBoxMetinOkuma.TabIndex = 1;
            // 
            // TxtDosyaYazOku
            // 
            this.TxtDosyaYazOku.Location = new System.Drawing.Point(601, 13);
            this.TxtDosyaYazOku.Multiline = true;
            this.TxtDosyaYazOku.Name = "TxtDosyaYazOku";
            this.TxtDosyaYazOku.Size = new System.Drawing.Size(187, 195);
            this.TxtDosyaYazOku.TabIndex = 2;
            // 
            // BtnDosyaOlustur
            // 
            this.BtnDosyaOlustur.Location = new System.Drawing.Point(13, 243);
            this.BtnDosyaOlustur.Name = "BtnDosyaOlustur";
            this.BtnDosyaOlustur.Size = new System.Drawing.Size(120, 23);
            this.BtnDosyaOlustur.TabIndex = 3;
            this.BtnDosyaOlustur.Text = "Dosya Oluştur";
            this.BtnDosyaOlustur.UseVisualStyleBackColor = true;
            this.BtnDosyaOlustur.Click += new System.EventHandler(this.BtnDosyaOlustur_Click);
            // 
            // BtnDosyaSil
            // 
            this.BtnDosyaSil.Location = new System.Drawing.Point(283, 243);
            this.BtnDosyaSil.Name = "BtnDosyaSil";
            this.BtnDosyaSil.Size = new System.Drawing.Size(81, 23);
            this.BtnDosyaSil.TabIndex = 4;
            this.BtnDosyaSil.Text = "Dosya Sil";
            this.BtnDosyaSil.UseVisualStyleBackColor = true;
            this.BtnDosyaSil.Click += new System.EventHandler(this.BtnDosyaSil_Click);
            // 
            // BtnDosyaAdiDegistir
            // 
            this.BtnDosyaAdiDegistir.Location = new System.Drawing.Point(139, 243);
            this.BtnDosyaAdiDegistir.Name = "BtnDosyaAdiDegistir";
            this.BtnDosyaAdiDegistir.Size = new System.Drawing.Size(138, 23);
            this.BtnDosyaAdiDegistir.TabIndex = 5;
            this.BtnDosyaAdiDegistir.Text = "Dosya Adı Değiştir";
            this.BtnDosyaAdiDegistir.UseVisualStyleBackColor = true;
            this.BtnDosyaAdiDegistir.Click += new System.EventHandler(this.BtnDosyaAdiDegistir_Click);
            // 
            // BtnDosyaKopyala
            // 
            this.BtnDosyaKopyala.Location = new System.Drawing.Point(370, 243);
            this.BtnDosyaKopyala.Name = "BtnDosyaKopyala";
            this.BtnDosyaKopyala.Size = new System.Drawing.Size(149, 23);
            this.BtnDosyaKopyala.TabIndex = 6;
            this.BtnDosyaKopyala.Text = "Dosya Kopyala";
            this.BtnDosyaKopyala.UseVisualStyleBackColor = true;
            this.BtnDosyaKopyala.Click += new System.EventHandler(this.BtnDosyaKopyala_Click);
            // 
            // BtnMetinOku
            // 
            this.BtnMetinOku.Location = new System.Drawing.Point(630, 411);
            this.BtnMetinOku.Name = "BtnMetinOku";
            this.BtnMetinOku.Size = new System.Drawing.Size(129, 23);
            this.BtnMetinOku.TabIndex = 7;
            this.BtnMetinOku.Text = "Metin Oku";
            this.BtnMetinOku.UseVisualStyleBackColor = true;
            this.BtnMetinOku.Click += new System.EventHandler(this.BtnMetinOku_Click);
            // 
            // BtnDosyadanOku
            // 
            this.BtnDosyadanOku.Location = new System.Drawing.Point(630, 382);
            this.BtnDosyadanOku.Name = "BtnDosyadanOku";
            this.BtnDosyadanOku.Size = new System.Drawing.Size(129, 23);
            this.BtnDosyadanOku.TabIndex = 8;
            this.BtnDosyadanOku.Text = "Dosyadan Oku";
            this.BtnDosyadanOku.UseVisualStyleBackColor = true;
            this.BtnDosyadanOku.Click += new System.EventHandler(this.BtnDosyadanOku_Click);
            // 
            // BtnDosyayaYaz
            // 
            this.BtnDosyayaYaz.Location = new System.Drawing.Point(630, 353);
            this.BtnDosyayaYaz.Name = "BtnDosyayaYaz";
            this.BtnDosyayaYaz.Size = new System.Drawing.Size(129, 23);
            this.BtnDosyayaYaz.TabIndex = 9;
            this.BtnDosyayaYaz.Text = "Dosyaya Yaz";
            this.BtnDosyayaYaz.UseVisualStyleBackColor = true;
            this.BtnDosyayaYaz.Click += new System.EventHandler(this.BtnDosyayaYaz_Click);
            // 
            // CmBoxUzantilar
            // 
            this.CmBoxUzantilar.FormattingEnabled = true;
            this.CmBoxUzantilar.Items.AddRange(new object[] {
            ".txt",
            ".docx",
            ".xlsx",
            ".pptx"});
            this.CmBoxUzantilar.Location = new System.Drawing.Point(13, 199);
            this.CmBoxUzantilar.Name = "CmBoxUzantilar";
            this.CmBoxUzantilar.Size = new System.Drawing.Size(191, 24);
            this.CmBoxUzantilar.TabIndex = 10;
            // 
            // TxtDosyaAdi
            // 
            this.TxtDosyaAdi.Location = new System.Drawing.Point(13, 160);
            this.TxtDosyaAdi.Name = "TxtDosyaAdi";
            this.TxtDosyaAdi.Size = new System.Drawing.Size(191, 22);
            this.TxtDosyaAdi.TabIndex = 11;
            // 
            // FrmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDosyaAdi);
            this.Controls.Add(this.CmBoxUzantilar);
            this.Controls.Add(this.BtnDosyayaYaz);
            this.Controls.Add(this.BtnDosyadanOku);
            this.Controls.Add(this.BtnMetinOku);
            this.Controls.Add(this.BtnDosyaKopyala);
            this.Controls.Add(this.BtnDosyaAdiDegistir);
            this.Controls.Add(this.BtnDosyaSil);
            this.Controls.Add(this.BtnDosyaOlustur);
            this.Controls.Add(this.TxtDosyaYazOku);
            this.Controls.Add(this.LstBoxMetinOkuma);
            this.Controls.Add(this.LstBoxDosyalar);
            this.Name = "FrmFile";
            this.Text = "FrmFile";
            this.Load += new System.EventHandler(this.FrmFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxDosyalar;
        private System.Windows.Forms.ListBox LstBoxMetinOkuma;
        private System.Windows.Forms.TextBox TxtDosyaYazOku;
        private System.Windows.Forms.Button BtnDosyaOlustur;
        private System.Windows.Forms.Button BtnDosyaSil;
        private System.Windows.Forms.Button BtnDosyaAdiDegistir;
        private System.Windows.Forms.Button BtnDosyaKopyala;
        private System.Windows.Forms.Button BtnMetinOku;
        private System.Windows.Forms.Button BtnDosyadanOku;
        private System.Windows.Forms.Button BtnDosyayaYaz;
        private System.Windows.Forms.ComboBox CmBoxUzantilar;
        private System.Windows.Forms.TextBox TxtDosyaAdi;
    }
}