using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProg22024.FormKontrolleri
{
    public partial class FrmDateTimePicker : Form
    {
        public FrmDateTimePicker()
        {
            InitializeComponent();
        }

        private void FrmDateTimePicker_Load(object sender, EventArgs e)
        {
            //Başlangıç Tarihi, bugünden küçük olamaz.
            dateTimePicker1 = new DateTimePicker();
            //DatetimePicker türettik
            DateTimePicker TarihSaat = new DateTimePicker();
            //Form üzerindeki konumunu belirledik
            TarihSaat.Location = new Point(222, 12);
            //Genişliğini ayarladık
            TarihSaat.Width = 300;
            //Tarih ve saat formatını ekle belirlenecek şejkilde atalardık.
            TarihSaat.Format = DateTimePickerFormat.Custom;
            //Tarih ve saat formatını string datetime uygun hale getirdik
            TarihSaat.CustomFormat = "dd.MM.yyyy dddd MMMM HH:mm:ss";
            //Minimum başlanacak tarihi belirledik
            TarihSaat.MinDate = new DateTime(2024, 1, 1);
            //Maksimum seçilecek tarihi belirledik
            TarihSaat.MaxDate = new DateTime(2024, 12, 31);
            //Değer değişme olayını ekledik
            TarihSaat.ValueChanged += TarihSaat_ValueChanged;
            //Nesnemizi forma ekledik.
            Controls.Add(TarihSaat);

        }

        private void TarihSaat_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker TarihSaat = (DateTimePicker)sender;
            MessageBox.Show(TarihSaat.Value.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }
    }
}
