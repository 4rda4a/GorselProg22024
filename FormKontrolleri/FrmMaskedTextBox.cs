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
    public partial class FrmMaskedTextBox : Form
    {
        public FrmMaskedTextBox()
        {
            InitializeComponent();
        }

        private void FrmMaskedTextBox_Load(object sender, EventArgs e)
        {
            MaskedTextBox TxtDogumTarihi = new MaskedTextBox();
            TxtDogumTarihi.Location = new Point(154, 12);
            TxtDogumTarihi.Mask = "00.00.0000";
            TxtDogumTarihi.TextChanged += TxtDogumTarihi_TextChanged;
            Controls.Add(TxtDogumTarihi);
        }

        private void TxtDogumTarihi_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox TxtDogumTarihi = (MaskedTextBox)sender;
            label1.Text = TxtDogumTarihi.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //girisi bittiği zaman çalışan olaydır
            //istenilen format dışında karakter girildiğinde de bu olay tetiklenir
            MessageBox.Show(maskedTextBox1.Text);
        }
    }
}
