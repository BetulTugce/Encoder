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
    public partial class frmSezar : Form
    {
        public frmSezar()
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
                txtCikti.Text = SezarSifrele(txtGirdi.Text, Convert.ToInt32(txtAnahtar.Text));
            }
            catch
            {
                MessageBox.Show("Hatalı bir giriş yaptınız. Şifrelenecek metninizi ve anahtarınızı kontrol edin!");
            }
        }
        private bool TurkceMi(char karakter)
        {
            if (karakter == 'ç' || karakter == 'Ç' || karakter == 'ğ' || karakter == 'Ğ' || karakter == 'ı' || karakter == 'İ' || karakter == 'ö' || karakter == 'Ö' || karakter == 'ş' || karakter == 'Ş' || karakter == 'ü' || karakter == 'Ü')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //İngiliz alfabesine göre şifreleme yapmak için..
        string SezarSifrele(string txt, int key)
        {
            StringBuilder builder = new StringBuilder();
            char[] dizi = txt.ToCharArray();
            for(int i = 0; i < dizi.Length; i++)
            {
                int harf = (int)dizi[i];
                if((harf>=65 && harf <= 90) && !TurkceMi(dizi[i]))
                {
                    harf = (((harf - 65) + key) % 26) + 65;
                    builder.Append(Convert.ToChar(harf));
                }
                else if((harf>=97 && harf <= 122) && !TurkceMi(dizi[i]))
                {
                    harf = (((harf - 97) + key) % 26) + 97;
                    builder.Append(Convert.ToChar(harf)); ;
                }
                else
                {
                    builder.Append(Convert.ToChar(harf)); ;
                }
            }
            return builder.ToString();
        } 

        //Girilen her karakteri şifrelemek için..
       /* string SezarSifrele(string txt, int key)
        {
            StringBuilder builder = new StringBuilder();
            foreach(char item in txt)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(item) + key));
            }
            return builder.ToString();
        } */

        private void btnCoz_Click(object sender, EventArgs e)
        {
            try
            {
                txtCikti.Text = SezarCoz(txtGirdi.Text, Convert.ToInt32(txtAnahtar.Text));
            }
            catch
            {
                MessageBox.Show("Hatalı bir giriş yaptınız. Çözülecek metninizi ve anahtarınızı kontrol edin!");
            }
        }

        //İngiliz alfabesine göre yapılan şifrelemeyi çözmek için..
       string SezarCoz(string txt, int key)
       {
            char[] dizi = txt.ToCharArray();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < dizi.Length; i++)
            {
                int harf = (int)dizi[i];
                if ((harf >= 65 && harf <= 90) && !TurkceMi(dizi[i]))
                {
                    harf = (((harf - 65) - key) % 26);
                    if (harf < 0)
                    {
                        harf += 26;
                    }
                    builder.Append(Convert.ToChar(harf + 65));
                }
                else if ((harf >= 97 && harf <= 122) && !TurkceMi(dizi[i]))
                {
                    harf = (((harf - 97) - key) % 26);
                    if (harf < 0)
                    {
                        harf += 26;
                    }
                    builder.Append(Convert.ToChar(harf + 97)); ;
                }
                else
                {
                    builder.Append(Convert.ToChar(harf)); ;
                }
            }
            return builder.ToString();
       }  

        //Girilen her karakterin şifresini çözmek için..
      /*  static string SezarCoz(string txt,int key)
        {
            StringBuilder builder = new StringBuilder();
            foreach(char item in txt)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(item) - key));
            }
            return builder.ToString();
        } */

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
