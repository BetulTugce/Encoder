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
    public partial class frmBase64 : Form
    {
        public frmBase64()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

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

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            try
            {
                string anametin = txtGirdi.Text;
                byte[] veridizim = Encoding.ASCII.GetBytes(anametin);
                string sifreliMetin = Convert.ToBase64String(veridizim);
                txtCikti.Text = sifreliMetin;
                /* Encoding türleri UTF32 = 180byte bellekte yer kaplar. UTF16=Unicode = 90    UTF8 = 51  ASCII = 45byte
                **UTF8** aslında : YXNsxLFuZGE=        YXNsxLFuZGE= : aslında
                **ASCII** aslında : YXNsP25kYQ==       YXNsP25kYQ== : asl?nda 
                *Eğer ingilizce dışında bir karakter kullanılmamışsa ASCII kullanılabilir. ASCII ile yapılan kodlamada bazı karakterler geri gelmeyecek
                şekilde yok oluyor.*/
            }
            catch
            {
                MessageBox.Show("Girdinizi kontrol edin!");
            }
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            try
            {
                string sifreliMetin = txtGirdi.Text;
                byte[] veridizim = Convert.FromBase64String(sifreliMetin);
                string anaMetin = Encoding.ASCII.GetString(veridizim);
                txtCikti.Text = anaMetin;
            }
            catch
            {
                MessageBox.Show("Girdinizi kontrol edin!");
            }
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
