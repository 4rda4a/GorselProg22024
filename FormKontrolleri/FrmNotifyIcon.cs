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
    public partial class FrmNotifyIcon : Form
    {
        public FrmNotifyIcon()
        {
            InitializeComponent();
        }

        private void FrmNotifyIcon_Load(object sender, EventArgs e)
        {
            //Bilgisayara bildirim gönderir.
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void FrmNotifyIcon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void çalıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}