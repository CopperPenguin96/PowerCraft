﻿namespace ConfigGUI
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
            this.tabRanks = new System.Windows.Forms.TabPage();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.tabWorlds = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ConfigTabs.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gboIRC.SuspendLayout();
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
            this.ConfigTabs.Size = new System.Drawing.Size(550, 175);
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
            this.tabGeneral.Size = new System.Drawing.Size(542, 149);
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
            this.tabCPE.Location = new System.Drawing.Point(4, 22);
            this.tabCPE.Name = "tabCPE";
            this.tabCPE.Padding = new System.Windows.Forms.Padding(3);
            this.tabCPE.Size = new System.Drawing.Size(542, 149);
            this.tabCPE.TabIndex = 1;
            this.tabCPE.Text = "CPE";
            this.tabCPE.UseVisualStyleBackColor = true;
            // 
            // tabRanks
            // 
            this.tabRanks.Location = new System.Drawing.Point(4, 22);
            this.tabRanks.Name = "tabRanks";
            this.tabRanks.Padding = new System.Windows.Forms.Padding(3);
            this.tabRanks.Size = new System.Drawing.Size(542, 149);
            this.tabRanks.TabIndex = 2;
            this.tabRanks.Text = "Ranks";
            this.tabRanks.UseVisualStyleBackColor = true;
            // 
            // tabChat
            // 
            this.tabChat.Location = new System.Drawing.Point(4, 22);
            this.tabChat.Name = "tabChat";
            this.tabChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabChat.Size = new System.Drawing.Size(542, 149);
            this.tabChat.TabIndex = 3;
            this.tabChat.Text = "Chat";
            this.tabChat.UseVisualStyleBackColor = true;
            // 
            // tabWorlds
            // 
            this.tabWorlds.Location = new System.Drawing.Point(4, 22);
            this.tabWorlds.Name = "tabWorlds";
            this.tabWorlds.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorlds.Size = new System.Drawing.Size(542, 149);
            this.tabWorlds.TabIndex = 4;
            this.tabWorlds.Text = "Worlds";
            this.tabWorlds.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(351, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 34);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 303);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ConfigTabs);
            this.Controls.Add(this.lblConfigHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(605, 342);
            this.MinimumSize = new System.Drawing.Size(605, 342);
            this.Name = "MainForm";
            this.Text = "PowerCraft Config";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ConfigTabs.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.gboIRC.ResumeLayout(false);
            this.gboIRC.PerformLayout();
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
    }
}