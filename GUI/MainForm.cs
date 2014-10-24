using PowerCraft.Network;
using PowerCraft.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtConsoleBox_TextChanged(object sender, KeyEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Writer startWrite = new Writer("Running your server on " + Updater.VersionString());
            startWrite.WriteToConsole(LogType.Normal);
            Writer startWrite2 = new Writer("Loaded Configuration!");
            startWrite2.WriteToConsole(LogType.Normal);
            PowerCraft.Config.Load();
            Heartbeat.Start();
        }
        int lineCount = 0;
        private void UpdaterTimer_Tick(object sender, EventArgs e)
        {
            if (lineCount < WriterAdapter.lineCount)
            {
                rtbLogBox.AppendText(WriterAdapter.MostRecentLine);
                lineCount++;
            }
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if (!txtConsoleBox.Text.Substring(0, 1).Equals("/"))
            {
                Writer w = new Writer(txtConsoleBox.Text);
                w.WriteToConsole(LogType.Normal);
            }
            txtConsoleBox.Text = String.Empty;
        }
    }
}
