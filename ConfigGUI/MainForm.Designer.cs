namespace ConfigGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblConfigHeader = new System.Windows.Forms.Label();
            this.ConfigTabs = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.cboMainWorld = new System.Windows.Forms.ComboBox();
            this.lblMainWorld = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.cboDefaultRank = new System.Windows.Forms.ComboBox();
            this.lblDefaultRank = new System.Windows.Forms.Label();
            this.txtMOTD = new System.Windows.Forms.TextBox();
            this.lblMotd = new System.Windows.Forms.Label();
            this.gboIRC = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.txtIRCNetwork = new System.Windows.Forms.TextBox();
            this.lblNetwork = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.tabCPE = new System.Windows.Forms.TabPage();
            this.lblComingSoonCPE = new System.Windows.Forms.Label();
            this.tabRanks = new System.Windows.Forms.TabPage();
            this.btnDeleteRank = new System.Windows.Forms.Button();
            this.btnAddRank = new System.Windows.Forms.Button();
            this.listOfRanks = new System.Windows.Forms.ListBox();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabWorlds = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.vPermissions = new System.Windows.Forms.ListView();
            this.chPermissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lPermissions = new System.Windows.Forms.Label();
            this.gRankOptions = new System.Windows.Forms.GroupBox();
            this.lAntiGrief1 = new System.Windows.Forms.Label();
            this.lAntiGrief3 = new System.Windows.Forms.Label();
            this.nAntiGriefSeconds = new System.Windows.Forms.NumericUpDown();
            this.bColorRank = new System.Windows.Forms.Button();
            this.xDrawLimit = new System.Windows.Forms.CheckBox();
            this.lDrawLimitUnits = new System.Windows.Forms.Label();
            this.lKickIdleUnits = new System.Windows.Forms.Label();
            this.nDrawLimit = new System.Windows.Forms.NumericUpDown();
            this.nKickIdle = new System.Windows.Forms.NumericUpDown();
            this.xAntiGrief = new System.Windows.Forms.CheckBox();
            this.lAntiGrief2 = new System.Windows.Forms.Label();
            this.xKickIdle = new System.Windows.Forms.CheckBox();
            this.nAntiGriefBlocks = new System.Windows.Forms.NumericUpDown();
            this.xReserveSlot = new System.Windows.Forms.CheckBox();
            this.lRankColor = new System.Windows.Forms.Label();
            this.tRankName = new System.Windows.Forms.TextBox();
            this.lRankName = new System.Windows.Forms.Label();
            this.ConfigTabs.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gboIRC.SuspendLayout();
            this.tabCPE.SuspendLayout();
            this.tabRanks.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.tabWorlds.SuspendLayout();
            this.gRankOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKickIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefBlocks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfigHeader
            // 
            this.lblConfigHeader.AutoSize = true;
            this.lblConfigHeader.Font = new System.Drawing.Font("Grudge BRK", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigHeader.Location = new System.Drawing.Point(14, 13);
            this.lblConfigHeader.Name = "lblConfigHeader";
            this.lblConfigHeader.Size = new System.Drawing.Size(561, 64);
            this.lblConfigHeader.TabIndex = 0;
            this.lblConfigHeader.Text = "Configuration";
            // 
            // ConfigTabs
            // 
            this.ConfigTabs.Controls.Add(this.tabGeneral);
            this.ConfigTabs.Controls.Add(this.tabCPE);
            this.ConfigTabs.Controls.Add(this.tabRanks);
            this.ConfigTabs.Controls.Add(this.tabChat);
            this.ConfigTabs.Controls.Add(this.tabWorlds);
            this.ConfigTabs.Location = new System.Drawing.Point(25, 81);
            this.ConfigTabs.Name = "ConfigTabs";
            this.ConfigTabs.SelectedIndex = 0;
            this.ConfigTabs.Size = new System.Drawing.Size(655, 350);
            this.ConfigTabs.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cboMainWorld);
            this.tabGeneral.Controls.Add(this.lblMainWorld);
            this.tabGeneral.Controls.Add(this.txtPort);
            this.tabGeneral.Controls.Add(this.lblPort);
            this.tabGeneral.Controls.Add(this.cboDefaultRank);
            this.tabGeneral.Controls.Add(this.lblDefaultRank);
            this.tabGeneral.Controls.Add(this.txtMOTD);
            this.tabGeneral.Controls.Add(this.lblMotd);
            this.tabGeneral.Controls.Add(this.gboIRC);
            this.tabGeneral.Controls.Add(this.txtServerName);
            this.tabGeneral.Controls.Add(this.lblServerName);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(542, 208);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // cboMainWorld
            // 
            this.cboMainWorld.Enabled = false;
            this.cboMainWorld.FormattingEnabled = true;
            this.cboMainWorld.Location = new System.Drawing.Point(87, 113);
            this.cboMainWorld.Name = "cboMainWorld";
            this.cboMainWorld.Size = new System.Drawing.Size(226, 21);
            this.cboMainWorld.TabIndex = 11;
            // 
            // lblMainWorld
            // 
            this.lblMainWorld.AutoSize = true;
            this.lblMainWorld.Location = new System.Drawing.Point(7, 116);
            this.lblMainWorld.Name = "lblMainWorld";
            this.lblMainWorld.Size = new System.Drawing.Size(64, 13);
            this.lblMainWorld.TabIndex = 10;
            this.lblMainWorld.Text = "Main World:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(87, 87);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(226, 20);
            this.txtPort.TabIndex = 9;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(7, 87);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 13);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port: ";
            // 
            // cboDefaultRank
            // 
            this.cboDefaultRank.Enabled = false;
            this.cboDefaultRank.FormattingEnabled = true;
            this.cboDefaultRank.Location = new System.Drawing.Point(86, 59);
            this.cboDefaultRank.Name = "cboDefaultRank";
            this.cboDefaultRank.Size = new System.Drawing.Size(227, 21);
            this.cboDefaultRank.TabIndex = 6;
            // 
            // lblDefaultRank
            // 
            this.lblDefaultRank.AutoSize = true;
            this.lblDefaultRank.Location = new System.Drawing.Point(7, 59);
            this.lblDefaultRank.Name = "lblDefaultRank";
            this.lblDefaultRank.Size = new System.Drawing.Size(73, 13);
            this.lblDefaultRank.TabIndex = 5;
            this.lblDefaultRank.Text = "Default Rank:";
            // 
            // txtMOTD
            // 
            this.txtMOTD.Enabled = false;
            this.txtMOTD.Location = new System.Drawing.Point(86, 33);
            this.txtMOTD.Name = "txtMOTD";
            this.txtMOTD.Size = new System.Drawing.Size(227, 20);
            this.txtMOTD.TabIndex = 4;
            // 
            // lblMotd
            // 
            this.lblMotd.AutoSize = true;
            this.lblMotd.Location = new System.Drawing.Point(7, 33);
            this.lblMotd.Name = "lblMotd";
            this.lblMotd.Size = new System.Drawing.Size(45, 13);
            this.lblMotd.TabIndex = 3;
            this.lblMotd.Text = "MOTD: ";
            // 
            // gboIRC
            // 
            this.gboIRC.Controls.Add(this.txtPass);
            this.gboIRC.Controls.Add(this.lblPass);
            this.gboIRC.Controls.Add(this.txtUsername);
            this.gboIRC.Controls.Add(this.lblUser);
            this.gboIRC.Controls.Add(this.txtChannel);
            this.gboIRC.Controls.Add(this.lblChannel);
            this.gboIRC.Controls.Add(this.txtIRCNetwork);
            this.gboIRC.Controls.Add(this.lblNetwork);
            this.gboIRC.Enabled = false;
            this.gboIRC.Location = new System.Drawing.Point(320, 7);
            this.gboIRC.Name = "gboIRC";
            this.gboIRC.Size = new System.Drawing.Size(216, 127);
            this.gboIRC.TabIndex = 2;
            this.gboIRC.TabStop = false;
            this.gboIRC.Text = "IRC";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(62, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(148, 20);
            this.txtPass.TabIndex = 16;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 97);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(33, 13);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Pass:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(62, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 20);
            this.txtUsername.TabIndex = 14;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 71);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "User:";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(62, 45);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(148, 20);
            this.txtChannel.TabIndex = 12;
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(6, 45);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(49, 13);
            this.lblChannel.TabIndex = 11;
            this.lblChannel.Text = "Channel:";
            // 
            // txtIRCNetwork
            // 
            this.txtIRCNetwork.Location = new System.Drawing.Point(62, 21);
            this.txtIRCNetwork.Name = "txtIRCNetwork";
            this.txtIRCNetwork.Size = new System.Drawing.Size(148, 20);
            this.txtIRCNetwork.TabIndex = 10;
            // 
            // lblNetwork
            // 
            this.lblNetwork.AutoSize = true;
            this.lblNetwork.Location = new System.Drawing.Point(6, 21);
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(50, 13);
            this.lblNetwork.TabIndex = 9;
            this.lblNetwork.Text = "Network:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(86, 7);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(227, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(7, 7);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(72, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name:";
            // 
            // tabCPE
            // 
            this.tabCPE.Controls.Add(this.lblComingSoonCPE);
            this.tabCPE.Location = new System.Drawing.Point(4, 22);
            this.tabCPE.Name = "tabCPE";
            this.tabCPE.Padding = new System.Windows.Forms.Padding(3);
            this.tabCPE.Size = new System.Drawing.Size(542, 208);
            this.tabCPE.TabIndex = 1;
            this.tabCPE.Text = "CPE";
            this.tabCPE.UseVisualStyleBackColor = true;
            // 
            // lblComingSoonCPE
            // 
            this.lblComingSoonCPE.AutoSize = true;
            this.lblComingSoonCPE.Font = new System.Drawing.Font("Grudge BRK", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoonCPE.Location = new System.Drawing.Point(135, 56);
            this.lblComingSoonCPE.Name = "lblComingSoonCPE";
            this.lblComingSoonCPE.Size = new System.Drawing.Size(273, 36);
            this.lblComingSoonCPE.TabIndex = 0;
            this.lblComingSoonCPE.Text = "Coming Soon!";
            // 
            // tabRanks
            // 
            this.tabRanks.Controls.Add(this.gRankOptions);
            this.tabRanks.Controls.Add(this.vPermissions);
            this.tabRanks.Controls.Add(this.lPermissions);
            this.tabRanks.Controls.Add(this.btnDeleteRank);
            this.tabRanks.Controls.Add(this.btnAddRank);
            this.tabRanks.Controls.Add(this.listOfRanks);
            this.tabRanks.Location = new System.Drawing.Point(4, 22);
            this.tabRanks.Name = "tabRanks";
            this.tabRanks.Padding = new System.Windows.Forms.Padding(3);
            this.tabRanks.Size = new System.Drawing.Size(647, 324);
            this.tabRanks.TabIndex = 2;
            this.tabRanks.Text = "Ranks";
            this.tabRanks.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRank
            // 
            this.btnDeleteRank.Location = new System.Drawing.Point(7, 286);
            this.btnDeleteRank.Name = "btnDeleteRank";
            this.btnDeleteRank.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteRank.TabIndex = 2;
            this.btnDeleteRank.Text = "Delete";
            this.btnDeleteRank.UseVisualStyleBackColor = true;
            this.btnDeleteRank.Click += new System.EventHandler(this.btnDeleteRank_Click);
            // 
            // btnAddRank
            // 
            this.btnAddRank.Location = new System.Drawing.Point(7, 257);
            this.btnAddRank.Name = "btnAddRank";
            this.btnAddRank.Size = new System.Drawing.Size(120, 23);
            this.btnAddRank.TabIndex = 1;
            this.btnAddRank.Text = "Add";
            this.btnAddRank.UseVisualStyleBackColor = true;
            this.btnAddRank.Click += new System.EventHandler(this.btnAddRank_Click);
            // 
            // listOfRanks
            // 
            this.listOfRanks.FormattingEnabled = true;
            this.listOfRanks.Location = new System.Drawing.Point(7, 7);
            this.listOfRanks.Name = "listOfRanks";
            this.listOfRanks.Size = new System.Drawing.Size(120, 238);
            this.listOfRanks.TabIndex = 0;
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.label1);
            this.tabChat.Location = new System.Drawing.Point(4, 22);
            this.tabChat.Name = "tabChat";
            this.tabChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabChat.Size = new System.Drawing.Size(542, 208);
            this.tabChat.TabIndex = 3;
            this.tabChat.Text = "Chat";
            this.tabChat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Grudge BRK", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coming Soon!";
            // 
            // tabWorlds
            // 
            this.tabWorlds.Controls.Add(this.label2);
            this.tabWorlds.Location = new System.Drawing.Point(4, 22);
            this.tabWorlds.Name = "tabWorlds";
            this.tabWorlds.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorlds.Size = new System.Drawing.Size(542, 208);
            this.tabWorlds.TabIndex = 4;
            this.tabWorlds.Text = "Worlds";
            this.tabWorlds.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Grudge BRK", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coming Soon!";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(571, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(456, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 34);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // vPermissions
            // 
            this.vPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vPermissions.CheckBoxes = true;
            this.vPermissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPermissions});
            this.vPermissions.GridLines = true;
            this.vPermissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vPermissions.Location = new System.Drawing.Point(470, 23);
            this.vPermissions.MultiSelect = false;
            this.vPermissions.Name = "vPermissions";
            this.vPermissions.ShowGroups = false;
            this.vPermissions.ShowItemToolTips = true;
            this.vPermissions.Size = new System.Drawing.Size(171, 295);
            this.vPermissions.TabIndex = 11;
            this.vPermissions.UseCompatibleStateImageBehavior = false;
            this.vPermissions.View = System.Windows.Forms.View.Details;
            // 
            // chPermissions
            // 
            this.chPermissions.Width = 150;
            // 
            // lPermissions
            // 
            this.lPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPermissions.AutoSize = true;
            this.lPermissions.Location = new System.Drawing.Point(550, 7);
            this.lPermissions.Name = "lPermissions";
            this.lPermissions.Size = new System.Drawing.Size(91, 13);
            this.lPermissions.TabIndex = 10;
            this.lPermissions.Text = "Rank Permissions";
            // 
            // gRankOptions
            // 
            this.gRankOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gRankOptions.Controls.Add(this.lAntiGrief1);
            this.gRankOptions.Controls.Add(this.lAntiGrief3);
            this.gRankOptions.Controls.Add(this.nAntiGriefSeconds);
            this.gRankOptions.Controls.Add(this.bColorRank);
            this.gRankOptions.Controls.Add(this.xDrawLimit);
            this.gRankOptions.Controls.Add(this.lDrawLimitUnits);
            this.gRankOptions.Controls.Add(this.lKickIdleUnits);
            this.gRankOptions.Controls.Add(this.nDrawLimit);
            this.gRankOptions.Controls.Add(this.nKickIdle);
            this.gRankOptions.Controls.Add(this.xAntiGrief);
            this.gRankOptions.Controls.Add(this.lAntiGrief2);
            this.gRankOptions.Controls.Add(this.xKickIdle);
            this.gRankOptions.Controls.Add(this.nAntiGriefBlocks);
            this.gRankOptions.Controls.Add(this.xReserveSlot);
            this.gRankOptions.Controls.Add(this.lRankColor);
            this.gRankOptions.Controls.Add(this.tRankName);
            this.gRankOptions.Controls.Add(this.lRankName);
            this.gRankOptions.Location = new System.Drawing.Point(146, 7);
            this.gRankOptions.Name = "gRankOptions";
            this.gRankOptions.Size = new System.Drawing.Size(307, 238);
            this.gRankOptions.TabIndex = 12;
            this.gRankOptions.TabStop = false;
            this.gRankOptions.Text = "Rank Options";
            // 
            // lAntiGrief1
            // 
            this.lAntiGrief1.AutoSize = true;
            this.lAntiGrief1.Location = new System.Drawing.Point(50, 135);
            this.lAntiGrief1.Name = "lAntiGrief1";
            this.lAntiGrief1.Size = new System.Drawing.Size(43, 13);
            this.lAntiGrief1.TabIndex = 11;
            this.lAntiGrief1.Text = "Kick on";
            // 
            // lAntiGrief3
            // 
            this.lAntiGrief3.AutoSize = true;
            this.lAntiGrief3.Location = new System.Drawing.Point(275, 135);
            this.lAntiGrief3.Name = "lAntiGrief3";
            this.lAntiGrief3.Size = new System.Drawing.Size(24, 13);
            this.lAntiGrief3.TabIndex = 15;
            this.lAntiGrief3.Text = "sec";
            // 
            // nAntiGriefSeconds
            // 
            this.nAntiGriefSeconds.Location = new System.Drawing.Point(229, 133);
            this.nAntiGriefSeconds.Name = "nAntiGriefSeconds";
            this.nAntiGriefSeconds.Size = new System.Drawing.Size(40, 20);
            this.nAntiGriefSeconds.TabIndex = 14;
            // 
            // bColorRank
            // 
            this.bColorRank.BackColor = System.Drawing.Color.White;
            this.bColorRank.Location = new System.Drawing.Point(201, 47);
            this.bColorRank.Name = "bColorRank";
            this.bColorRank.Size = new System.Drawing.Size(100, 24);
            this.bColorRank.TabIndex = 6;
            this.bColorRank.UseVisualStyleBackColor = false;
            // 
            // xDrawLimit
            // 
            this.xDrawLimit.AutoSize = true;
            this.xDrawLimit.Location = new System.Drawing.Point(8, 160);
            this.xDrawLimit.Name = "xDrawLimit";
            this.xDrawLimit.Size = new System.Drawing.Size(71, 17);
            this.xDrawLimit.TabIndex = 17;
            this.xDrawLimit.Text = "Draw limit";
            this.xDrawLimit.UseVisualStyleBackColor = true;
            // 
            // lDrawLimitUnits
            // 
            this.lDrawLimitUnits.AutoSize = true;
            this.lDrawLimitUnits.Location = new System.Drawing.Point(168, 161);
            this.lDrawLimitUnits.Name = "lDrawLimitUnits";
            this.lDrawLimitUnits.Size = new System.Drawing.Size(38, 13);
            this.lDrawLimitUnits.TabIndex = 19;
            this.lDrawLimitUnits.Text = "blocks";
            // 
            // lKickIdleUnits
            // 
            this.lKickIdleUnits.AutoSize = true;
            this.lKickIdleUnits.Location = new System.Drawing.Point(181, 79);
            this.lKickIdleUnits.Name = "lKickIdleUnits";
            this.lKickIdleUnits.Size = new System.Drawing.Size(43, 13);
            this.lKickIdleUnits.TabIndex = 9;
            this.lKickIdleUnits.Text = "minutes";
            // 
            // nDrawLimit
            // 
            this.nDrawLimit.Increment = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nDrawLimit.Location = new System.Drawing.Point(95, 159);
            this.nDrawLimit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nDrawLimit.Name = "nDrawLimit";
            this.nDrawLimit.Size = new System.Drawing.Size(67, 20);
            this.nDrawLimit.TabIndex = 18;
            // 
            // nKickIdle
            // 
            this.nKickIdle.Location = new System.Drawing.Point(116, 77);
            this.nKickIdle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nKickIdle.Name = "nKickIdle";
            this.nKickIdle.Size = new System.Drawing.Size(59, 20);
            this.nKickIdle.TabIndex = 8;
            // 
            // xAntiGrief
            // 
            this.xAntiGrief.AutoSize = true;
            this.xAntiGrief.Location = new System.Drawing.Point(12, 108);
            this.xAntiGrief.Name = "xAntiGrief";
            this.xAntiGrief.Size = new System.Drawing.Size(192, 17);
            this.xAntiGrief.TabIndex = 10;
            this.xAntiGrief.Text = "Enable grief / autoclicker detection";
            this.xAntiGrief.UseVisualStyleBackColor = true;
            // 
            // lAntiGrief2
            // 
            this.lAntiGrief2.AutoSize = true;
            this.lAntiGrief2.Location = new System.Drawing.Point(168, 135);
            this.lAntiGrief2.Name = "lAntiGrief2";
            this.lAntiGrief2.Size = new System.Drawing.Size(49, 13);
            this.lAntiGrief2.TabIndex = 13;
            this.lAntiGrief2.Text = "blocks in";
            // 
            // xKickIdle
            // 
            this.xKickIdle.AutoSize = true;
            this.xKickIdle.Location = new System.Drawing.Point(12, 78);
            this.xKickIdle.Name = "xKickIdle";
            this.xKickIdle.Size = new System.Drawing.Size(89, 17);
            this.xKickIdle.TabIndex = 7;
            this.xKickIdle.Text = "Kick if idle for";
            this.xKickIdle.UseVisualStyleBackColor = true;
            // 
            // nAntiGriefBlocks
            // 
            this.nAntiGriefBlocks.Location = new System.Drawing.Point(103, 133);
            this.nAntiGriefBlocks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nAntiGriefBlocks.Name = "nAntiGriefBlocks";
            this.nAntiGriefBlocks.Size = new System.Drawing.Size(59, 20);
            this.nAntiGriefBlocks.TabIndex = 12;
            // 
            // xReserveSlot
            // 
            this.xReserveSlot.AutoSize = true;
            this.xReserveSlot.Location = new System.Drawing.Point(12, 51);
            this.xReserveSlot.Name = "xReserveSlot";
            this.xReserveSlot.Size = new System.Drawing.Size(116, 17);
            this.xReserveSlot.TabIndex = 4;
            this.xReserveSlot.Text = "Reserve player slot";
            this.xReserveSlot.UseVisualStyleBackColor = true;
            // 
            // lRankColor
            // 
            this.lRankColor.AutoSize = true;
            this.lRankColor.Location = new System.Drawing.Point(159, 52);
            this.lRankColor.Name = "lRankColor";
            this.lRankColor.Size = new System.Drawing.Size(31, 13);
            this.lRankColor.TabIndex = 5;
            this.lRankColor.Text = "Color";
            // 
            // tRankName
            // 
            this.tRankName.Location = new System.Drawing.Point(62, 20);
            this.tRankName.MaxLength = 16;
            this.tRankName.Name = "tRankName";
            this.tRankName.Size = new System.Drawing.Size(143, 20);
            this.tRankName.TabIndex = 1;
            // 
            // lRankName
            // 
            this.lRankName.AutoSize = true;
            this.lRankName.Location = new System.Drawing.Point(15, 23);
            this.lRankName.Name = "lRankName";
            this.lRankName.Size = new System.Drawing.Size(35, 13);
            this.lRankName.TabIndex = 0;
            this.lRankName.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 483);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ConfigTabs);
            this.Controls.Add(this.lblConfigHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(605, 342);
            this.Name = "MainForm";
            this.Text = "PowerCraft Config";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ConfigTabs.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.gboIRC.ResumeLayout(false);
            this.gboIRC.PerformLayout();
            this.tabCPE.ResumeLayout(false);
            this.tabCPE.PerformLayout();
            this.tabRanks.ResumeLayout(false);
            this.tabRanks.PerformLayout();
            this.tabChat.ResumeLayout(false);
            this.tabChat.PerformLayout();
            this.tabWorlds.ResumeLayout(false);
            this.tabWorlds.PerformLayout();
            this.gRankOptions.ResumeLayout(false);
            this.gRankOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKickIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefBlocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfigHeader;
        private System.Windows.Forms.TabControl ConfigTabs;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabCPE;
        private System.Windows.Forms.TabPage tabRanks;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TabPage tabWorlds;
        private System.Windows.Forms.GroupBox gboIRC;
        private System.Windows.Forms.TextBox txtMOTD;
        private System.Windows.Forms.Label lblMotd;
        private System.Windows.Forms.ComboBox cboDefaultRank;
        private System.Windows.Forms.Label lblDefaultRank;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ComboBox cboMainWorld;
        private System.Windows.Forms.Label lblMainWorld;
        private System.Windows.Forms.TextBox txtIRCNetwork;
        private System.Windows.Forms.Label lblNetwork;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listOfRanks;
        private System.Windows.Forms.Button btnDeleteRank;
        private System.Windows.Forms.Button btnAddRank;
        private System.Windows.Forms.Label lblComingSoonCPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gRankOptions;
        private System.Windows.Forms.Label lAntiGrief1;
        private System.Windows.Forms.Label lAntiGrief3;
        private System.Windows.Forms.NumericUpDown nAntiGriefSeconds;
        private System.Windows.Forms.Button bColorRank;
        private System.Windows.Forms.CheckBox xDrawLimit;
        private System.Windows.Forms.Label lDrawLimitUnits;
        private System.Windows.Forms.Label lKickIdleUnits;
        private System.Windows.Forms.NumericUpDown nDrawLimit;
        private System.Windows.Forms.NumericUpDown nKickIdle;
        private System.Windows.Forms.CheckBox xAntiGrief;
        private System.Windows.Forms.Label lAntiGrief2;
        private System.Windows.Forms.CheckBox xKickIdle;
        private System.Windows.Forms.NumericUpDown nAntiGriefBlocks;
        private System.Windows.Forms.CheckBox xReserveSlot;
        private System.Windows.Forms.Label lRankColor;
        private System.Windows.Forms.TextBox tRankName;
        private System.Windows.Forms.Label lRankName;
        private System.Windows.Forms.ListView vPermissions;
        private System.Windows.Forms.ColumnHeader chPermissions;
        private System.Windows.Forms.Label lPermissions;
    }
}