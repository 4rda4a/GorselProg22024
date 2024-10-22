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
    public partial class FrmDamaTahtasi1 : Form
    {
        public FrmDamaTahtasi1()
        {
            InitializeComponent();
        }

        private void FrmDamaTahtasi1_Load(object sender, EventArgs e)
        {
            Button[,] BtnDizi = new Button[8, 8];
            int say = 1;
            for (int i = 0; i < BtnDizi.GetLength(0); i++)
            {
                for (int j = 0; j < BtnDizi.GetLength(1); j++)
                {
                    BtnDizi[i, j] = new Button();
                    BtnDizi[i, j].Width = 50;
                    BtnDizi[i, j].Height = 50;

                    BtnDizi[i, j].Left = j * 50;
                    BtnDizi[i, j].Top = i * 50;

                    BtnDizi[i, j].Text = say.ToString();
                    BtnDizi[i, j].ForeColor = Color.Red;
                    BtnDizi[i, j].Font = new Font(BtnDizi[i, j].Font, FontStyle.Bold);

                    say++;
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
