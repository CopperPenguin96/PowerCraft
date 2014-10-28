using PowerLib.PowerCraft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConfigGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        void Save()
        {
            Config.SetServerName(txtServerName.Text);
            Config.SetPrivacy(true);
            Config.SetPort(Convert.ToInt32(txtPort.Text));
            Config.SetMaxPlayers(20);
            Config.SetHeartBeatLocation(PowerLib.PowerCraft.Network.HeartbeatLocation.ClassiCube);
            Config.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Config.Load();
                txtServerName.Text = Config.GetServerName();
                txtPort.Text = "" + Config.GetPort();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
