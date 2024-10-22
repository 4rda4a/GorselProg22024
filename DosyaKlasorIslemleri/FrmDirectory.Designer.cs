namespace GorselProg22024.DosyaKlasorIslemleri
{
    partial class FrmDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKlasorOlustur = new System.Windows.Forms.Button();
            this.BtnKlasorAdiDegistir = new System.Windows.Forms.Button();
            this.BtnKlasorSil = new System.Windows.Forms.Button();
            this.TxtKlasorAdi = new System.Windows.Forms.TextBox();
            this.LstBoxKlasorBilgi = new System.Windows.Forms.ListBox();
            this.LstBoxKlasorler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKlasorOlustur);
            this.groupBox1.Controls.Add(this.BtnKlasorAdiDegistir);
            this.groupBox1.Controls.Add(this.BtnKlasorSil);
            this.groupBox1.Controls.Add(this.TxtKlasorAdi);
            this.groupBox1.Controls.Add(this.LstBoxKlasorBilgi);
            this.groupBox1.Controls.Add(this.LstBoxKlasorler);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klasör İşlemleri";
            // 
            // BtnKlasorOlustur
            // 
            this.BtnKlasorOlustur.Location = new System.Drawing.Point(20, 397);
            this.BtnKlasorOlustur.Name = "BtnKlasorOlustur";
            this.BtnKlasorOlustur.Size = new System.Drawing.Size(104, 22);
            this.BtnKlasorOlustur.TabIndex = 5;
            this.BtnKlasorOlustur.Text = "Klasör Oluştur";
            this.BtnKlasorOlustur.UseVisualStyleBackColor = true;
            this.BtnKlasorOlustur.Click += new System.EventHandler(this.BtnKlasorOlustur_Click);
            // 
            // BtnKlasorAdiDegistir
            // 
            this.BtnKlasorAdiDegistir.Location = new System.Drawing.Point(342, 242);
            this.BtnKlasorAdiDegistir.Name = "BtnKlasorAdiDegistir";
            this.BtnKlasorAdiDegistir.Size = new System.Drawing.Size(138, 22);
            this.BtnKlasorAdiDegistir.TabIndex = 4;
            this.BtnKlasorAdiDegistir.Text = "Klasör Adı Değiştir";
            this.BtnKlasorAdiDegistir.UseVisualStyleBackColor = true;
            this.BtnKlasorAdiDegistir.Click += new System.EventHandler(this.BtnKlasorAdiDegistir_Click);
            // 
            // BtnKlasorSil
            // 
            this.BtnKlasorSil.Location = new System.Drawing.Point(232, 242);
            this.BtnKlasorSil.Name = "BtnKlasorSil";
            this.BtnKlasorSil.Size = new System.Drawing.Size(104, 22);
            this.BtnKlasorSil.TabIndex = 3;
            this.BtnKlasorSil.Text = "Klasör Sil";
            this.BtnKlasorSil.UseVisualStyleBackColor = true;
            this.BtnKlasorSil.Click += new System.EventHandler(this.BtnKlasorSil_Click);
            // 
            // TxtKlasorAdi
            // 
            this.TxtKlasorAdi.Location = new System.Drawing.Point(20, 242);
            this.TxtKlasorAdi.Name = "TxtKlasorAdi";
            this.TxtKlasorAdi.Size = new System.Drawing.Size(162, 22);
            this.TxtKlasorAdi.TabIndex = 2;
            // 
            // LstBoxKlasorBilgi
            // 
            this.LstBoxKlasorBilgi.FormattingEnabled = true;
            this.LstBoxKlasorBilgi.ItemHeight = 16;
            this.LstBoxKlasorBilgi.Location = new System.Drawing.Point(499, 22);
            this.LstBoxKlasorBilgi.Name = "LstBoxKlasorBilgi";
            this.LstBoxKlasorBilgi.Size = new System.Drawing.Size(270, 180);
            this.LstBoxKlasorBilgi.TabIndex = 1;
            // 
            // LstBoxKlasorler
            // 
            this.LstBoxKlasorler.FormattingEnabled = true;
            this.LstBoxKlasorler.ItemHeight = 16;
            this.LstBoxKlasorler.Location = new System.Drawing.Point(7, 22);
            this.LstBoxKlasorler.Name = "LstBoxKlasorler";
            this.LstBoxKlasorler.Size = new System.Drawing.Size(270, 180);
            this.LstBoxKlasorler.TabIndex = 0;
            // 
            // FrmDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDirectory";
            this.Text = "FrmDirectory";
            this.Load += new System.EventHandler(this.FrmDirectory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtKlasorAdi;
        private System.Windows.Forms.ListBox LstBoxKlasorBilgi;
        private System.Windows.Forms.ListBox LstBoxKlasorler;
        private System.Windows.Forms.Button BtnKlasorOlustur;
        private System.Windows.Forms.Button BtnKlasorAdiDegistir;
        private System.Windows.Forms.Button BtnKlasorSil;
    }
}