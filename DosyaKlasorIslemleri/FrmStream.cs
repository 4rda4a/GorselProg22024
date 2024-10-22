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

namespace GorselProg22024.DosyaKlasorIslemleri
{
    public partial class FrmStream : Form
    {
        public FrmStream()
        {
            InitializeComponent();
        }
        string Yol = Directory.GetParent(Application.StartupPath).
            Parent.FullName + @"\DosyaKlasorIslemleri\Klasorler";
        private void FrmStream_Load(object sender, EventArgs e)
        {
            string[] Dosyalar = Directory.GetFiles(Yol);
            foreach (var Dosya in Dosyalar)
            {
                LstBoxDosyalar.Items.Add(Dosya);
            }
        }

        private void BtnDosyayaYaz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDosyaYazOku.Text))
            {
                MessageBox.Show("Lütfen dosyaya yazılacak yazıyı yazınız!");
            }
            else if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen dosyayı seçiniz!");
            }
            else
            {
                //StreamWriter Sınıfı dosyalara metin yaz işlemi için kullanılmaktadır.
                StreamWriter Sw = new StreamWriter(LstBoxDosyalar.SelectedItem.ToString());
                Sw.WriteLine(TxtDosyaYazOku);
                //Kaydet ve dosyayı kapat
                Sw.Close();
                //Dosya bilgisini ramden temizle
                Sw.Dispose();
            }
        }

        private void BtnDosyadanOku_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen dosyayı seçiniz!");
            }
            else
            {
                //StreamReader Sınıfı belirtilen yolda bulunan dosyadan
                //metin okuma işlemi için kullanılır
                StreamReader Sr = new StreamReader(LstBoxDosyalar.SelectedItem.ToString());
                //ReadToEnd() Metodu, Dosyada bulunan tüm metni
                //okuyarak string olarak geri çevirir
                TxtDosyaYazOku.Text = Sr.ReadToEnd();
                //Dosyayı kapat
                Sr.Close();
                //Dosya bilgisini ramden temizle
                Sr.Dispose();
            }
        }

        private void BtnMetinOku_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen dosyayı seçiniz!");
            }
            else
            {
                //StreamReader Sınıfı belirtilen yolda bulunan dosyadan metin
                //okuma işlemi için kullanılır
                StreamReader Sr = new StreamReader(LstBoxDosyalar.SelectedItem.ToString());
                //EndOfStream Özelliği, Metindeki tüm yazı okunana kadar True değerini çevirir.
                //Yoksa False değerini çevirir
                while (!Sr.EndOfStream)
                {
                    //RedLine Metodu
                    //Dosyadaki metinleri satır satır okuma işlemi yapar
                    LstBoxMetinOkuma.Items.Add(Sr.ReadLine());
                }
                //Dosyayı kapat
                Sr.Close();
                //Dosyayı randem kaldır.
                Sr.Dispose();
            }
        }
    }
}
