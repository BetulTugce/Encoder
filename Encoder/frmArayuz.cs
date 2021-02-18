using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    public partial class frmArayuz : Form
    {
        public frmArayuz()
        {
            InitializeComponent();
        }

        //**Formu fareyle tutarak hareket ettirmek için..
        bool move;
        int mouse_x;
        int mouse_y;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
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

        private void btnSezar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSezar"] == null)
            {
                frmSezar form = new frmSezar();
                form.Show();
            }
            else
                Application.OpenForms["frmSezar"].Activate();
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMD5"] == null)
            {
                frmMD5 form = new frmMD5();
                form.Show();
            }
            else
                Application.OpenForms["frmMD5"].Activate();
        }

        private void btnROT13_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmROT13"] == null)
            {
                frmROT13 form = new frmROT13();
                form.Show();
            }
            else
                Application.OpenForms["frmROT13"].Activate();
        }

        private void btnSHA1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSHA1"] == null)
            {
                frmSHA1 form = new frmSHA1();
                form.Show();
            }
            else
                Application.OpenForms["frmSHA1"].Activate();
        }

        private void btnSHA256_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSHA256"] == null)
            {
                frmSHA256 form = new frmSHA256();
                form.Show();
            }
            else
                Application.OpenForms["frmSHA256"].Activate();
        }

        private void btnSHA384_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSHA384"] == null)
            {
                frmSHA384 form = new frmSHA384();
                form.Show();
            }
            else
                Application.OpenForms["frmSHA384"].Activate();
        }

        private void btnSHA512_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSHA512"] == null)
            {
                frmSHA512 form = new frmSHA512();
                form.Show();
            }
            else
                Application.OpenForms["frmSHA512"].Activate();
        }

        private void btnBase64_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBase64"] == null)
            {
                frmBase64 form = new frmBase64();
                form.Show();
            }
            else
                Application.OpenForms["frmBase64"].Activate();
        }
    }
}
