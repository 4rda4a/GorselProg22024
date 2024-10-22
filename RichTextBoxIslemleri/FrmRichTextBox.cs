using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProg22024.RichTextBoxIslemleri
{
    public partial class FrmRichTextBox : Form
    {
        public FrmRichTextBox()
        {
            InitializeComponent();
        }

        private void BtnFontDialog_Click(object sender, EventArgs e)
        {
            DialogResult Cevap = fontDialog1.ShowDialog();
            if (Cevap == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void BtnColorDialog_Click(object sender, EventArgs e)
        {
            DialogResult Cevap = colorDialog1.ShowDialog();
            if (Cevap == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                //string Yol = Directory.GetParent(Application.StartupPath).Parent.FullName;
                string Yol = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                    @"\RichTextBoxIslemleri";
                if (comboBox1.SelectedItem.ToString() == ".rtf")
                {
                    richTextBox1.SaveFile(Yol + @"\Deneme" + comboBox1.SelectedItem);
                }
                else
                {
                    richTextBox1.SaveFile(Yol + @"\Deneme" + comboBox1.SelectedItem,
                        RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("Kayıt Başarılı...");
            }
            else
            {
                MessageBox.Show("Lütfen dosya türünü seçiniz...");
            }
        }
    }
}
