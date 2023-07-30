namespace Auto_Steam_Fix
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SteamFix = new Bunifu.Framework.UI.BunifuImageButton();
            this.DLCUIcon = new Bunifu.Framework.UI.BunifuImageButton();
            this.Version_Label = new MetroFramework.Controls.MetroLabel();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CreditMain = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Forum = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Discord = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Exit2 = new System.Windows.Forms.PictureBox();
            this.Exit1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Header = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.DLCBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.dlcUnlocker1 = new Auto_Steam_Fix.DLCUnlocker();
            this.steamFix1 = new Auto_Steam_Fix.SteamFix();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SteamFix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DLCUIcon)).BeginInit();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit1)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DLCBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(101, 357);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(80, 21);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "SteamFix";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(350, 357);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(113, 21);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "DLC Unlocker";
            // 
            // SteamFix
            // 
            this.SteamFix.BackColor = System.Drawing.Color.Transparent;
            this.SteamFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.SteamFix, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.SteamFix, BunifuAnimatorNS.DecorationType.None);
            this.SteamFix.Image = ((System.Drawing.Image)(resources.GetObject("SteamFix.Image")));
            this.SteamFix.ImageActive = null;
            this.SteamFix.Location = new System.Drawing.Point(69, 221);
            this.SteamFix.Name = "SteamFix";
            this.SteamFix.Size = new System.Drawing.Size(132, 129);
            this.SteamFix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SteamFix.TabIndex = 5;
            this.SteamFix.TabStop = false;
            this.SteamFix.Zoom = 10;
            this.SteamFix.Click += new System.EventHandler(this.SteamFix_Click);
            // 
            // DLCUIcon
            // 
            this.DLCUIcon.BackColor = System.Drawing.Color.Transparent;
            this.DLCUIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.DLCUIcon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.DLCUIcon, BunifuAnimatorNS.DecorationType.None);
            this.DLCUIcon.Image = ((System.Drawing.Image)(resources.GetObject("DLCUIcon.Image")));
            this.DLCUIcon.ImageActive = null;
            this.DLCUIcon.Location = new System.Drawing.Point(341, 221);
            this.DLCUIcon.Name = "DLCUIcon";
            this.DLCUIcon.Size = new System.Drawing.Size(132, 129);
            this.DLCUIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DLCUIcon.TabIndex = 6;
            this.DLCUIcon.TabStop = false;
            this.DLCUIcon.Zoom = 10;
            this.DLCUIcon.Click += new System.EventHandler(this.DLCUIcon_Click);
            // 
            // Version_Label
            // 
            this.Version_Label.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.Version_Label, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Version_Label, BunifuAnimatorNS.DecorationType.None);
            this.Version_Label.Location = new System.Drawing.Point(479, 622);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(44, 19);
            this.Version_Label.TabIndex = 8;
            this.Version_Label.Text = "v 2.1.5";
            this.Version_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SideMenu.Controls.Add(this.bunifuFlatButton1);
            this.SideMenu.Controls.Add(this.CreditMain);
            this.SideMenu.Controls.Add(this.bunifuImageButton2);
            this.SideMenu.Controls.Add(this.Forum);
            this.SideMenu.Controls.Add(this.Discord);
            this.bunifuTransition2.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.SideMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SideMenu.Location = new System.Drawing.Point(-1, 39);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(51, 397);
            this.SideMenu.TabIndex = 10;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Check out my YT";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(6, 179);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(240, 48);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "   Check out my YT";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // CreditMain
            // 
            this.CreditMain.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.CreditMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.CreditMain, BunifuAnimatorNS.DecorationType.None);
            this.CreditMain.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditMain.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreditMain.Location = new System.Drawing.Point(16, 20);
            this.CreditMain.Name = "CreditMain";
            this.CreditMain.Size = new System.Drawing.Size(162, 18);
            this.CreditMain.TabIndex = 14;
            this.CreditMain.Text = "Made By ManiacKnight";
            this.CreditMain.Visible = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(9, 18);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 11;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Forum
            // 
            this.Forum.Activecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.Forum.BackColor = System.Drawing.Color.Transparent;
            this.Forum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forum.BorderRadius = 0;
            this.Forum.ButtonText = "   Join Our Forums";
            this.Forum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Forum, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Forum, BunifuAnimatorNS.DecorationType.None);
            this.Forum.DisabledColor = System.Drawing.Color.Gray;
            this.Forum.Iconcolor = System.Drawing.Color.Transparent;
            this.Forum.Iconimage = ((System.Drawing.Image)(resources.GetObject("Forum.Iconimage")));
            this.Forum.Iconimage_right = null;
            this.Forum.Iconimage_right_Selected = null;
            this.Forum.Iconimage_Selected = null;
            this.Forum.IconMarginLeft = 0;
            this.Forum.IconMarginRight = 0;
            this.Forum.IconRightVisible = true;
            this.Forum.IconRightZoom = 0D;
            this.Forum.IconVisible = true;
            this.Forum.IconZoom = 50D;
            this.Forum.IsTab = false;
            this.Forum.Location = new System.Drawing.Point(6, 125);
            this.Forum.Name = "Forum";
            this.Forum.Normalcolor = System.Drawing.Color.Transparent;
            this.Forum.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark;
            this.Forum.OnHoverTextColor = System.Drawing.Color.White;
            this.Forum.selected = false;
            this.Forum.Size = new System.Drawing.Size(240, 48);
            this.Forum.TabIndex = 13;
            this.Forum.Text = "   Join Our Forums";
            this.Forum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Forum.Textcolor = System.Drawing.Color.Gainsboro;
            this.Forum.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forum.Visible = false;
            this.Forum.Click += new System.EventHandler(this.Forum_Click);
            // 
            // Discord
            // 
            this.Discord.Activecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.Discord.BackColor = System.Drawing.Color.Transparent;
            this.Discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Discord.BorderRadius = 0;
            this.Discord.ButtonText = "   Join Our Discord";
            this.Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Discord, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Discord, BunifuAnimatorNS.DecorationType.None);
            this.Discord.DisabledColor = System.Drawing.Color.Gray;
            this.Discord.Iconcolor = System.Drawing.Color.Transparent;
            this.Discord.Iconimage = ((System.Drawing.Image)(resources.GetObject("Discord.Iconimage")));
            this.Discord.Iconimage_right = null;
            this.Discord.Iconimage_right_Selected = null;
            this.Discord.Iconimage_Selected = null;
            this.Discord.IconMarginLeft = 0;
            this.Discord.IconMarginRight = 0;
            this.Discord.IconRightVisible = true;
            this.Discord.IconRightZoom = 0D;
            this.Discord.IconVisible = true;
            this.Discord.IconZoom = 50D;
            this.Discord.IsTab = false;
            this.Discord.Location = new System.Drawing.Point(6, 71);
            this.Discord.Name = "Discord";
            this.Discord.Normalcolor = System.Drawing.Color.Transparent;
            this.Discord.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark;
            this.Discord.OnHoverTextColor = System.Drawing.Color.White;
            this.Discord.selected = false;
            this.Discord.Size = new System.Drawing.Size(234, 48);
            this.Discord.TabIndex = 12;
            this.Discord.Text = "   Join Our Discord";
            this.Discord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Discord.Textcolor = System.Drawing.Color.Gainsboro;
            this.Discord.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discord.Visible = false;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // Exit2
            // 
            this.Exit2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.Exit2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Exit2, BunifuAnimatorNS.DecorationType.None);
            this.Exit2.Image = ((System.Drawing.Image)(resources.GetObject("Exit2.Image")));
            this.Exit2.Location = new System.Drawing.Point(495, 8);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(27, 26);
            this.Exit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit2.TabIndex = 1;
            this.Exit2.TabStop = false;
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            this.Exit2.MouseLeave += new System.EventHandler(this.Exit2_MouseLeave);
            // 
            // Exit1
            // 
            this.Exit1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.Exit1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Exit1, BunifuAnimatorNS.DecorationType.None);
            this.Exit1.Image = ((System.Drawing.Image)(resources.GetObject("Exit1.Image")));
            this.Exit1.Location = new System.Drawing.Point(495, 8);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(27, 25);
            this.Exit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit1.TabIndex = 1;
            this.Exit1.TabStop = false;
            this.Exit1.MouseEnter += new System.EventHandler(this.Exit1_MouseEnter);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(180, 22);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Auto SteamFix Tool";
            // 
            // Header
            // 
            this.Header.AllowDrop = true;
            this.Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header.BackgroundImage")));
            this.Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header.Controls.Add(this.bunifuCustomLabel1);
            this.Header.Controls.Add(this.Exit1);
            this.Header.Controls.Add(this.Exit2);
            this.bunifuTransition2.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.GradientBottomLeft = System.Drawing.Color.Lime;
            this.Header.GradientBottomRight = System.Drawing.Color.LimeGreen;
            this.Header.GradientTopLeft = System.Drawing.Color.White;
            this.Header.GradientTopRight = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Quality = 10;
            this.Header.Size = new System.Drawing.Size(534, 39);
            this.Header.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(15, 84);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Visible = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // DLCBack
            // 
            this.DLCBack.BackColor = System.Drawing.Color.White;
            this.bunifuTransition2.SetDecoration(this.DLCBack, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.DLCBack, BunifuAnimatorNS.DecorationType.None);
            this.DLCBack.Image = ((System.Drawing.Image)(resources.GetObject("DLCBack.Image")));
            this.DLCBack.ImageActive = null;
            this.DLCBack.Location = new System.Drawing.Point(18, 84);
            this.DLCBack.Name = "DLCBack";
            this.DLCBack.Size = new System.Drawing.Size(46, 35);
            this.DLCBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DLCBack.TabIndex = 14;
            this.DLCBack.TabStop = false;
            this.DLCBack.Visible = false;
            this.DLCBack.Zoom = 10;
            this.DLCBack.Click += new System.EventHandler(this.DLCBack_Click);
            // 
            // dlcUnlocker1
            // 
            this.dlcUnlocker1.BackColor = System.Drawing.Color.White;
            this.dlcUnlocker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.dlcUnlocker1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.dlcUnlocker1, BunifuAnimatorNS.DecorationType.None);
            this.dlcUnlocker1.Location = new System.Drawing.Point(2, 42);
            this.dlcUnlocker1.Name = "dlcUnlocker1";
            this.dlcUnlocker1.Size = new System.Drawing.Size(529, 599);
            this.dlcUnlocker1.TabIndex = 12;
            this.dlcUnlocker1.Visible = false;
            // 
            // steamFix1
            // 
            this.steamFix1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuTransition1.SetDecoration(this.steamFix1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.steamFix1, BunifuAnimatorNS.DecorationType.None);
            this.steamFix1.Location = new System.Drawing.Point(-1, 39);
            this.steamFix1.Name = "steamFix1";
            this.steamFix1.Size = new System.Drawing.Size(531, 602);
            this.steamFix1.TabIndex = 11;
            this.steamFix1.Visible = false;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation3;
            this.bunifuTransition2.Interval = 30;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.Header;
            this.DragControl.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(534, 646);
            this.Controls.Add(this.DLCBack);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.dlcUnlocker1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.steamFix1);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Version_Label);
            this.Controls.Add(this.SteamFix);
            this.Controls.Add(this.DLCUIcon);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SteamFix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DLCUIcon)).EndInit();
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit1)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DLCBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton SteamFix;
        private Bunifu.Framework.UI.BunifuImageButton DLCUIcon;
        private MetroFramework.Controls.MetroLabel Version_Label;
        private System.Windows.Forms.Panel SideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton Forum;
        private Bunifu.Framework.UI.BunifuFlatButton Discord;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private Bunifu.Framework.UI.BunifuCustomLabel CreditMain;
        private SteamFix steamFix1;
        private Bunifu.Framework.UI.BunifuGradientPanel Header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox Exit1;
        private System.Windows.Forms.PictureBox Exit2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton DLCBack;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private DLCUnlocker dlcUnlocker1;
    }
}

