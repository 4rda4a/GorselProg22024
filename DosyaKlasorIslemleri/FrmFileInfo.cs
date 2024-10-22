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
    public partial class FrmFileInfo : Form
    {
        public FrmFileInfo()
        {
            InitializeComponent();
        }
        string Yol = Directory.GetParent(Application.StartupPath).
            Parent.FullName + @"\DosyaKlasorIslemleri\Klasorler";
        private void FrmFileInfo_Load(object sender, EventArgs e)
        {
            //Tek dosya üzerinde işlem yapmak istiyorsak
            FileInfo Dosyam = new FileInfo(Yol + @"\Arda.txt");
            //Belirtilen yolda klasör ile ilgili bilgileri getirir
            DirectoryInfo Klasor = new DirectoryInfo(Yol);
            //GetFiles() Metodu ile FileInfo[] Sınıfı Dİzi olarak getirir
            //FileInfo sınıfı ilede dosya ile ilgili tüm bilgilere erişmiş oluruz
            FileInfo[] Dosyalar = Klasor.GetFiles();
            foreach (var Dosya in Dosyalar)
            {
                //Name Özelliği, Dpsyanın adını verir
                //Extension Özelliği, dosyanın boyutunu byte cinsinden verir
                //CretionTime Özelliği dosyanın oluşturulma tarihini verir
                LstBoxDosyalar.Items.Add(Dosya.Name + " - " + Dosya.Extension + " - " +
                    Dosya.Length / 1024 + " Kb" + " - " + Dosya.CreationTime);
            }
        }
    }
}
