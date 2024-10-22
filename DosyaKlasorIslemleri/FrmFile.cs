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
    public partial class FrmFile : Form
    {
        public FrmFile()
        {
            InitializeComponent();
        }
        string Yol = Directory.GetParent(Application.StartupPath).
            Parent.FullName + @"\DosyaKlasorIslemleri\Klasorler";
        private void FrmFile_Load(object sender, EventArgs e)
        {
            string[] Dosyalar = Directory.GetFiles(Yol);
            foreach (var Dosya in Dosyalar)
            {
                LstBoxDosyalar.Items.Add(Dosya);
            }
        }

        private void BtnDosyaOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDosyaAdi.Text))
            {
                MessageBox.Show("Lütfen dosya adını yazınız!");
            }
            else if (CmBoxUzantilar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen dosya uzantısını seçiniz!");
            }
            else
            {
                //Crate() Metodu 
                //Belirtilen klasör içinde dosya oluşturma işlemi için kullanılır.
                //Hangi uzantı seçilmişse o uzantıda dosya oluşturur.
                File.Create(Yol + @"\" + TxtDosyaAdi.Text + CmBoxUzantilar.SelectedItem.ToString());
                MessageBox.Show($"{TxtDosyaAdi.Text}{CmBoxUzantilar.SelectedItem} " +
                    $"adlı dosyanız oluşturuldu");
                //Eklenen Dosyaları eş zamanlı okumak için
                LstBoxDosyalar.Items.Clear();
                string[] Dosyalar = Directory.GetFiles(Yol);
                foreach (var Dosya in Dosyalar)
                {
                    LstBoxDosyalar.Items.Add(Dosya);
                }
            }
        }

        private void BtnDosyaAdiDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDosyaAdi.Text))
            {
                MessageBox.Show("Lütfen dosya adını yazınız!");
            }
            else if (CmBoxUzantilar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen dosya uzantısını seçiniz!");
            }
            //Exists() Metodu
            //Belirtilen yola bakarak dosyanın olup olmadığını kontrol eder.
            //Eğer dosya var ise True döner. Yok ise False döner
            else if (!File.Exists(LstBoxDosyalar.SelectedItem.ToString()))
            {
                MessageBox.Show("Belirtilen yolda dosya bulunamadı!");
            }
            else
            {
                //Move() Metodu
                //Girilen ilk yol mevcut dosya yolu,
                //Girilen ikinci yol ise dosyanın taşınacak yolu veya
                //Dosyanın bulunduğu klasör yolu aynı ise dosyanın isminin değiştirilmesini sağlar.
                File.Move(LstBoxDosyalar.SelectedItem.ToString(),
                    Yol + @"\" + TxtDosyaAdi.Text + CmBoxUzantilar.SelectedItem.ToString());

                MessageBox.Show($"{LstBoxDosyalar.SelectedItem} adlı dosyanız " +
                    $"{TxtDosyaAdi.Text}{CmBoxUzantilar.SelectedItem} " +
                    $"olarak değiştirildi");

                //Güncellenen Dosyaları eş zamanlı okumak için
                LstBoxDosyalar.Items.Clear();
                string[] Dosyalar = Directory.GetFiles(Yol);
                foreach (var Dosya in Dosyalar)
                {
                    LstBoxDosyalar.Items.Add(Dosya);
                }
            }
        }
        private void BtnDosyaSil_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen silinecek dosyayı seçiniz!");
            }
            else
            {
                //Delete() Metodu
                //Belirtilen yolda bulunan dosyayı silme işi yapar.
                File.Delete(LstBoxDosyalar.SelectedItem.ToString());

                MessageBox.Show($"{LstBoxDosyalar.SelectedItem} adlı dosyanız silindi...");

                LstBoxDosyalar.Items.Remove(LstBoxDosyalar.SelectedItem);
            }
        }
        private void BtnDosyaKopyala_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen kopyalanacak dosyayı seçiniz!");
            }
            else
            {
                //Copy() Metodu dosya kopyalama işlemi için kullanılır.
                //İlk girilen yol mevcut dosya yolu,
                //İkinci girilen yol ise dosyanın kopyalanacağı yoldur.
                File.Copy(LstBoxDosyalar.SelectedItem.ToString(),
                    Yol + @"\User\" + TxtDosyaAdi.Text + CmBoxUzantilar.SelectedItem.ToString());

                MessageBox.Show("Seçtiğiniz dosya kopyalandı");
            }
        }
        private void BtnDosyayaYaz_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen üzerine yazıyazılacak dosyayı seçiniz!");
            }
            else
            {
                //AppendAllText Metodu
                //Belirtilen yolda bulunan dosyaya gönderilen tüm yazıları yazmak için kullanılır.
                File.AppendAllText(LstBoxDosyalar.SelectedItem.ToString(), TxtDosyaYazOku.Text);
                MessageBox.Show("Girdiğiniz yazılar dosyaya yazıldı.");
            }
        }
        private void BtnDosyadanOku_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen okunacak dosyayı seçiniz!");
            }
            else
            {
                //ReadAllText() Metodu
                //Dosyada bulunan tüm metni okuyup geriye string olarak çevirir.
                TxtDosyaYazOku.Text = File.ReadAllText(LstBoxDosyalar.SelectedItem.ToString());
            }
        }
        private void BtnMetinOku_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen okunacak dosyayı seçiniz!");
            }
            else
            {
                //ReadAllLines() Metodu
                //Dosyada bulunan metni Satılarlar halinde okuyup 
                //geriye string[] Dizi olarak çevirir.
                string[] Satirlar = File.ReadAllLines(LstBoxDosyalar.SelectedItem.ToString());
                foreach (var Satir in Satirlar)
                {
                    LstBoxMetinOkuma.Items.Add(Satir);
                }
            }
        }
    }
}