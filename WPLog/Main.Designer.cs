namespace WPLog
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._menuConteiner = new System.Windows.Forms.Panel();
            this._donateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this._aboutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this._bottomMenuContainer = new System.Windows.Forms.Panel();
            this._versionLabel = new System.Windows.Forms.Label();
            this._settingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this._monitorBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this._homeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this._logoContainer = new System.Windows.Forms.Panel();
            this._logoImage = new System.Windows.Forms.PictureBox();
            this._logoLabel = new System.Windows.Forms.Label();
            this._upperLogoContainer = new System.Windows.Forms.Panel();
            this._bodyContainer = new System.Windows.Forms.Panel();
            this._workSpaceContainer = new System.Windows.Forms.Panel();
            this._tobBarContainer = new System.Windows.Forms.Panel();
            this._languageBtn = new System.Windows.Forms.Button();
            this._fromTrayBtn = new System.Windows.Forms.Button();
            this._fromMaximumBtn = new System.Windows.Forms.Button();
            this._fromExitBtn = new System.Windows.Forms.Button();
            this._formContainer = new System.Windows.Forms.Panel();
            this._borderRight = new System.Windows.Forms.Panel();
            this._borderDown = new System.Windows.Forms.Panel();
            this._borderAngle = new System.Windows.Forms.Panel();
            this._menuConteiner.SuspendLayout();
            this._bottomMenuContainer.SuspendLayout();
            this._logoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._logoImage)).BeginInit();
            this._bodyContainer.SuspendLayout();
            this._tobBarContainer.SuspendLayout();
            this._formContainer.SuspendLayout();
            this._borderDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuConteiner
            // 
            this._menuConteiner.BackColor = System.Drawing.SystemColors.Window;
            this._menuConteiner.Controls.Add(this._donateBtn);
            this._menuConteiner.Controls.Add(this._aboutBtn);
            this._menuConteiner.Controls.Add(this._bottomMenuContainer);
            this._menuConteiner.Controls.Add(this._settingsBtn);
            this._menuConteiner.Controls.Add(this._monitorBtn);
            this._menuConteiner.Controls.Add(this._homeBtn);
            this._menuConteiner.Controls.Add(this._logoContainer);
            this._menuConteiner.Dock = System.Windows.Forms.DockStyle.Left;
            this._menuConteiner.Location = new System.Drawing.Point(0, 0);
            this._menuConteiner.Name = "_menuConteiner";
            this._menuConteiner.Size = new System.Drawing.Size(150, 590);
            this._menuConteiner.TabIndex = 0;
            // 
            // _donateBtn
            // 
            this._donateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(223)))));
            this._donateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._donateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._donateBtn.BorderRadius = 0;
            this._donateBtn.ButtonText = "Donate";
            this._donateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._donateBtn.DisabledColor = System.Drawing.Color.Gray;
            this._donateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._donateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this._donateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("_donateBtn.Iconimage")));
            this._donateBtn.Iconimage_right = null;
            this._donateBtn.Iconimage_right_Selected = null;
            this._donateBtn.Iconimage_Selected = null;
            this._donateBtn.IconMarginLeft = 0;
            this._donateBtn.IconMarginRight = 0;
            this._donateBtn.IconRightVisible = true;
            this._donateBtn.IconRightZoom = 0D;
            this._donateBtn.IconVisible = true;
            this._donateBtn.IconZoom = 60D;
            this._donateBtn.IsTab = false;
            this._donateBtn.Location = new System.Drawing.Point(0, 288);
            this._donateBtn.Name = "_donateBtn";
            this._donateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._donateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(84)))));
            this._donateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this._donateBtn.selected = false;
            this._donateBtn.Size = new System.Drawing.Size(150, 50);
            this._donateBtn.TabIndex = 6;
            this._donateBtn.Text = "Donate";
            this._donateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._donateBtn.Textcolor = System.Drawing.Color.White;
            this._donateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._donateBtn.Click += new System.EventHandler(this.DonateBtnClick);
            // 
            // _aboutBtn
            // 
            this._aboutBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(223)))));
            this._aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._aboutBtn.BorderRadius = 0;
            this._aboutBtn.ButtonText = "About";
            this._aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._aboutBtn.DisabledColor = System.Drawing.Color.Gray;
            this._aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._aboutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this._aboutBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("_aboutBtn.Iconimage")));
            this._aboutBtn.Iconimage_right = null;
            this._aboutBtn.Iconimage_right_Selected = null;
            this._aboutBtn.Iconimage_Selected = null;
            this._aboutBtn.IconMarginLeft = 0;
            this._aboutBtn.IconMarginRight = 0;
            this._aboutBtn.IconRightVisible = true;
            this._aboutBtn.IconRightZoom = 0D;
            this._aboutBtn.IconVisible = true;
            this._aboutBtn.IconZoom = 60D;
            this._aboutBtn.IsTab = false;
            this._aboutBtn.Location = new System.Drawing.Point(0, 238);
            this._aboutBtn.Name = "_aboutBtn";
            this._aboutBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._aboutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(84)))));
            this._aboutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this._aboutBtn.selected = false;
            this._aboutBtn.Size = new System.Drawing.Size(150, 50);
            this._aboutBtn.TabIndex = 5;
            this._aboutBtn.Text = "About";
            this._aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._aboutBtn.Textcolor = System.Drawing.Color.White;
            this._aboutBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._aboutBtn.Click += new System.EventHandler(this.AboutBtnClick);
            // 
            // _bottomMenuContainer
            // 
            this._bottomMenuContainer.BackColor = System.Drawing.Color.White;
            this._bottomMenuContainer.Controls.Add(this._versionLabel);
            this._bottomMenuContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomMenuContainer.Location = new System.Drawing.Point(0, 567);
            this._bottomMenuContainer.Name = "_bottomMenuContainer";
            this._bottomMenuContainer.Size = new System.Drawing.Size(150, 23);
            this._bottomMenuContainer.TabIndex = 4;
            // 
            // _versionLabel
            // 
            this._versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this._versionLabel.Location = new System.Drawing.Point(0, 0);
            this._versionLabel.Name = "_versionLabel";
            this._versionLabel.Size = new System.Drawing.Size(150, 23);
            this._versionLabel.TabIndex = 0;
            this._versionLabel.Text = "1.0.0";
            this._versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _settingsBtn
            // 
            this._settingsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(223)))));
            this._settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._settingsBtn.BorderRadius = 0;
            this._settingsBtn.ButtonText = "Settings";
            this._settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._settingsBtn.DisabledColor = System.Drawing.Color.Gray;
            this._settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._settingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this._settingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("_settingsBtn.Iconimage")));
            this._settingsBtn.Iconimage_right = null;
            this._settingsBtn.Iconimage_right_Selected = null;
            this._settingsBtn.Iconimage_Selected = null;
            this._settingsBtn.IconMarginLeft = 0;
            this._settingsBtn.IconMarginRight = 0;
            this._settingsBtn.IconRightVisible = true;
            this._settingsBtn.IconRightZoom = 0D;
            this._settingsBtn.IconVisible = true;
            this._settingsBtn.IconZoom = 60D;
            this._settingsBtn.IsTab = false;
            this._settingsBtn.Location = new System.Drawing.Point(0, 188);
            this._settingsBtn.Name = "_settingsBtn";
            this._settingsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._settingsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(84)))));
            this._settingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this._settingsBtn.selected = false;
            this._settingsBtn.Size = new System.Drawing.Size(150, 50);
            this._settingsBtn.TabIndex = 2;
            this._settingsBtn.Text = "Settings";
            this._settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._settingsBtn.Textcolor = System.Drawing.Color.White;
            this._settingsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._settingsBtn.Click += new System.EventHandler(this.SettingsBtnClick);
            // 
            // _monitorBtn
            // 
            this._monitorBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(223)))));
            this._monitorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._monitorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._monitorBtn.BorderRadius = 0;
            this._monitorBtn.ButtonText = "Monitor";
            this._monitorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._monitorBtn.DisabledColor = System.Drawing.Color.Gray;
            this._monitorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._monitorBtn.Iconcolor = System.Drawing.Color.Transparent;
            this._monitorBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("_monitorBtn.Iconimage")));
            this._monitorBtn.Iconimage_right = null;
            this._monitorBtn.Iconimage_right_Selected = null;
            this._monitorBtn.Iconimage_Selected = null;
            this._monitorBtn.IconMarginLeft = 0;
            this._monitorBtn.IconMarginRight = 0;
            this._monitorBtn.IconRightVisible = true;
            this._monitorBtn.IconRightZoom = 0D;
            this._monitorBtn.IconVisible = true;
            this._monitorBtn.IconZoom = 60D;
            this._monitorBtn.IsTab = false;
            this._monitorBtn.Location = new System.Drawing.Point(0, 138);
            this._monitorBtn.Name = "_monitorBtn";
            this._monitorBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._monitorBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(84)))));
            this._monitorBtn.OnHoverTextColor = System.Drawing.Color.White;
            this._monitorBtn.selected = false;
            this._monitorBtn.Size = new System.Drawing.Size(150, 50);
            this._monitorBtn.TabIndex = 1;
            this._monitorBtn.Text = "Monitor";
            this._monitorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._monitorBtn.Textcolor = System.Drawing.Color.White;
            this._monitorBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._monitorBtn.Click += new System.EventHandler(this.MonitorBtnClick);
            // 
            // _homeBtn
            // 
            this._homeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(223)))));
            this._homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._homeBtn.BorderRadius = 0;
            this._homeBtn.ButtonText = "Home";
            this._homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._homeBtn.DisabledColor = System.Drawing.Color.Gray;
            this._homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._homeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this._homeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("_homeBtn.Iconimage")));
            this._homeBtn.Iconimage_right = null;
            this._homeBtn.Iconimage_right_Selected = null;
            this._homeBtn.Iconimage_Selected = null;
            this._homeBtn.IconMarginLeft = 0;
            this._homeBtn.IconMarginRight = 0;
            this._homeBtn.IconRightVisible = true;
            this._homeBtn.IconRightZoom = 0D;
            this._homeBtn.IconVisible = true;
            this._homeBtn.IconZoom = 60D;
            this._homeBtn.IsTab = false;
            this._homeBtn.Location = new System.Drawing.Point(0, 88);
            this._homeBtn.Name = "_homeBtn";
            this._homeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(170)))));
            this._homeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(84)))));
            this._homeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this._homeBtn.selected = false;
            this._homeBtn.Size = new System.Drawing.Size(150, 50);
            this._homeBtn.TabIndex = 0;
            this._homeBtn.Text = "Home";
            this._homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._homeBtn.Textcolor = System.Drawing.Color.White;
            this._homeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._homeBtn.Click += new System.EventHandler(this.HomeBtnClick);
            // 
            // _logoContainer
            // 
            this._logoContainer.Controls.Add(this._logoImage);
            this._logoContainer.Controls.Add(this._logoLabel);
            this._logoContainer.Controls.Add(this._upperLogoContainer);
            this._logoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this._logoContainer.Location = new System.Drawing.Point(0, 0);
            this._logoContainer.Name = "_logoContainer";
            this._logoContainer.Size = new System.Drawing.Size(150, 88);
            this._logoContainer.TabIndex = 3;
            // 
            // _logoImage
            // 
            this._logoImage.BackColor = System.Drawing.Color.White;
            this._logoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._logoImage.Image = ((System.Drawing.Image)(resources.GetObject("_logoImage.Image")));
            this._logoImage.Location = new System.Drawing.Point(0, 10);
            this._logoImage.Name = "_logoImage";
            this._logoImage.Size = new System.Drawing.Size(150, 48);
            this._logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._logoImage.TabIndex = 0;
            this._logoImage.TabStop = false;
            this._logoImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            // 
            // _logoLabel
            // 
            this._logoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._logoLabel.Location = new System.Drawing.Point(0, 58);
            this._logoLabel.Name = "_logoLabel";
            this._logoLabel.Size = new System.Drawing.Size(150, 30);
            this._logoLabel.TabIndex = 1;
            this._logoLabel.Text = "WP Log";
            this._logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _upperLogoContainer
            // 
            this._upperLogoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this._upperLogoContainer.Location = new System.Drawing.Point(0, 0);
            this._upperLogoContainer.Name = "_upperLogoContainer";
            this._upperLogoContainer.Size = new System.Drawing.Size(150, 10);
            this._upperLogoContainer.TabIndex = 2;
            this._upperLogoContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            // 
            // _bodyContainer
            // 
            this._bodyContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this._bodyContainer.Controls.Add(this._workSpaceContainer);
            this._bodyContainer.Controls.Add(this._tobBarContainer);
            this._bodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bodyContainer.Location = new System.Drawing.Point(150, 0);
            this._bodyContainer.Name = "_bodyContainer";
            this._bodyContainer.Size = new System.Drawing.Size(640, 590);
            this._bodyContainer.TabIndex = 1;
            // 
            // _workSpaceContainer
            // 
            this._workSpaceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._workSpaceContainer.Location = new System.Drawing.Point(0, 29);
            this._workSpaceContainer.Name = "_workSpaceContainer";
            this._workSpaceContainer.Size = new System.Drawing.Size(640, 561);
            this._workSpaceContainer.TabIndex = 2;
            // 
            // _tobBarContainer
            // 
            this._tobBarContainer.BackColor = System.Drawing.Color.White;
            this._tobBarContainer.Controls.Add(this._languageBtn);
            this._tobBarContainer.Controls.Add(this._fromTrayBtn);
            this._tobBarContainer.Controls.Add(this._fromMaximumBtn);
            this._tobBarContainer.Controls.Add(this._fromExitBtn);
            this._tobBarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this._tobBarContainer.Location = new System.Drawing.Point(0, 0);
            this._tobBarContainer.Name = "_tobBarContainer";
            this._tobBarContainer.Size = new System.Drawing.Size(640, 29);
            this._tobBarContainer.TabIndex = 1;
            this._tobBarContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            // 
            // _languageBtn
            // 
            this._languageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._languageBtn.FlatAppearance.BorderSize = 0;
            this._languageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._languageBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this._languageBtn.Location = new System.Drawing.Point(508, 0);
            this._languageBtn.Name = "_languageBtn";
            this._languageBtn.Size = new System.Drawing.Size(42, 29);
            this._languageBtn.TabIndex = 6;
            this._languageBtn.Text = "Eng";
            this._languageBtn.UseVisualStyleBackColor = true;
            // 
            // _fromTrayBtn
            // 
            this._fromTrayBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._fromTrayBtn.FlatAppearance.BorderSize = 0;
            this._fromTrayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._fromTrayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._fromTrayBtn.Location = new System.Drawing.Point(550, 0);
            this._fromTrayBtn.Name = "_fromTrayBtn";
            this._fromTrayBtn.Size = new System.Drawing.Size(30, 29);
            this._fromTrayBtn.TabIndex = 4;
            this._fromTrayBtn.Text = "__";
            this._fromTrayBtn.UseVisualStyleBackColor = true;
            this._fromTrayBtn.Click += new System.EventHandler(this.ClickFromTray);
            // 
            // _fromMaximumBtn
            // 
            this._fromMaximumBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._fromMaximumBtn.FlatAppearance.BorderSize = 0;
            this._fromMaximumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._fromMaximumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._fromMaximumBtn.ForeColor = System.Drawing.Color.Lime;
            this._fromMaximumBtn.Location = new System.Drawing.Point(580, 0);
            this._fromMaximumBtn.Name = "_fromMaximumBtn";
            this._fromMaximumBtn.Size = new System.Drawing.Size(30, 29);
            this._fromMaximumBtn.TabIndex = 3;
            this._fromMaximumBtn.Text = "◻";
            this._fromMaximumBtn.UseVisualStyleBackColor = true;
            this._fromMaximumBtn.Click += new System.EventHandler(this.ClickFromMaximum);
            // 
            // _fromExitBtn
            // 
            this._fromExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._fromExitBtn.FlatAppearance.BorderSize = 0;
            this._fromExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._fromExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._fromExitBtn.ForeColor = System.Drawing.Color.Red;
            this._fromExitBtn.Location = new System.Drawing.Point(610, 0);
            this._fromExitBtn.Name = "_fromExitBtn";
            this._fromExitBtn.Size = new System.Drawing.Size(30, 29);
            this._fromExitBtn.TabIndex = 5;
            this._fromExitBtn.Text = "❌";
            this._fromExitBtn.UseVisualStyleBackColor = true;
            this._fromExitBtn.Click += new System.EventHandler(this.ClickFromExit);
            // 
            // _formContainer
            // 
            this._formContainer.Controls.Add(this._bodyContainer);
            this._formContainer.Controls.Add(this._menuConteiner);
            this._formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formContainer.Location = new System.Drawing.Point(0, 0);
            this._formContainer.Name = "_formContainer";
            this._formContainer.Size = new System.Drawing.Size(790, 590);
            this._formContainer.TabIndex = 2;
            // 
            // _borderRight
            // 
            this._borderRight.BackColor = System.Drawing.Color.DarkGray;
            this._borderRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this._borderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._borderRight.Location = new System.Drawing.Point(790, 0);
            this._borderRight.Name = "_borderRight";
            this._borderRight.Size = new System.Drawing.Size(10, 590);
            this._borderRight.TabIndex = 2;
            this._borderRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseDown);
            this._borderRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseMove);
            this._borderRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseUp);
            // 
            // _borderDown
            // 
            this._borderDown.BackColor = System.Drawing.Color.DarkGray;
            this._borderDown.Controls.Add(this._borderAngle);
            this._borderDown.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this._borderDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._borderDown.Location = new System.Drawing.Point(0, 590);
            this._borderDown.Name = "_borderDown";
            this._borderDown.Size = new System.Drawing.Size(800, 10);
            this._borderDown.TabIndex = 3;
            this._borderDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseDown);
            this._borderDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseMove);
            this._borderDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseUp);
            // 
            // _borderAngle
            // 
            this._borderAngle.BackColor = System.Drawing.Color.DarkGray;
            this._borderAngle.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this._borderAngle.Dock = System.Windows.Forms.DockStyle.Right;
            this._borderAngle.Location = new System.Drawing.Point(790, 0);
            this._borderAngle.Name = "_borderAngle";
            this._borderAngle.Size = new System.Drawing.Size(10, 10);
            this._borderAngle.TabIndex = 4;
            this._borderAngle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseDown);
            this._borderAngle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseMove);
            this._borderAngle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizeFormMouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this._formContainer);
            this.Controls.Add(this._borderRight);
            this.Controls.Add(this._borderDown);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "WPLog";
            this._menuConteiner.ResumeLayout(false);
            this._bottomMenuContainer.ResumeLayout(false);
            this._logoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._logoImage)).EndInit();
            this._bodyContainer.ResumeLayout(false);
            this._tobBarContainer.ResumeLayout(false);
            this._formContainer.ResumeLayout(false);
            this._borderDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _menuConteiner;
        private System.Windows.Forms.Panel _bodyContainer;
        private System.Windows.Forms.Panel _bottomMenuContainer;
        private Bunifu.Framework.UI.BunifuFlatButton _settingsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton _monitorBtn;
        private Bunifu.Framework.UI.BunifuFlatButton _homeBtn;
        private System.Windows.Forms.Panel _logoContainer;
        private System.Windows.Forms.Panel _tobBarContainer;
        private System.Windows.Forms.PictureBox _logoImage;
        private System.Windows.Forms.Label _logoLabel;
        private System.Windows.Forms.Button _fromTrayBtn;
        private System.Windows.Forms.Button _fromMaximumBtn;
        private System.Windows.Forms.Button _fromExitBtn;
        private System.Windows.Forms.Label _versionLabel;
        private System.Windows.Forms.Panel _upperLogoContainer;
        private System.Windows.Forms.Panel _formContainer;
        private System.Windows.Forms.Panel _borderRight;
        private System.Windows.Forms.Panel _borderDown;
        private System.Windows.Forms.Panel _borderAngle;
        private Bunifu.Framework.UI.BunifuFlatButton _donateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton _aboutBtn;
        private System.Windows.Forms.Panel _workSpaceContainer;
        private System.Windows.Forms.Button _languageBtn;
    }
}