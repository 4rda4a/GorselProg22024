using GorselProg22024.FormKontrolleri;
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
using GorselProg22024.DosyaKlasorIslemleri;
using GorselProg22024.RichTextBoxIslemleri;

namespace GorselProg22024
{
    public partial class FrmKonular : Form
    {
        public FrmKonular()
        {
            InitializeComponent();
        }

        private void FrmKonular_Load(object sender, EventArgs e)
        {
            TreeView TreeAna = new TreeView();
            TreeAna.Width = 300;
            TreeAna.Height = 300;
            TreeAna.Location = new Point(10, 10);
            TreeAna.NodeMouseClick += TreeAna_NodeMouseClick;
            //Konular Düğümü
            TreeNode Konular = new TreeNode("Konular");
            //Form Kontrolleri
            TreeNode FormKontrolleri = new TreeNode("Form Kontrolleri");
            FormKontrolleri.Nodes.Add("MaskedTextBox", "MaskedTextBox Kontrolü");
            FormKontrolleri.Nodes.Add("DateTimePicker", "DateTimePicker Kontrolü");
            FormKontrolleri.Nodes.Add("DamaTahtasi", "Dama Tahtası Uygulaması");
            FormKontrolleri.Nodes.Add("NotifyIcon", "NotifyIcon Kontrolü");
            Konular.Nodes.Add(FormKontrolleri);

            //Dosya Klasör İşlemleri
            TreeNode DosyaKlasor = new TreeNode("Dosya Klasör İşlemleri");
            DosyaKlasor.Nodes.Add("Directory", "Directory Sınıf");
            DosyaKlasor.Nodes.Add("DirectoryInfo", "DirectoryInfo Sınıf");
            DosyaKlasor.Nodes.Add("File", "File Sınıfı");
            DosyaKlasor.Nodes.Add("FileInfo", "FileInfo Sınıfı");
            DosyaKlasor.Nodes.Add("Stream", "Stream Reader ve StreamWriter Sınıfı");
            Konular.Nodes.Add(DosyaKlasor);

            //RichTextBox İşlemleri
            Konular.Nodes.Add("RichTextBox", "Rich Text Box");

            TreeAna.Nodes.Add(Konular);
            TreeAna.ExpandAll();
            Controls.Add(TreeAna);

        }

        private void TreeAna_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "MaskedTextBox":
                    FrmMaskedTextBox MaskedTextBoxFormu = new FrmMaskedTextBox();
                    MaskedTextBoxFormu.ShowDialog();
                    break;
                case "DateTimePicker":
                    FrmDateTimePicker DateTimePickerFormu = new FrmDateTimePicker();
                    DateTimePickerFormu.ShowDialog();
                    break;
                case "DamaTahtasi":
                    FrmDamaTahtasi DamaTahtasiFormu = new FrmDamaTahtasi();
                    DamaTahtasiFormu.ShowDialog();
                    break;
                case "NotifyIcon":
                    FrmNotifyIcon NotifyIconFormu = new FrmNotifyIcon();
                    NotifyIconFormu.ShowDialog();
                    break;
                //Dosya Klasör İşlemleri
                case "Directory":
                    FrmDirectory DirectoryFormu = new FrmDirectory();
                    DirectoryFormu.ShowDialog();
                    break;
                case "DirectoryInfo":
                    FrmDirectoryInfo DirectoryInfoFormu = new FrmDirectoryInfo();
                    DirectoryInfoFormu.ShowDialog();
                    break;
                case "File":
                    FrmFile FileFormu = new FrmFile();
                    FileFormu.ShowDialog();
                    break;
                case "FileInfo":
                    FrmFileInfo FileInfoFormu = new FrmFileInfo();
                    FileInfoFormu.ShowDialog();
                    break;
                case "Stream":
                    FrmStream StreamFormu = new FrmStream();
                    StreamFormu.ShowDialog();
                    break;
                //Rich Text Box İşlemleri
                case "RichTextBox":
                    FrmRichTextBox RichTextBoxFormu = new FrmRichTextBox();
                    RichTextBoxFormu.ShowDialog();
                    break;
            }
        }
    }
}
