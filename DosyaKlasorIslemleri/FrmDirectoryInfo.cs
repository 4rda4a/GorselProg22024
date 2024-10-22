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
    public partial class FrmDirectoryInfo : Form
    {
        public FrmDirectoryInfo()
        {
            InitializeComponent();
        }
        String Yol = Directory.GetParent(Application.StartupPath).
                 Parent.FullName + "\\DosyaKlasorIslemleri\\Klasorler";
        private void FrmDirectoryInfo_Load(object sender, EventArgs e)
        {
            DirectoryInfo KlasorlerBilgi = new DirectoryInfo(Yol);
            DirectoryInfo[] Klasorler = KlasorlerBilgi.GetDirectories();
            foreach (var Klasor in Klasorler)
            {
                LstBoxKlasorler.Items.Add(Klasor.Name);
                //Klasörün oluşturulma tarihi ve mevcut klasörün klasörün ana klasörü
                listBox1.Items.Add(Klasor.CreationTime + "-" + Klasor.Parent);

            }
        }
        private void BtnAltKlasorOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtKlasorAdi.Text))
            {
                MessageBox.Show("Litfen Klasör adını yazınız");

            }
            else
            {
                DirectoryInfo KlasorlerBilgi = new DirectoryInfo(Yol);
                //CreateSubDirectory()metodu
                //mevcut klasör altında klasör oluşturma işlemi için kullanılır
                KlasorlerBilgi.CreateSubdirectory(TxtKlasorAdi.Text);
                //Klasorleri okuma
                DirectoryInfo[] Klasorler = KlasorlerBilgi.GetDirectories();
                listBox1.Items.Clear();
                LstBoxKlasorler.Items.Clear();
                foreach (var Klasor in Klasorler)
                {
                    LstBoxKlasorler.Items.Add(Klasor.Name);
                    //Klasörün oluştrulma tarihi ve mevcut klasörün ana klasörü
                    listBox1.Items.Add(Klasor.CreationTime + " - " + Klasor.Parent);
                }

            }
        }
    }
}
