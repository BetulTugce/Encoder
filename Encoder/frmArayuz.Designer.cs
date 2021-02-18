
namespace Encoder
{
    partial class frmArayuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArayuz));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblEncoder = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestoreDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCikis = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSezar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMD5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlButon = new System.Windows.Forms.Panel();
            this.btnSHA512 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSHA384 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSHA1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSHA256 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnROT13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBase64 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            this.pnlButon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblEncoder);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnRestoreDown);
            this.pnlTop.Controls.Add(this.btnCikis);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(548, 52);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblEncoder
            // 
            this.lblEncoder.AutoSize = true;
            this.lblEncoder.BackColor = System.Drawing.Color.Transparent;
            this.lblEncoder.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEncoder.ForeColor = System.Drawing.Color.White;
            this.lblEncoder.Location = new System.Drawing.Point(11, 8);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(125, 28);
            this.lblEncoder.TabIndex = 3;
            this.lblEncoder.Text = "ENCODER";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(444, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestoreDown
            // 
            this.btnRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDown.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreDown.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreDown.Image")));
            this.btnRestoreDown.ImageActive = null;
            this.btnRestoreDown.Location = new System.Drawing.Point(477, 8);
            this.btnRestoreDown.Name = "btnRestoreDown";
            this.btnRestoreDown.Size = new System.Drawing.Size(30, 30);
            this.btnRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestoreDown.TabIndex = 1;
            this.btnRestoreDown.TabStop = false;
            this.btnRestoreDown.Zoom = 10;
            this.btnRestoreDown.Click += new System.EventHandler(this.btnRestoreDown_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageActive = null;
            this.btnCikis.Location = new System.Drawing.Point(510, 8);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(30, 30);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCikis.TabIndex = 0;
            this.btnCikis.TabStop = false;
            this.btnCikis.Zoom = 10;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSezar
            // 
            this.btnSezar.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnSezar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSezar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSezar.BackgroundImage")));
            this.btnSezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSezar.BorderRadius = 0;
            this.btnSezar.ButtonText = "SEZAR";
            this.btnSezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSezar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSezar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSezar.Iconimage = null;
            this.btnSezar.Iconimage_right = null;
            this.btnSezar.Iconimage_right_Selected = null;
            this.btnSezar.Iconimage_Selected = null;
            this.btnSezar.IconMarginLeft = 0;
            this.btnSezar.IconMarginRight = 0;
            this.btnSezar.IconRightVisible = true;
            this.btnSezar.IconRightZoom = 0D;
            this.btnSezar.IconVisible = true;
            this.btnSezar.IconZoom = 90D;
            this.btnSezar.IsTab = false;
            this.btnSezar.Location = new System.Drawing.Point(25, 29);
            this.btnSezar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSezar.Name = "btnSezar";
            this.btnSezar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSezar.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSezar.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSezar.selected = false;
            this.btnSezar.Size = new System.Drawing.Size(117, 50);
            this.btnSezar.TabIndex = 1;
            this.btnSezar.Text = "SEZAR";
            this.btnSezar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSezar.Textcolor = System.Drawing.Color.White;
            this.btnSezar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSezar.Click += new System.EventHandler(this.btnSezar_Click);
            // 
            // btnMD5
            // 
            this.btnMD5.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnMD5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMD5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMD5.BackgroundImage")));
            this.btnMD5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMD5.BorderRadius = 0;
            this.btnMD5.ButtonText = "MD5";
            this.btnMD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMD5.DisabledColor = System.Drawing.Color.Gray;
            this.btnMD5.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMD5.Iconimage = null;
            this.btnMD5.Iconimage_right = null;
            this.btnMD5.Iconimage_right_Selected = null;
            this.btnMD5.Iconimage_Selected = null;
            this.btnMD5.IconMarginLeft = 0;
            this.btnMD5.IconMarginRight = 0;
            this.btnMD5.IconRightVisible = true;
            this.btnMD5.IconRightZoom = 0D;
            this.btnMD5.IconVisible = true;
            this.btnMD5.IconZoom = 90D;
            this.btnMD5.IsTab = false;
            this.btnMD5.Location = new System.Drawing.Point(25, 108);
            this.btnMD5.Margin = new System.Windows.Forms.Padding(4);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMD5.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMD5.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMD5.selected = false;
            this.btnMD5.Size = new System.Drawing.Size(117, 50);
            this.btnMD5.TabIndex = 2;
            this.btnMD5.Text = "MD5";
            this.btnMD5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMD5.Textcolor = System.Drawing.Color.White;
            this.btnMD5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // pnlButon
            // 
            this.pnlButon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlButon.BackColor = System.Drawing.Color.Transparent;
            this.pnlButon.Controls.Add(this.btnBase64);
            this.pnlButon.Controls.Add(this.btnSHA512);
            this.pnlButon.Controls.Add(this.btnSHA384);
            this.pnlButon.Controls.Add(this.btnSHA1);
            this.pnlButon.Controls.Add(this.btnSHA256);
            this.pnlButon.Controls.Add(this.btnROT13);
            this.pnlButon.Controls.Add(this.btnSezar);
            this.pnlButon.Controls.Add(this.btnMD5);
            this.pnlButon.Location = new System.Drawing.Point(42, 103);
            this.pnlButon.Name = "pnlButon";
            this.pnlButon.Size = new System.Drawing.Size(466, 266);
            this.pnlButon.TabIndex = 3;
            // 
            // btnSHA512
            // 
            this.btnSHA512.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnSHA512.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSHA512.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA512.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSHA512.BackgroundImage")));
            this.btnSHA512.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSHA512.BorderRadius = 0;
            this.btnSHA512.ButtonText = "SHA512";
            this.btnSHA512.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSHA512.DisabledColor = System.Drawing.Color.Gray;
            this.btnSHA512.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSHA512.Iconimage = null;
            this.btnSHA512.Iconimage_right = null;
            this.btnSHA512.Iconimage_right_Selected = null;
            this.btnSHA512.Iconimage_Selected = null;
            this.btnSHA512.IconMarginLeft = 0;
            this.btnSHA512.IconMarginRight = 0;
            this.btnSHA512.IconRightVisible = true;
            this.btnSHA512.IconRightZoom = 0D;
            this.btnSHA512.IconVisible = true;
            this.btnSHA512.IconZoom = 90D;
            this.btnSHA512.IsTab = false;
            this.btnSHA512.Location = new System.Drawing.Point(174, 185);
            this.btnSHA512.Margin = new System.Windows.Forms.Padding(4);
            this.btnSHA512.Name = "btnSHA512";
            this.btnSHA512.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA512.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSHA512.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSHA512.selected = false;
            this.btnSHA512.Size = new System.Drawing.Size(117, 50);
            this.btnSHA512.TabIndex = 8;
            this.btnSHA512.Text = "SHA512";
            this.btnSHA512.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSHA512.Textcolor = System.Drawing.Color.White;
            this.btnSHA512.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA512.Click += new System.EventHandler(this.btnSHA512_Click);
            // 
            // btnSHA384
            // 
            this.btnSHA384.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnSHA384.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSHA384.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA384.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSHA384.BackgroundImage")));
            this.btnSHA384.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSHA384.BorderRadius = 0;
            this.btnSHA384.ButtonText = "SHA384";
            this.btnSHA384.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSHA384.DisabledColor = System.Drawing.Color.Gray;
            this.btnSHA384.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSHA384.Iconimage = null;
            this.btnSHA384.Iconimage_right = null;
            this.btnSHA384.Iconimage_right_Selected = null;
            this.btnSHA384.Iconimage_Selected = null;
            this.btnSHA384.IconMarginLeft = 0;
            this.btnSHA384.IconMarginRight = 0;
            this.btnSHA384.IconRightVisible = true;
            this.btnSHA384.IconRightZoom = 0D;
            this.btnSHA384.IconVisible = true;
            this.btnSHA384.IconZoom = 90D;
            this.btnSHA384.IsTab = false;
            this.btnSHA384.Location = new System.Drawing.Point(25, 185);
            this.btnSHA384.Margin = new System.Windows.Forms.Padding(4);
            this.btnSHA384.Name = "btnSHA384";
            this.btnSHA384.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA384.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSHA384.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSHA384.selected = false;
            this.btnSHA384.Size = new System.Drawing.Size(117, 50);
            this.btnSHA384.TabIndex = 7;
            this.btnSHA384.Text = "SHA384";
            this.btnSHA384.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSHA384.Textcolor = System.Drawing.Color.White;
            this.btnSHA384.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA384.Click += new System.EventHandler(this.btnSHA384_Click);
            // 
            // btnSHA1
            // 
            this.btnSHA1.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnSHA1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSHA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSHA1.BackgroundImage")));
            this.btnSHA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSHA1.BorderRadius = 0;
            this.btnSHA1.ButtonText = "SHA1";
            this.btnSHA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSHA1.DisabledColor = System.Drawing.Color.Gray;
            this.btnSHA1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSHA1.Iconimage = null;
            this.btnSHA1.Iconimage_right = null;
            this.btnSHA1.Iconimage_right_Selected = null;
            this.btnSHA1.Iconimage_Selected = null;
            this.btnSHA1.IconMarginLeft = 0;
            this.btnSHA1.IconMarginRight = 0;
            this.btnSHA1.IconRightVisible = true;
            this.btnSHA1.IconRightZoom = 0D;
            this.btnSHA1.IconVisible = true;
            this.btnSHA1.IconZoom = 90D;
            this.btnSHA1.IsTab = false;
            this.btnSHA1.Location = new System.Drawing.Point(174, 108);
            this.btnSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA1.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSHA1.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSHA1.selected = false;
            this.btnSHA1.Size = new System.Drawing.Size(117, 50);
            this.btnSHA1.TabIndex = 5;
            this.btnSHA1.Text = "SHA1";
            this.btnSHA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSHA1.Textcolor = System.Drawing.Color.White;
            this.btnSHA1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA1.Click += new System.EventHandler(this.btnSHA1_Click);
            // 
            // btnSHA256
            // 
            this.btnSHA256.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnSHA256.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSHA256.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA256.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSHA256.BackgroundImage")));
            this.btnSHA256.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSHA256.BorderRadius = 0;
            this.btnSHA256.ButtonText = "SHA256";
            this.btnSHA256.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSHA256.DisabledColor = System.Drawing.Color.Gray;
            this.btnSHA256.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSHA256.Iconimage = null;
            this.btnSHA256.Iconimage_right = null;
            this.btnSHA256.Iconimage_right_Selected = null;
            this.btnSHA256.Iconimage_Selected = null;
            this.btnSHA256.IconMarginLeft = 0;
            this.btnSHA256.IconMarginRight = 0;
            this.btnSHA256.IconRightVisible = true;
            this.btnSHA256.IconRightZoom = 0D;
            this.btnSHA256.IconVisible = true;
            this.btnSHA256.IconZoom = 90D;
            this.btnSHA256.IsTab = false;
            this.btnSHA256.Location = new System.Drawing.Point(321, 108);
            this.btnSHA256.Margin = new System.Windows.Forms.Padding(4);
            this.btnSHA256.Name = "btnSHA256";
            this.btnSHA256.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHA256.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSHA256.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSHA256.selected = false;
            this.btnSHA256.Size = new System.Drawing.Size(117, 50);
            this.btnSHA256.TabIndex = 6;
            this.btnSHA256.Text = "SHA256";
            this.btnSHA256.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSHA256.Textcolor = System.Drawing.Color.White;
            this.btnSHA256.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA256.Click += new System.EventHandler(this.btnSHA256_Click);
            // 
            // btnROT13
            // 
            this.btnROT13.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnROT13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnROT13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnROT13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnROT13.BackgroundImage")));
            this.btnROT13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnROT13.BorderRadius = 0;
            this.btnROT13.ButtonText = "ROT13";
            this.btnROT13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnROT13.DisabledColor = System.Drawing.Color.Gray;
            this.btnROT13.Iconcolor = System.Drawing.Color.Transparent;
            this.btnROT13.Iconimage = null;
            this.btnROT13.Iconimage_right = null;
            this.btnROT13.Iconimage_right_Selected = null;
            this.btnROT13.Iconimage_Selected = null;
            this.btnROT13.IconMarginLeft = 0;
            this.btnROT13.IconMarginRight = 0;
            this.btnROT13.IconRightVisible = true;
            this.btnROT13.IconRightZoom = 0D;
            this.btnROT13.IconVisible = true;
            this.btnROT13.IconZoom = 90D;
            this.btnROT13.IsTab = false;
            this.btnROT13.Location = new System.Drawing.Point(174, 29);
            this.btnROT13.Margin = new System.Windows.Forms.Padding(4);
            this.btnROT13.Name = "btnROT13";
            this.btnROT13.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnROT13.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnROT13.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnROT13.selected = false;
            this.btnROT13.Size = new System.Drawing.Size(117, 50);
            this.btnROT13.TabIndex = 3;
            this.btnROT13.Text = "ROT13";
            this.btnROT13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnROT13.Textcolor = System.Drawing.Color.White;
            this.btnROT13.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnROT13.Click += new System.EventHandler(this.btnROT13_Click);
            // 
            // btnBase64
            // 
            this.btnBase64.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnBase64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBase64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBase64.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBase64.BackgroundImage")));
            this.btnBase64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBase64.BorderRadius = 0;
            this.btnBase64.ButtonText = "Base64";
            this.btnBase64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBase64.DisabledColor = System.Drawing.Color.Gray;
            this.btnBase64.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBase64.Iconimage = null;
            this.btnBase64.Iconimage_right = null;
            this.btnBase64.Iconimage_right_Selected = null;
            this.btnBase64.Iconimage_Selected = null;
            this.btnBase64.IconMarginLeft = 0;
            this.btnBase64.IconMarginRight = 0;
            this.btnBase64.IconRightVisible = true;
            this.btnBase64.IconRightZoom = 0D;
            this.btnBase64.IconVisible = true;
            this.btnBase64.IconZoom = 90D;
            this.btnBase64.IsTab = false;
            this.btnBase64.Location = new System.Drawing.Point(321, 29);
            this.btnBase64.Margin = new System.Windows.Forms.Padding(4);
            this.btnBase64.Name = "btnBase64";
            this.btnBase64.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBase64.OnHovercolor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBase64.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBase64.selected = false;
            this.btnBase64.Size = new System.Drawing.Size(117, 50);
            this.btnBase64.TabIndex = 9;
            this.btnBase64.Text = "Base64";
            this.btnBase64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBase64.Textcolor = System.Drawing.Color.White;
            this.btnBase64.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase64.Click += new System.EventHandler(this.btnBase64_Click);
            // 
            // frmArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 418);
            this.Controls.Add(this.pnlButon);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encoder";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            this.pnlButon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnCikis;
        private Bunifu.Framework.UI.BunifuImageButton btnRestoreDown;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Label lblEncoder;
        private Bunifu.Framework.UI.BunifuFlatButton btnSezar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMD5;
        private System.Windows.Forms.Panel pnlButon;
        private Bunifu.Framework.UI.BunifuFlatButton btnROT13;
        private Bunifu.Framework.UI.BunifuFlatButton btnSHA512;
        private Bunifu.Framework.UI.BunifuFlatButton btnSHA384;
        private Bunifu.Framework.UI.BunifuFlatButton btnSHA1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSHA256;
        private Bunifu.Framework.UI.BunifuFlatButton btnBase64;
    }
}

