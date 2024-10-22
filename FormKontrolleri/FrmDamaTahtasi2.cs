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
    public partial class FrmDamaTahtasi2 : Form
    {
        public FrmDamaTahtasi2()
        {
            InitializeComponent();
        }

        private void FrmDamaTahtasi2_Load(object sender, EventArgs e)
        {
            Label[,] BtnDizi = new Label[8, 8];
            for (int i = 0; i < BtnDizi.GetLength(0); i++)
            {
                for (int j = 0; j < BtnDizi.GetLength(1); j++)
                {
                    BtnDizi[i, j] = new Label();
                    BtnDizi[i, j].Width = 50;
                    BtnDizi[i, j].Height = 50;

                    BtnDizi[i, j].Left = j * 50;
                    BtnDizi[i, j].Top = i * 50;

                    if ((i + j) % 2 == 0)
                    {
                        BtnDizi[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        BtnDizi[i, j].BackColor = Color.White;
                    }

                    Controls.Add(BtnDizi[i, j]);
                }
            }
        }
    }
}
