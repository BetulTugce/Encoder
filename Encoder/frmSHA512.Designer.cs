
namespace Encoder
{
    partial class frmSHA512
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSHA512));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSHA512 = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSifrele = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCikti = new System.Windows.Forms.Label();
            this.lblGirdi = new System.Windows.Forms.Label();
            this.txtGirdi = new System.Windows.Forms.TextBox();
            this.txtCikti = new System.Windows.Forms.TextBox();
            this.btnCiktiyiKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGirdiyiKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTemizle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnSec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.btnDegistir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblSHA512);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(733, 52);
            this.pnlTop.TabIndex = 23;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblSHA512
            // 
            this.lblSHA512.AutoSize = true;
            this.lblSHA512.BackColor = System.Drawing.Color.Transparent;
            this.lblSHA512.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSHA512.ForeColor = System.Drawing.Color.White;
            this.lblSHA512.Location = new System.Drawing.Point(11, 8);
            this.lblSHA512.Name = "lblSHA512";
            this.lblSHA512.Size = new System.Drawing.Size(105, 28);
            this.lblSHA512.TabIndex = 3;
            this.lblSHA512.Text = "SHA512";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(660, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(695, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnSifrele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSifrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSifrele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifrele.BorderRadius = 0;
            this.btnSifrele.ButtonText = "ŞİFRELE";
            this.btnSifrele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifrele.DisabledColor = System.Drawing.Color.Gray;
            this.btnSifrele.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSifrele.Iconimage = null;
            this.btnSifrele.Iconimage_right = null;
            this.btnSifrele.Iconimage_right_Selected = null;
            this.btnSifrele.Iconimage_Selected = null;
            this.btnSifrele.IconMarginLeft = 0;
            this.btnSifrele.IconMarginRight = 0;
            this.btnSifrele.IconRightVisible = true;
            this.btnSifrele.IconRightZoom = 0D;
            this.btnSifrele.IconVisible = true;
            this.btnSifrele.IconZoom = 90D;
            this.btnSifrele.IsTab = false;
            this.btnSifrele.Location = new System.Drawing.Point(586, 460);
            this.btnSifrele.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSifrele.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSifrele.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSifrele.selected = false;
            this.btnSifrele.Size = new System.Drawing.Size(94, 34);
            this.btnSifrele.TabIndex = 30;
            this.btnSifrele.Text = "ŞİFRELE";
            this.btnSifrele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSifrele.Textcolor = System.Drawing.Color.White;
            this.btnSifrele.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // lblCikti
            // 
            this.lblCikti.AutoSize = true;
            this.lblCikti.BackColor = System.Drawing.Color.Transparent;
            this.lblCikti.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikti.ForeColor = System.Drawing.Color.White;
            this.lblCikti.Location = new System.Drawing.Point(56, 496);
            this.lblCikti.Name = "lblCikti";
            this.lblCikti.Size = new System.Drawing.Size(79, 20);
            this.lblCikti.TabIndex = 29;
            this.lblCikti.Text = "Çıktınız :";
            // 
            // lblGirdi
            // 
            this.lblGirdi.AutoSize = true;
            this.lblGirdi.BackColor = System.Drawing.Color.Transparent;
            this.lblGirdi.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirdi.ForeColor = System.Drawing.Color.White;
            this.lblGirdi.Location = new System.Drawing.Point(52, 168);
            this.lblGirdi.Name = "lblGirdi";
            this.lblGirdi.Size = new System.Drawing.Size(82, 20);
            this.lblGirdi.TabIndex = 28;
            this.lblGirdi.Text = "Girdiniz :";
            // 
            // txtGirdi
            // 
            this.txtGirdi.Location = new System.Drawing.Point(56, 200);
            this.txtGirdi.Multiline = true;
            this.txtGirdi.Name = "txtGirdi";
            this.txtGirdi.Size = new System.Drawing.Size(623, 246);
            this.txtGirdi.TabIndex = 26;
            // 
            // txtCikti
            // 
            this.txtCikti.Location = new System.Drawing.Point(57, 527);
            this.txtCikti.Multiline = true;
            this.txtCikti.Name = "txtCikti";
            this.txtCikti.Size = new System.Drawing.Size(623, 246);
            this.txtCikti.TabIndex = 27;
            // 
            // btnCiktiyiKaydet
            // 
            this.btnCiktiyiKaydet.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnCiktiyiKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCiktiyiKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCiktiyiKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCiktiyiKaydet.BorderRadius = 0;
            this.btnCiktiyiKaydet.ButtonText = "Çıktıyı Kaydet";
            this.btnCiktiyiKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCiktiyiKaydet.DisabledColor = System.Drawing.Color.Gray;
            this.btnCiktiyiKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCiktiyiKaydet.Iconimage = null;
            this.btnCiktiyiKaydet.Iconimage_right = null;
            this.btnCiktiyiKaydet.Iconimage_right_Selected = null;
            this.btnCiktiyiKaydet.Iconimage_Selected = null;
            this.btnCiktiyiKaydet.IconMarginLeft = 0;
            this.btnCiktiyiKaydet.IconMarginRight = 0;
            this.btnCiktiyiKaydet.IconRightVisible = true;
            this.btnCiktiyiKaydet.IconRightZoom = 0D;
            this.btnCiktiyiKaydet.IconVisible = true;
            this.btnCiktiyiKaydet.IconZoom = 90D;
            this.btnCiktiyiKaydet.IsTab = false;
            this.btnCiktiyiKaydet.Location = new System.Drawing.Point(378, 117);
            this.btnCiktiyiKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnCiktiyiKaydet.Name = "btnCiktiyiKaydet";
            this.btnCiktiyiKaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCiktiyiKaydet.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCiktiyiKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCiktiyiKaydet.selected = false;
            this.btnCiktiyiKaydet.Size = new System.Drawing.Size(106, 34);
            this.btnCiktiyiKaydet.TabIndex = 39;
            this.btnCiktiyiKaydet.Text = "Çıktıyı Kaydet";
            this.btnCiktiyiKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCiktiyiKaydet.Textcolor = System.Drawing.Color.White;
            this.btnCiktiyiKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiktiyiKaydet.Click += new System.EventHandler(this.btnCiktiyiKaydet_Click);
            // 
            // btnGirdiyiKaydet
            // 
            this.btnGirdiyiKaydet.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnGirdiyiKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGirdiyiKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGirdiyiKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirdiyiKaydet.BorderRadius = 0;
            this.btnGirdiyiKaydet.ButtonText = "Girdiyi Kaydet";
            this.btnGirdiyiKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirdiyiKaydet.DisabledColor = System.Drawing.Color.Gray;
            this.btnGirdiyiKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGirdiyiKaydet.Iconimage = null;
            this.btnGirdiyiKaydet.Iconimage_right = null;
            this.btnGirdiyiKaydet.Iconimage_right_Selected = null;
            this.btnGirdiyiKaydet.Iconimage_Selected = null;
            this.btnGirdiyiKaydet.IconMarginLeft = 0;
            this.btnGirdiyiKaydet.IconMarginRight = 0;
            this.btnGirdiyiKaydet.IconRightVisible = true;
            this.btnGirdiyiKaydet.IconRightZoom = 0D;
            this.btnGirdiyiKaydet.IconVisible = true;
            this.btnGirdiyiKaydet.IconZoom = 90D;
            this.btnGirdiyiKaydet.IsTab = false;
            this.btnGirdiyiKaydet.Location = new System.Drawing.Point(264, 117);
            this.btnGirdiyiKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirdiyiKaydet.Name = "btnGirdiyiKaydet";
            this.btnGirdiyiKaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGirdiyiKaydet.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGirdiyiKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGirdiyiKaydet.selected = false;
            this.btnGirdiyiKaydet.Size = new System.Drawing.Size(106, 34);
            this.btnGirdiyiKaydet.TabIndex = 38;
            this.btnGirdiyiKaydet.Text = "Girdiyi Kaydet";
            this.btnGirdiyiKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGirdiyiKaydet.Textcolor = System.Drawing.Color.White;
            this.btnGirdiyiKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirdiyiKaydet.Click += new System.EventHandler(this.btnGirdiyiKaydet_Click);
            // 
            // btnAc
            // 
            this.btnAc.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnAc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAc.BorderRadius = 0;
            this.btnAc.ButtonText = "Aç";
            this.btnAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAc.DisabledColor = System.Drawing.Color.Gray;
            this.btnAc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAc.Iconimage = null;
            this.btnAc.Iconimage_right = null;
            this.btnAc.Iconimage_right_Selected = null;
            this.btnAc.Iconimage_Selected = null;
            this.btnAc.IconMarginLeft = 0;
            this.btnAc.IconMarginRight = 0;
            this.btnAc.IconRightVisible = true;
            this.btnAc.IconRightZoom = 0D;
            this.btnAc.IconVisible = true;
            this.btnAc.IconZoom = 90D;
            this.btnAc.IsTab = false;
            this.btnAc.Location = new System.Drawing.Point(150, 117);
            this.btnAc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAc.Name = "btnAc";
            this.btnAc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAc.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAc.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAc.selected = false;
            this.btnAc.Size = new System.Drawing.Size(106, 34);
            this.btnAc.TabIndex = 37;
            this.btnAc.Text = "Aç";
            this.btnAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAc.Textcolor = System.Drawing.Color.White;
            this.btnAc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.BorderRadius = 0;
            this.btnTemizle.ButtonText = "Temizle";
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.DisabledColor = System.Drawing.Color.Gray;
            this.btnTemizle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTemizle.Iconimage = null;
            this.btnTemizle.Iconimage_right = null;
            this.btnTemizle.Iconimage_right_Selected = null;
            this.btnTemizle.Iconimage_Selected = null;
            this.btnTemizle.IconMarginLeft = 0;
            this.btnTemizle.IconMarginRight = 0;
            this.btnTemizle.IconRightVisible = true;
            this.btnTemizle.IconRightZoom = 0D;
            this.btnTemizle.IconVisible = true;
            this.btnTemizle.IconZoom = 90D;
            this.btnTemizle.IsTab = false;
            this.btnTemizle.Location = new System.Drawing.Point(492, 117);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTemizle.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTemizle.selected = false;
            this.btnTemizle.Size = new System.Drawing.Size(106, 34);
            this.btnTemizle.TabIndex = 36;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTemizle.Textcolor = System.Drawing.Color.White;
            this.btnTemizle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.BackColor = System.Drawing.Color.Transparent;
            this.lblDosyaYolu.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaYolu.ForeColor = System.Drawing.Color.White;
            this.lblDosyaYolu.Location = new System.Drawing.Point(53, 74);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(83, 16);
            this.lblDosyaYolu.TabIndex = 35;
            this.lblDosyaYolu.Text = "Dosya Yolu:";
            // 
            // btnSec
            // 
            this.btnSec.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnSec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSec.BorderRadius = 0;
            this.btnSec.ButtonText = "Seç";
            this.btnSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSec.DisabledColor = System.Drawing.Color.Gray;
            this.btnSec.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSec.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSec.Iconimage")));
            this.btnSec.Iconimage_right = null;
            this.btnSec.Iconimage_right_Selected = null;
            this.btnSec.Iconimage_Selected = null;
            this.btnSec.IconMarginLeft = 0;
            this.btnSec.IconMarginRight = 0;
            this.btnSec.IconRightVisible = true;
            this.btnSec.IconRightZoom = 0D;
            this.btnSec.IconVisible = true;
            this.btnSec.IconZoom = 60D;
            this.btnSec.IsTab = false;
            this.btnSec.Location = new System.Drawing.Point(620, 74);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnSec.Name = "btnSec";
            this.btnSec.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSec.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSec.selected = false;
            this.btnSec.Size = new System.Drawing.Size(65, 22);
            this.btnSec.TabIndex = 34;
            this.btnSec.Text = "Seç";
            this.btnSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSec.Textcolor = System.Drawing.Color.White;
            this.btnSec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(138, 73);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(469, 20);
            this.txtDosyaYolu.TabIndex = 33;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnDegistir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.BorderRadius = 0;
            this.btnDegistir.ButtonText = "";
            this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDegistir.DisabledColor = System.Drawing.Color.Gray;
            this.btnDegistir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDegistir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Iconimage")));
            this.btnDegistir.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Iconimage_right")));
            this.btnDegistir.Iconimage_right_Selected = null;
            this.btnDegistir.Iconimage_Selected = null;
            this.btnDegistir.IconMarginLeft = 0;
            this.btnDegistir.IconMarginRight = 0;
            this.btnDegistir.IconRightVisible = true;
            this.btnDegistir.IconRightZoom = 0D;
            this.btnDegistir.IconVisible = true;
            this.btnDegistir.IconZoom = 50D;
            this.btnDegistir.IsTab = false;
            this.btnDegistir.Location = new System.Drawing.Point(515, 460);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDegistir.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDegistir.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDegistir.selected = false;
            this.btnDegistir.Size = new System.Drawing.Size(63, 34);
            this.btnDegistir.TabIndex = 40;
            this.btnDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDegistir.Textcolor = System.Drawing.Color.White;
            this.btnDegistir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // frmSHA512
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Encoder.Properties.Resources.background__31_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 808);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnCiktiyiKaydet);
            this.Controls.Add(this.btnGirdiyiKaydet);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblDosyaYolu);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblCikti);
            this.Controls.Add(this.txtCikti);
            this.Controls.Add(this.lblGirdi);
            this.Controls.Add(this.txtGirdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSHA512";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHA512";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSHA512;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnSifrele;
        private System.Windows.Forms.Label lblCikti;
        private System.Windows.Forms.Label lblGirdi;
        private System.Windows.Forms.TextBox txtGirdi;
        private System.Windows.Forms.TextBox txtCikti;
        private Bunifu.Framework.UI.BunifuFlatButton btnCiktiyiKaydet;
        private Bunifu.Framework.UI.BunifuFlatButton btnGirdiyiKaydet;
        private Bunifu.Framework.UI.BunifuFlatButton btnAc;
        private Bunifu.Framework.UI.BunifuFlatButton btnTemizle;
        private System.Windows.Forms.Label lblDosyaYolu;
        private Bunifu.Framework.UI.BunifuFlatButton btnSec;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDegistir;
    }
}