namespace MusicX
{
    partial class FrmMusicMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusicMain));
            this.BtnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSaveSongs = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProgressMax = new System.Windows.Forms.ProgressBar();
            this.LblVolumeCount = new System.Windows.Forms.Label();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNowPlaying = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnOpenFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPause = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProfileImage = new System.Windows.Forms.Label();
            this.LblProfile = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblUsernameLogin = new System.Windows.Forms.Label();
            this.LblPasswordLogin = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLoginUserPass = new System.Windows.Forms.Button();
            this.CBoxSavePassword = new System.Windows.Forms.CheckBox();
            this.LblTest = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPlay.BackColor = System.Drawing.Color.Black;
            this.BtnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlay.BackgroundImage")));
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlay.ForeColor = System.Drawing.Color.DarkSalmon;
            this.BtnPlay.Location = new System.Drawing.Point(583, 16);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(49, 50);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.BtnSaveSongs);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 585);
            this.panel1.TabIndex = 1;
            // 
            // BtnSaveSongs
            // 
            this.BtnSaveSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSaveSongs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSaveSongs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSaveSongs.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnSaveSongs.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnSaveSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveSongs.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.BtnSaveSongs.Location = new System.Drawing.Point(12, 443);
            this.BtnSaveSongs.Name = "BtnSaveSongs";
            this.BtnSaveSongs.Size = new System.Drawing.Size(223, 35);
            this.BtnSaveSongs.TabIndex = 1;
            this.BtnSaveSongs.Text = "Save Playlist";
            this.BtnSaveSongs.UseVisualStyleBackColor = false;
            this.BtnSaveSongs.Click += new System.EventHandler(this.BtnSaveSongs_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnSettings.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSettings.Location = new System.Drawing.Point(12, 141);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(223, 35);
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.BtnSettings.MouseLeave += new System.EventHandler(this.BtnSettings_MouseLeave);
            this.BtnSettings.MouseHover += new System.EventHandler(this.BtnSettings_MouseHover);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnLogin.Location = new System.Drawing.Point(12, 100);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(223, 35);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            this.BtnLogin.MouseHover += new System.EventHandler(this.BtnLogin_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUSIX";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ProgressMax);
            this.panel2.Controls.Add(this.LblVolumeCount);
            this.panel2.Controls.Add(this.BtnPrevious);
            this.panel2.Controls.Add(this.BtnNext);
            this.panel2.Controls.Add(this.VolumeTrackBar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LblNowPlaying);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.BtnOpenFiles);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnPause);
            this.panel2.Controls.Add(this.BtnPlay);
            this.panel2.Location = new System.Drawing.Point(-11, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 78);
            this.panel2.TabIndex = 2;
            // 
            // ProgressMax
            // 
            this.ProgressMax.ForeColor = System.Drawing.Color.Yellow;
            this.ProgressMax.Location = new System.Drawing.Point(788, 29);
            this.ProgressMax.Name = "ProgressMax";
            this.ProgressMax.Size = new System.Drawing.Size(125, 29);
            this.ProgressMax.TabIndex = 6;
            this.ProgressMax.Click += new System.EventHandler(this.ProgressMax_Click);
            // 
            // LblVolumeCount
            // 
            this.LblVolumeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblVolumeCount.AutoSize = true;
            this.LblVolumeCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblVolumeCount.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVolumeCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblVolumeCount.Location = new System.Drawing.Point(376, 29);
            this.LblVolumeCount.Name = "LblVolumeCount";
            this.LblVolumeCount.Size = new System.Drawing.Size(19, 23);
            this.LblVolumeCount.TabIndex = 0;
            this.LblVolumeCount.Text = "0";
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPrevious.BackColor = System.Drawing.Color.Black;
            this.BtnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.BackgroundImage")));
            this.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrevious.ForeColor = System.Drawing.Color.DarkSalmon;
            this.BtnPrevious.Location = new System.Drawing.Point(527, 16);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(50, 50);
            this.BtnPrevious.TabIndex = 0;
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNext.BackColor = System.Drawing.Color.Black;
            this.BtnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNext.BackgroundImage")));
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNext.ForeColor = System.Drawing.Color.DarkSalmon;
            this.BtnNext.Location = new System.Drawing.Point(639, 16);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(50, 50);
            this.BtnNext.TabIndex = 0;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VolumeTrackBar.LargeChange = 2;
            this.VolumeTrackBar.Location = new System.Drawing.Point(266, 16);
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(116, 56);
            this.VolumeTrackBar.TabIndex = 5;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeTrackBar.Value = 5;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(966, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Playing:";
            // 
            // LblNowPlaying
            // 
            this.LblNowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNowPlaying.AutoSize = true;
            this.LblNowPlaying.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblNowPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblNowPlaying.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNowPlaying.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblNowPlaying.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.LblNowPlaying.Location = new System.Drawing.Point(948, 30);
            this.LblNowPlaying.Name = "LblNowPlaying";
            this.LblNowPlaying.Size = new System.Drawing.Size(257, 23);
            this.LblNowPlaying.TabIndex = 0;
            this.LblNowPlaying.Text = "Click Local Files to Get Started";
            this.LblNowPlaying.Click += new System.EventHandler(this.LblNowPlaying_Click);
            this.LblNowPlaying.MouseHover += new System.EventHandler(this.LblNowPlaying_MouseHover);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(272, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(701, 6);
            this.progressBar1.TabIndex = 4;
            // 
            // BtnOpenFiles
            // 
            this.BtnOpenFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnOpenFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnOpenFiles.BackColor = System.Drawing.Color.Black;
            this.BtnOpenFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOpenFiles.BackgroundImage")));
            this.BtnOpenFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnOpenFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOpenFiles.ForeColor = System.Drawing.Color.DarkSalmon;
            this.BtnOpenFiles.Location = new System.Drawing.Point(55, 16);
            this.BtnOpenFiles.Name = "BtnOpenFiles";
            this.BtnOpenFiles.Size = new System.Drawing.Size(49, 50);
            this.BtnOpenFiles.TabIndex = 0;
            this.BtnOpenFiles.UseVisualStyleBackColor = false;
            this.BtnOpenFiles.Click += new System.EventHandler(this.BtnOpenFiles_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(109, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local Files";
            // 
            // BtnPause
            // 
            this.BtnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPause.BackColor = System.Drawing.Color.Black;
            this.BtnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPause.BackgroundImage")));
            this.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPause.ForeColor = System.Drawing.Color.DarkSalmon;
            this.BtnPause.Location = new System.Drawing.Point(583, 16);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(50, 50);
            this.BtnPause.TabIndex = 0;
            this.BtnPause.UseVisualStyleBackColor = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(55, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.BackColor = System.Drawing.Color.Black;
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 28;
            this.ListBox.Location = new System.Drawing.Point(262, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.ScrollAlwaysVisible = true;
            this.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox.Size = new System.Drawing.Size(677, 448);
            this.ListBox.TabIndex = 3;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ProfileImage);
            this.panel3.Controls.Add(this.LblProfile);
            this.panel3.Location = new System.Drawing.Point(944, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 508);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(14, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 142);
            this.label5.TabIndex = 0;
            this.label5.Text = "To get started, click Local Files icon on the bottom right hand side.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(14, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Info";
            // 
            // ProfileImage
            // 
            this.ProfileImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfileImage.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProfileImage.ForeColor = System.Drawing.Color.Yellow;
            this.ProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImage.Image")));
            this.ProfileImage.Location = new System.Drawing.Point(39, 19);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.Size = new System.Drawing.Size(44, 36);
            this.ProfileImage.TabIndex = 0;
            // 
            // LblProfile
            // 
            this.LblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProfile.AutoEllipsis = true;
            this.LblProfile.AutoSize = true;
            this.LblProfile.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProfile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblProfile.Location = new System.Drawing.Point(89, 23);
            this.LblProfile.Margin = new System.Windows.Forms.Padding(3, 0, 9, 0);
            this.LblProfile.Name = "LblProfile";
            this.LblProfile.Size = new System.Drawing.Size(58, 28);
            this.LblProfile.TabIndex = 0;
            this.LblProfile.Text = "User";
            this.LblProfile.Click += new System.EventHandler(this.LblProfile_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsername.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUsername.Location = new System.Drawing.Point(502, 92);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(198, 31);
            this.TxtUsername.TabIndex = 4;
            // 
            // LblUsernameLogin
            // 
            this.LblUsernameLogin.AutoSize = true;
            this.LblUsernameLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUsernameLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblUsernameLogin.Location = new System.Drawing.Point(357, 90);
            this.LblUsernameLogin.Name = "LblUsernameLogin";
            this.LblUsernameLogin.Size = new System.Drawing.Size(102, 26);
            this.LblUsernameLogin.TabIndex = 0;
            this.LblUsernameLogin.Text = "Username";
            // 
            // LblPasswordLogin
            // 
            this.LblPasswordLogin.AutoSize = true;
            this.LblPasswordLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPasswordLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPasswordLogin.Location = new System.Drawing.Point(357, 150);
            this.LblPasswordLogin.Name = "LblPasswordLogin";
            this.LblPasswordLogin.Size = new System.Drawing.Size(94, 26);
            this.LblPasswordLogin.TabIndex = 0;
            this.LblPasswordLogin.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(502, 152);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(198, 31);
            this.TxtPassword.TabIndex = 4;
            // 
            // BtnLoginUserPass
            // 
            this.BtnLoginUserPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoginUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.BtnLoginUserPass.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnLoginUserPass.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnLoginUserPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLoginUserPass.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLoginUserPass.ForeColor = System.Drawing.Color.Black;
            this.BtnLoginUserPass.Location = new System.Drawing.Point(573, 228);
            this.BtnLoginUserPass.Name = "BtnLoginUserPass";
            this.BtnLoginUserPass.Size = new System.Drawing.Size(127, 42);
            this.BtnLoginUserPass.TabIndex = 1;
            this.BtnLoginUserPass.Text = "Login";
            this.BtnLoginUserPass.UseVisualStyleBackColor = false;
            this.BtnLoginUserPass.Click += new System.EventHandler(this.BtnLoginUserPass_Click);
            // 
            // CBoxSavePassword
            // 
            this.CBoxSavePassword.AutoSize = true;
            this.CBoxSavePassword.BackColor = System.Drawing.Color.Transparent;
            this.CBoxSavePassword.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBoxSavePassword.ForeColor = System.Drawing.Color.Yellow;
            this.CBoxSavePassword.Location = new System.Drawing.Point(357, 240);
            this.CBoxSavePassword.Name = "CBoxSavePassword";
            this.CBoxSavePassword.Size = new System.Drawing.Size(127, 24);
            this.CBoxSavePassword.TabIndex = 5;
            this.CBoxSavePassword.Text = "Remember Me";
            this.CBoxSavePassword.UseVisualStyleBackColor = false;
            this.CBoxSavePassword.CheckedChanged += new System.EventHandler(this.CBoxSavePassword_CheckedChanged);
            // 
            // LblTest
            // 
            this.LblTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTest.AutoSize = true;
            this.LblTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTest.Location = new System.Drawing.Point(262, 463);
            this.LblTest.Name = "LblTest";
            this.LblTest.Size = new System.Drawing.Size(0, 20);
            this.LblTest.TabIndex = 6;
            // 
            // FrmMusicMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1207, 586);
            this.Controls.Add(this.LblTest);
            this.Controls.Add(this.CBoxSavePassword);
            this.Controls.Add(this.BtnLoginUserPass);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPasswordLogin);
            this.Controls.Add(this.LblUsernameLogin);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMusicMain";
            this.Text = "MusicX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMusicMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMusicMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOpenFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnSaveSongs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ProfileImage;
        private System.Windows.Forms.Label LblProfile;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblUsernameLogin;
        private System.Windows.Forms.Label LblPasswordLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLoginUserPass;
        private System.Windows.Forms.CheckBox CBoxSavePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNowPlaying;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Label LblTest;
        private System.Windows.Forms.Label LblVolumeCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar ProgressMax;
    }
}

