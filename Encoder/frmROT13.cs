using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    public partial class frmROT13 : Form
    {
        public frmROT13()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            try
            {
                txtCikti.Text = ROT13SifreleCoz(txtGirdi.Text);
            }
            catch
            {
                MessageBox.Show("Hatalı bir giriş yaptınız. Şifrelenecek metninizi kontrol edin!");
            }
        }

        static string ROT13SifreleCoz(string text)
        {
            char[] dizi = text.ToCharArray();
            for (int i = 0; i < dizi.Length; i++)
            {
                int harf = (int)dizi[i];
                if (harf >= 'a' && harf <= 'z')
                {
                    if (harf > 'm')
                    {
                        harf -= 13;
                    }
                    else
                        harf += 13; 
                }
                else if (harf >= 'A' && harf <= 'Z')
                {
                    if (harf > 'M')
                    {
                        harf -= 13;
                    }
                    else
                        harf += 13;
                }
                dizi[i] = (char)harf;
            }
            return new string(dizi);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = dlg.FileName;
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                String dosyaYolu = txtDosyaYolu.Text;
                String Icerik = File.ReadAllText(dosyaYolu);
                txtGirdi.Text = Icerik;
            }
            catch
            {
                MessageBox.Show("Dosya yolunda bir hata oluştu. Tekrar seçiniz.");
            }
        }

        private void btnGirdiyiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(txtDosyaYolu.Text, txtGirdi.Text);
            }
            catch
            {
                MessageBox.Show("Kaydedilecek dosya seçilmedi!");
            }
        }

        private void btnCiktiyiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(txtDosyaYolu.Text, txtCikti.Text);
            }
            catch
            {
                MessageBox.Show("Kaydedilecek dosya seçilmedi!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGirdi.Text = "";
            txtCikti.Text = "";
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(txtGirdi.Text);
            txtGirdi.Text = txtCikti.Text;
            txtCikti.Text = sb.ToString();
        }
    }
}
