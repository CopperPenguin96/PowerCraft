using PowerLib.PlayerDB;
using PowerLib.PowerCraft;
using System;
using System.Drawing;
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
            //Config.SetDefaultRank();
            Config.Save();
        }

        void UseDefaults()
        {
            txtServerName.Text = ConfigObj.Defaults().ServerName;
            txtPort.Text = "" + ConfigObj.Defaults().Port;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Config.Load();
                RankConfig.Load();
                //Gets all the ranks and puts them in the Rank List Box by Power Identification
                int Current = RankConfig.GetRanks().Length;
                foreach (Rank r in RankConfig.GetRanks())
                {
                    listOfRanks.Items.Add(RankConfig.GetRanks()[Current]);
                    Current--;
                }
                txtServerName.Text = Config.GetServerName();
                txtPort.Text = "" + Config.GetPort();
            }
            catch (Exception ex)
            {
                UseDefaults(); //Couldn't load -> Go ahead and use defaults
            }
        }

        int RankCount()
        {
            int ReturnValue = 0;
            foreach (String rankObjs in listOfRanks.Items)
            {
                ReturnValue++;
            }
            return ReturnValue;
        }
        private void btnAddRank_Click(object sender, EventArgs e)
        {
            int myRankCount = RankCount();
            if (myRankCount > 10)
            {
                ClearRankForm();
                foreach (String ranksItems in listOfRanks.Items)
                {
                    // N e w R a n k 5
                    // 0 1 2 3 4 5 6 7
                    if (ranksItems.Substring(0, 7).ToLower().Equals("newrank"))
                    {
                        try
                        {
                            int TryNum = Convert.ToInt32(ranksItems.Substring(8, 9)));
                        }
                        catch (FormatException ex)
                        {

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot add anymore ranks");
            }
        }
        void ClearRankForm()
        {
            tRankName.Clear();
            xReserveSlot.Checked = false;
            bColorRank.BackColor = Color.White;
            xKickIdle.Checked = false;
            nKickIdle.Enabled = false;
            nKickIdle.Value = 0;
            xAntiGrief.Checked = false;
            xDrawLimit.Checked = false;
            nAntiGriefBlocks.Enabled = false;
            nAntiGriefBlocks.Value = 0;
            nAntiGriefSeconds.Enabled = false;
            nAntiGriefSeconds.Value = 0;
            nDrawLimit.Enabled = false;
            nDrawLimit.Value = 0;
        }
        private void xReserveSlot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gRankOptions_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeleteRank_Click(object sender, EventArgs e)
        {
            ClearRankForm();
        }

        
    }
}
