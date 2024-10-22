using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProg22024.DosyaKlasorIslemleri
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
        {
            InitializeComponent();
        }

        //string Yol = Directory.GetParent(Application.StartupPath).Parent.FullName;
        string Yol = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private void FrmDirectory_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath);
            //MessageBox.Show(Directory.GetCurrentDirectory());
            //MessageBox.Show(Yol);

            //Exists() Metodu
            //Belirtilen yola göre klasörün olup olmadığı bilgisini verir.
            //Eğer varsa true yoksa false değeri gönderir
            if (Directory.Exists(Yol + "\\DosyaKlasorIslemleri\\Klasorler"))
            {
                //GetDirectories() Methodu
                //Belirtilen Yola göre, mevcut klasörün altında bulunan tüm
                //klasörlerin listesini string dizi olarak verir
                string[] Klasorler = Directory.GetDirectories(
                    Yol + "\\DosyaKlasorIslemler\\Klasorler");
                foreach (var Klasor in Klasorler)
                {
                    LstBoxKlasorler.Items.Add(Klasor);
                }
            }

            //GetCretionTime() metodu
            //girilen yola göre klasörün oluşturulma tarihini verir.
            LstBoxKlasorBilgi.Items.Add(Directory.GetCurrentDirectory());

            //GetFiles() methodu
            //girilen yola göre klasördeki dosyaları string dizi olarak getirir
            //desen girilmeyen yani dosya sorgusu olmayan
            if (Directory.Exists(Yol + "\\DosyaKlasorIslemleri\\Klasorler"))
            {
                string[] Dosyalar = Directory.GetFiles(Yol +
                     "\\DosyaKlasorIslemleri\\Klasorler");
                foreach (var Dosya in Dosyalar)
                {
                    LstBoxKlasorBilgi.Items.Add(Dosya);
                }

                //desen girilen, yani dosya sorgusu olan başında D karakterleri olanları getir.
                //string[] Dosyalar = Directory.GetFiles(Yol +
                //     "\\DosyaKlasorIslemleri\\Klasorler", "D");
                //foreach (var Dosya in Dosyalar)
                //{
                //    LstBoxKlasorBilgi.Items.Add(Dosya);
                //}
            }
            //GetLogicalDrives() methodu
            //bilgisayardaki sürücülerin listesini string dizi olarak çevirir
            string[] Suruculer = Directory.GetLogicalDrives();
            foreach (var Surucu in Suruculer)
            {
                LstBoxKlasorBilgi.Items.Add(Surucu);
            }
        }

        private void BtnKlasorOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtKlasorAdi.Text))
            {
                MessageBox.Show("Lütfen klasör adını yazınız!");
            }
            else
            {
                if (Directory.Exists(Yol + "\\DosyaKlasorIslemleri\\Klasorler"))
                {
                    //CreateDirectory() metodu
                    //belirtilen yola göre girilen isimde klasör oluşturur
                    Directory.CreateDirectory(Yol + "\\DosyaKlasorIslemleri\\Klasorler" + TxtKlasorAdi.Text);
                    MessageBox.Show($"{TxtKlasorAdi.Text} adlı klasör oluşturuldu.");

                    LstBoxKlasorler.Items.Clear();
                    string[] Klasorler = Directory.GetDirectories(Yol + "\\DosyaKlasorIslemleri\\Klasorler");
                    foreach (var Klasor in Klasorler)
                    {
                        LstBoxKlasorler.Items.Add(Klasor);
                    }
                }
                else
                {
                    Directory.CreateDirectory(Yol + "\\DosyaKlasorIslemleri\\Klasorler");
                    MessageBox.Show($"Klasorler adlı klasör oluşturuldu");
                }
            }
        }

        private void BtnKlasorSil_Click(object sender, EventArgs e)
        {
            if (LstBoxKlasorler.SelectedIndex >= 0)
            {
                //Delete() methodu
                //belirtilen yola göre klasör silme işlemi yapar

                //tek tek silme
                //Directory.Delete(LstBoxKlasorler.SelectedItem.ToString());
                //LstBoxKlasorler.Items.Remove(LstBoxKlasorler.SelectedItem);

                //çoklu silme
                for (int i = LstBoxKlasorler.SelectedItems.Count - 1; i >= 0; i--)
                {
                    Directory.Delete(LstBoxKlasorler.SelectedItems[i].ToString());
                    LstBoxKlasorler.Items.Remove(LstBoxKlasorler.SelectedItems[i]);
                }
            }
        }

        private void BtnKlasorAdiDegistir_Click(object sender, EventArgs e)
        {
            if (LstBoxKlasorler.SelectedIndex >= 0)
            {
                //Move() metodu
                //birinci paramtere üzerinde işlem yapılacak klasor yolu
                //ikinci parametre ismi değiştirilecek klasör veya taşınacak klasörün yolu
                //eğer ikinci parametre aynı klasör içinde değilse taşıma işlemi yapar
                //aynı klasör içindeyse isim değiştirme işlemi yapar
                Directory.Move(LstBoxKlasorler.SelectedItem.ToString(),
                    Yol + "\\DosyaKlasorIslemleri\\Klasorler"
                        + TxtKlasorAdi.Text);

                LstBoxKlasorler.Items.Clear();
                string[] Klasorler = Directory.GetDirectories(Yol + "\\DosyaKlasorIslemleri\\Klasorler");
                foreach (var Klasor in Klasorler)
                {
                    LstBoxKlasorler.Items.Add(Klasor);
                }
            }
        }

    }
}
