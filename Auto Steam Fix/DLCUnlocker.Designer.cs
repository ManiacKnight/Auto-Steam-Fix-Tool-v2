namespace Auto_Steam_Fix
{
    partial class DLCUnlocker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLCUnlocker));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.EventLog_Animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SteamFixTab = new MetroFramework.Controls.MetroTabPage();
            this.TestBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BrowseB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FolderL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FolderT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Btn_Apply = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Event_Logger = new System.Windows.Forms.Panel();
            this.Replacing_Log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Failed_Log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.api64Found_Log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.apiFound_log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Searching32_Log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Searching64_log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.apiNotFound_Log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.api64NotFound_Log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Success_Log = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_ApplyDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AlreadyApplied = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SteamFixTabControl = new MetroFramework.Controls.MetroTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SteamFixTab.SuspendLayout();
            this.Event_Logger.SuspendLayout();
            this.SteamFixTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // EventLog_Animation
            // 
            this.EventLog_Animation.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.EventLog_Animation.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 1F;
            this.EventLog_Animation.DefaultAnimation = animation7;
            this.EventLog_Animation.Interval = 30;
            // 
            // SteamFixTab
            // 
            this.SteamFixTab.Controls.Add(this.Event_Logger);
            this.SteamFixTab.Controls.Add(this.Btn_Apply);
            this.SteamFixTab.Controls.Add(this.FolderT);
            this.SteamFixTab.Controls.Add(this.FolderL);
            this.SteamFixTab.Controls.Add(this.BrowseB);
            this.SteamFixTab.Controls.Add(this.bunifuCustomLabel5);
            this.SteamFixTab.Controls.Add(this.TestBox);
            this.EventLog_Animation.SetDecoration(this.SteamFixTab, BunifuAnimatorNS.DecorationType.None);
            this.SteamFixTab.HorizontalScrollbarBarColor = true;
            this.SteamFixTab.HorizontalScrollbarHighlightOnWheel = false;
            this.SteamFixTab.HorizontalScrollbarSize = 10;
            this.SteamFixTab.Location = new System.Drawing.Point(4, 38);
            this.SteamFixTab.Name = "SteamFixTab";
            this.SteamFixTab.Size = new System.Drawing.Size(526, 604);
            this.SteamFixTab.TabIndex = 0;
            this.SteamFixTab.Text = "Apply DLC Unlocker";
            this.SteamFixTab.VerticalScrollbarBarColor = true;
            this.SteamFixTab.VerticalScrollbarHighlightOnWheel = false;
            this.SteamFixTab.VerticalScrollbarSize = 10;
            this.SteamFixTab.Click += new System.EventHandler(this.SteamFixTab_Click);
            // 
            // TestBox
            // 
            this.TestBox.BorderColorFocused = System.Drawing.Color.Gray;
            this.TestBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TestBox.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.TestBox.BorderThickness = 3;
            this.TestBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventLog_Animation.SetDecoration(this.TestBox, BunifuAnimatorNS.DecorationType.None);
            this.TestBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TestBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TestBox.isPassword = false;
            this.TestBox.Location = new System.Drawing.Point(160, 240);
            this.TestBox.Margin = new System.Windows.Forms.Padding(4);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(206, 44);
            this.TestBox.TabIndex = 17;
            this.TestBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TestBox.OnValueChanged += new System.EventHandler(this.TestBox_OnValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.EventLog_Animation.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(19, 254);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(127, 21);
            this.bunifuCustomLabel5.TabIndex = 18;
            this.bunifuCustomLabel5.Text = "Store Page Link";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // BrowseB
            // 
            this.BrowseB.ActiveBorderThickness = 1;
            this.BrowseB.ActiveCornerRadius = 20;
            this.BrowseB.ActiveFillColor = System.Drawing.Color.Silver;
            this.BrowseB.ActiveForecolor = System.Drawing.Color.White;
            this.BrowseB.ActiveLineColor = System.Drawing.Color.Silver;
            this.BrowseB.BackColor = System.Drawing.Color.Transparent;
            this.BrowseB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseB.BackgroundImage")));
            this.BrowseB.ButtonText = "Browse";
            this.BrowseB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EventLog_Animation.SetDecoration(this.BrowseB, BunifuAnimatorNS.DecorationType.None);
            this.BrowseB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseB.ForeColor = System.Drawing.Color.Black;
            this.BrowseB.IdleBorderThickness = 1;
            this.BrowseB.IdleCornerRadius = 20;
            this.BrowseB.IdleFillColor = System.Drawing.Color.White;
            this.BrowseB.IdleForecolor = System.Drawing.Color.Black;
            this.BrowseB.IdleLineColor = System.Drawing.Color.Silver;
            this.BrowseB.Location = new System.Drawing.Point(398, 68);
            this.BrowseB.Margin = new System.Windows.Forms.Padding(5);
            this.BrowseB.Name = "BrowseB";
            this.BrowseB.Size = new System.Drawing.Size(113, 41);
            this.BrowseB.TabIndex = 13;
            this.BrowseB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowseB.Click += new System.EventHandler(this.BrowseB_Click);
            // 
            // FolderL
            // 
            this.FolderL.AutoSize = true;
            this.FolderL.BackColor = System.Drawing.Color.Transparent;
            this.EventLog_Animation.SetDecoration(this.FolderL, BunifuAnimatorNS.DecorationType.None);
            this.FolderL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderL.Location = new System.Drawing.Point(19, 79);
            this.FolderL.Name = "FolderL";
            this.FolderL.Size = new System.Drawing.Size(134, 21);
            this.FolderL.TabIndex = 9;
            this.FolderL.Text = "Game Directory";
            this.FolderL.Click += new System.EventHandler(this.FolderL_Click_1);
            // 
            // FolderT
            // 
            this.FolderT.BorderColorFocused = System.Drawing.Color.Gray;
            this.FolderT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FolderT.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.FolderT.BorderThickness = 3;
            this.FolderT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventLog_Animation.SetDecoration(this.FolderT, BunifuAnimatorNS.DecorationType.None);
            this.FolderT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FolderT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FolderT.isPassword = false;
            this.FolderT.Location = new System.Drawing.Point(160, 68);
            this.FolderT.Margin = new System.Windows.Forms.Padding(4);
            this.FolderT.Name = "FolderT";
            this.FolderT.Size = new System.Drawing.Size(206, 44);
            this.FolderT.TabIndex = 10;
            this.FolderT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FolderT.OnValueChanged += new System.EventHandler(this.FolderT_OnValueChanged_2);
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Activecolor = System.Drawing.Color.Silver;
            this.Btn_Apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Apply.BackColor = System.Drawing.Color.DimGray;
            this.Btn_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Apply.BorderRadius = 0;
            this.Btn_Apply.ButtonText = "Apply DLC Fix!";
            this.Btn_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EventLog_Animation.SetDecoration(this.Btn_Apply, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Apply.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Apply.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Apply.Iconimage = null;
            this.Btn_Apply.Iconimage_right = null;
            this.Btn_Apply.Iconimage_right_Selected = null;
            this.Btn_Apply.Iconimage_Selected = null;
            this.Btn_Apply.IconMarginLeft = 0;
            this.Btn_Apply.IconMarginRight = 0;
            this.Btn_Apply.IconRightVisible = false;
            this.Btn_Apply.IconRightZoom = 0D;
            this.Btn_Apply.IconVisible = false;
            this.Btn_Apply.IconZoom = 90D;
            this.Btn_Apply.IsTab = false;
            this.Btn_Apply.Location = new System.Drawing.Point(181, 455);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Normalcolor = System.Drawing.Color.DimGray;
            this.Btn_Apply.OnHovercolor = System.Drawing.Color.DarkGray;
            this.Btn_Apply.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Apply.selected = false;
            this.Btn_Apply.Size = new System.Drawing.Size(160, 48);
            this.Btn_Apply.TabIndex = 15;
            this.Btn_Apply.Text = "Apply DLC Fix!";
            this.Btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Apply.Textcolor = System.Drawing.Color.White;
            this.Btn_Apply.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // Event_Logger
            // 
            this.Event_Logger.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Event_Logger.Controls.Add(this.AlreadyApplied);
            this.Event_Logger.Controls.Add(this.btn_ApplyDone);
            this.Event_Logger.Controls.Add(this.Success_Log);
            this.Event_Logger.Controls.Add(this.bunifuCustomLabel4);
            this.Event_Logger.Controls.Add(this.api64NotFound_Log);
            this.Event_Logger.Controls.Add(this.apiNotFound_Log);
            this.Event_Logger.Controls.Add(this.Searching64_log);
            this.Event_Logger.Controls.Add(this.Searching32_Log);
            this.Event_Logger.Controls.Add(this.apiFound_log);
            this.Event_Logger.Controls.Add(this.api64Found_Log);
            this.Event_Logger.Controls.Add(this.Failed_Log);
            this.Event_Logger.Controls.Add(this.Replacing_Log);
            this.EventLog_Animation.SetDecoration(this.Event_Logger, BunifuAnimatorNS.DecorationType.None);
            this.Event_Logger.Location = new System.Drawing.Point(57, 171);
            this.Event_Logger.Name = "Event_Logger";
            this.Event_Logger.Size = new System.Drawing.Size(409, 422);
            this.Event_Logger.TabIndex = 16;
            this.Event_Logger.Visible = false;
            this.Event_Logger.Paint += new System.Windows.Forms.PaintEventHandler(this.Event_Logger_Paint);
            // 
            // Replacing_Log
            // 
            this.Replacing_Log.AutoSize = true;
            this.Replacing_Log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.Replacing_Log, BunifuAnimatorNS.DecorationType.None);
            this.Replacing_Log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replacing_Log.ForeColor = System.Drawing.SystemColors.Control;
            this.Replacing_Log.Location = new System.Drawing.Point(1, 218);
            this.Replacing_Log.Name = "Replacing_Log";
            this.Replacing_Log.Size = new System.Drawing.Size(430, 21);
            this.Replacing_Log.TabIndex = 24;
            this.Replacing_Log.Text = "                                 Fetching DLC List....                           " +
    "        ";
            this.Replacing_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Replacing_Log.Visible = false;
            this.Replacing_Log.Click += new System.EventHandler(this.Replacing_Log_Click);
            // 
            // Failed_Log
            // 
            this.Failed_Log.AutoSize = true;
            this.Failed_Log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.Failed_Log, BunifuAnimatorNS.DecorationType.None);
            this.Failed_Log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failed_Log.ForeColor = System.Drawing.Color.DarkRed;
            this.Failed_Log.Location = new System.Drawing.Point(-2, 218);
            this.Failed_Log.Name = "Failed_Log";
            this.Failed_Log.Size = new System.Drawing.Size(412, 21);
            this.Failed_Log.TabIndex = 26;
            this.Failed_Log.Text = "                                           Failed!                               " +
    "              ";
            this.Failed_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Failed_Log.Visible = false;
            this.Failed_Log.Click += new System.EventHandler(this.Failed_Log_Click);
            // 
            // api64Found_Log
            // 
            this.api64Found_Log.AutoSize = true;
            this.api64Found_Log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.api64Found_Log, BunifuAnimatorNS.DecorationType.None);
            this.api64Found_Log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.api64Found_Log.ForeColor = System.Drawing.Color.Lime;
            this.api64Found_Log.Location = new System.Drawing.Point(1, 180);
            this.api64Found_Log.Name = "api64Found_Log";
            this.api64Found_Log.Size = new System.Drawing.Size(411, 21);
            this.api64Found_Log.TabIndex = 21;
            this.api64Found_Log.Text = "                           steam_api64 was found!                          ";
            this.api64Found_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.api64Found_Log.Visible = false;
            this.api64Found_Log.Click += new System.EventHandler(this.api64Found_Log_Click);
            // 
            // apiFound_log
            // 
            this.apiFound_log.AutoSize = true;
            this.apiFound_log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.apiFound_log, BunifuAnimatorNS.DecorationType.None);
            this.apiFound_log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiFound_log.ForeColor = System.Drawing.Color.Lime;
            this.apiFound_log.Location = new System.Drawing.Point(1, 96);
            this.apiFound_log.Name = "apiFound_log";
            this.apiFound_log.Size = new System.Drawing.Size(409, 21);
            this.apiFound_log.TabIndex = 19;
            this.apiFound_log.Text = "                              steam_api was found!                           ";
            this.apiFound_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.apiFound_log.Visible = false;
            this.apiFound_log.Click += new System.EventHandler(this.apiFound_log_Click);
            // 
            // Searching32_Log
            // 
            this.Searching32_Log.AutoSize = true;
            this.Searching32_Log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.Searching32_Log, BunifuAnimatorNS.DecorationType.None);
            this.Searching32_Log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searching32_Log.ForeColor = System.Drawing.SystemColors.Control;
            this.Searching32_Log.Location = new System.Drawing.Point(2, 57);
            this.Searching32_Log.Name = "Searching32_Log";
            this.Searching32_Log.Size = new System.Drawing.Size(406, 21);
            this.Searching32_Log.TabIndex = 17;
            this.Searching32_Log.Text = "                      Searching For steam_api.dll                        ";
            this.Searching32_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Searching32_Log.Visible = false;
            this.Searching32_Log.Click += new System.EventHandler(this.Searching32_Log_Click);
            // 
            // Searching64_log
            // 
            this.Searching64_log.AutoSize = true;
            this.Searching64_log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.Searching64_log, BunifuAnimatorNS.DecorationType.None);
            this.Searching64_log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searching64_log.ForeColor = System.Drawing.SystemColors.Control;
            this.Searching64_log.Location = new System.Drawing.Point(1, 139);
            this.Searching64_log.Name = "Searching64_log";
            this.Searching64_log.Size = new System.Drawing.Size(416, 21);
            this.Searching64_log.TabIndex = 18;
            this.Searching64_log.Text = "                      Searching For steam_api64.dll                      ";
            this.Searching64_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Searching64_log.Visible = false;
            this.Searching64_log.Click += new System.EventHandler(this.Searching64_log_Click);
            // 
            // apiNotFound_Log
            // 
            this.apiNotFound_Log.AutoSize = true;
            this.apiNotFound_Log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.apiNotFound_Log, BunifuAnimatorNS.DecorationType.None);
            this.apiNotFound_Log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiNotFound_Log.ForeColor = System.Drawing.Color.DarkRed;
            this.apiNotFound_Log.Location = new System.Drawing.Point(1, 96);
            this.apiNotFound_Log.Name = "apiNotFound_Log";
            this.apiNotFound_Log.Size = new System.Drawing.Size(408, 21);
            this.apiNotFound_Log.TabIndex = 20;
            this.apiNotFound_Log.Text = "                        steam_api was not found!                         ";
            this.apiNotFound_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.apiNotFound_Log.Visible = false;
            this.apiNotFound_Log.Click += new System.EventHandler(this.apiNotFound_Log_Click);
            // 
            // api64NotFound_Log
            // 
            this.api64NotFound_Log.AutoSize = true;
            this.api64NotFound_Log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.api64NotFound_Log, BunifuAnimatorNS.DecorationType.None);
            this.api64NotFound_Log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.api64NotFound_Log.ForeColor = System.Drawing.Color.DarkRed;
            this.api64NotFound_Log.Location = new System.Drawing.Point(-4, 180);
            this.api64NotFound_Log.Name = "api64NotFound_Log";
            this.api64NotFound_Log.Size = new System.Drawing.Size(414, 21);
            this.api64NotFound_Log.TabIndex = 22;
            this.api64NotFound_Log.Text = "                         steam_api64 was not found!                     ";
            this.api64NotFound_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.api64NotFound_Log.Visible = false;
            this.api64NotFound_Log.Click += new System.EventHandler(this.api64NotFound_Log_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 218);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(0, 21);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // Success_Log
            // 
            this.Success_Log.AutoSize = true;
            this.Success_Log.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.Success_Log, BunifuAnimatorNS.DecorationType.None);
            this.Success_Log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Success_Log.ForeColor = System.Drawing.Color.Lime;
            this.Success_Log.Location = new System.Drawing.Point(2, 262);
            this.Success_Log.Name = "Success_Log";
            this.Success_Log.Size = new System.Drawing.Size(410, 21);
            this.Success_Log.TabIndex = 25;
            this.Success_Log.Text = "                                        Success!                                 " +
    "           ";
            this.Success_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Success_Log.Visible = false;
            this.Success_Log.Click += new System.EventHandler(this.Success_Log_Click);
            // 
            // btn_ApplyDone
            // 
            this.btn_ApplyDone.Activecolor = System.Drawing.Color.Silver;
            this.btn_ApplyDone.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_ApplyDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ApplyDone.BorderRadius = 0;
            this.btn_ApplyDone.ButtonText = "Done";
            this.btn_ApplyDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EventLog_Animation.SetDecoration(this.btn_ApplyDone, BunifuAnimatorNS.DecorationType.None);
            this.btn_ApplyDone.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ApplyDone.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ApplyDone.Iconimage = null;
            this.btn_ApplyDone.Iconimage_right = null;
            this.btn_ApplyDone.Iconimage_right_Selected = null;
            this.btn_ApplyDone.Iconimage_Selected = null;
            this.btn_ApplyDone.IconMarginLeft = 0;
            this.btn_ApplyDone.IconMarginRight = 0;
            this.btn_ApplyDone.IconRightVisible = false;
            this.btn_ApplyDone.IconRightZoom = 0D;
            this.btn_ApplyDone.IconVisible = false;
            this.btn_ApplyDone.IconZoom = 90D;
            this.btn_ApplyDone.IsTab = false;
            this.btn_ApplyDone.Location = new System.Drawing.Point(125, 333);
            this.btn_ApplyDone.Name = "btn_ApplyDone";
            this.btn_ApplyDone.Normalcolor = System.Drawing.Color.YellowGreen;
            this.btn_ApplyDone.OnHovercolor = System.Drawing.Color.OliveDrab;
            this.btn_ApplyDone.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_ApplyDone.selected = false;
            this.btn_ApplyDone.Size = new System.Drawing.Size(160, 48);
            this.btn_ApplyDone.TabIndex = 17;
            this.btn_ApplyDone.Text = "Done";
            this.btn_ApplyDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ApplyDone.Textcolor = System.Drawing.Color.Black;
            this.btn_ApplyDone.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplyDone.Visible = false;
            this.btn_ApplyDone.Click += new System.EventHandler(this.btn_ApplyDone_Click);
            // 
            // AlreadyApplied
            // 
            this.AlreadyApplied.AutoSize = true;
            this.AlreadyApplied.BackColor = System.Drawing.Color.DimGray;
            this.EventLog_Animation.SetDecoration(this.AlreadyApplied, BunifuAnimatorNS.DecorationType.None);
            this.AlreadyApplied.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyApplied.ForeColor = System.Drawing.Color.DarkRed;
            this.AlreadyApplied.Location = new System.Drawing.Point(1, 57);
            this.AlreadyApplied.Name = "AlreadyApplied";
            this.AlreadyApplied.Size = new System.Drawing.Size(411, 21);
            this.AlreadyApplied.TabIndex = 27;
            this.AlreadyApplied.Text = "                        SteamFix Already Applied!                         ";
            this.AlreadyApplied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlreadyApplied.Visible = false;
            this.AlreadyApplied.Click += new System.EventHandler(this.AlreadyApplied_Click);
            // 
            // SteamFixTabControl
            // 
            this.SteamFixTabControl.Controls.Add(this.SteamFixTab);
            this.EventLog_Animation.SetDecoration(this.SteamFixTabControl, BunifuAnimatorNS.DecorationType.None);
            this.SteamFixTabControl.Location = new System.Drawing.Point(0, -5);
            this.SteamFixTabControl.Name = "SteamFixTabControl";
            this.SteamFixTabControl.SelectedIndex = 0;
            this.SteamFixTabControl.Size = new System.Drawing.Size(534, 646);
            this.SteamFixTabControl.Style = MetroFramework.MetroColorStyle.Black;
            this.SteamFixTabControl.TabIndex = 1;
            this.SteamFixTabControl.UseSelectable = true;
            this.SteamFixTabControl.SelectedIndexChanged += new System.EventHandler(this.SteamFixTabControl_SelectedIndexChanged);
            // 
            // DLCUnlocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SteamFixTabControl);
            this.EventLog_Animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "DLCUnlocker";
            this.Size = new System.Drawing.Size(534, 607);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.SteamFixTab.ResumeLayout(false);
            this.SteamFixTab.PerformLayout();
            this.Event_Logger.ResumeLayout(false);
            this.Event_Logger.PerformLayout();
            this.SteamFixTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition EventLog_Animation;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private MetroFramework.Controls.MetroTabControl SteamFixTabControl;
        private MetroFramework.Controls.MetroTabPage SteamFixTab;
        private System.Windows.Forms.Panel Event_Logger;
        private Bunifu.Framework.UI.BunifuCustomLabel AlreadyApplied;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ApplyDone;
        private Bunifu.Framework.UI.BunifuCustomLabel Success_Log;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel api64NotFound_Log;
        private Bunifu.Framework.UI.BunifuCustomLabel apiNotFound_Log;
        private Bunifu.Framework.UI.BunifuCustomLabel Searching64_log;
        private Bunifu.Framework.UI.BunifuCustomLabel Searching32_Log;
        private Bunifu.Framework.UI.BunifuCustomLabel apiFound_log;
        private Bunifu.Framework.UI.BunifuCustomLabel api64Found_Log;
        private Bunifu.Framework.UI.BunifuCustomLabel Failed_Log;
        private Bunifu.Framework.UI.BunifuCustomLabel Replacing_Log;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Apply;
        private Bunifu.Framework.UI.BunifuMetroTextbox FolderT;
        private Bunifu.Framework.UI.BunifuCustomLabel FolderL;
        private Bunifu.Framework.UI.BunifuThinButton2 BrowseB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox TestBox;
    }
}
