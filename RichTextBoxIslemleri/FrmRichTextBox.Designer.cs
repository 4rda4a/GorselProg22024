namespace GorselProg22024.RichTextBoxIslemleri
{
    partial class FrmRichTextBox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnFontDialog = new System.Windows.Forms.Button();
            this.BtnColorDialog = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 220);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnFontDialog
            // 
            this.BtnFontDialog.Location = new System.Drawing.Point(13, 251);
            this.BtnFontDialog.Name = "BtnFontDialog";
            this.BtnFontDialog.Size = new System.Drawing.Size(109, 23);
            this.BtnFontDialog.TabIndex = 1;
            this.BtnFontDialog.Text = "Font Aç";
            this.BtnFontDialog.UseVisualStyleBackColor = true;
            this.BtnFontDialog.Click += new System.EventHandler(this.BtnFontDialog_Click);
            // 
            // BtnColorDialog
            // 
            this.BtnColorDialog.Location = new System.Drawing.Point(140, 251);
            this.BtnColorDialog.Name = "BtnColorDialog";
            this.BtnColorDialog.Size = new System.Drawing.Size(109, 23);
            this.BtnColorDialog.TabIndex = 2;
            this.BtnColorDialog.Text = "Renk Aç";
            this.BtnColorDialog.UseVisualStyleBackColor = true;
            this.BtnColorDialog.Click += new System.EventHandler(this.BtnColorDialog_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(457, 251);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(109, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".rtf",
            ".txt"});
            this.comboBox1.Location = new System.Drawing.Point(255, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // FrmRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnColorDialog);
            this.Controls.Add(this.BtnFontDialog);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmRichTextBox";
            this.Text = "FrmRichTextBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnFontDialog;
        private System.Windows.Forms.Button BtnColorDialog;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}