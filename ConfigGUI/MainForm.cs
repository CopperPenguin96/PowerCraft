using System.Linq;
using System.Windows.Forms.VisualStyles;
using PowerLib;
using PowerLib.PlayerDB;
using PowerLib.PowerCraft;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

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
            try
            {
                Config.SetServerName(txtServerName.Text);
                Config.SetPrivacy(true);
                Config.SetPort(Convert.ToInt32(txtPort.Text));
                Config.SetMaxPlayers(20);
                Config.SetHeartBeatLocation(PowerLib.PowerCraft.Network.HeartbeatLocation.ClassiCube);
                //Config.SetDefaultRank();
                Config.Save();
                //Saving the ranks
                RankConfig.SetRanks(rankList);
                RankConfig.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save config. Please check all fields!");
            }
        }

        void UseDefaults()
        {
            txtServerName.Text = ConfigObj.Defaults().ServerName;
            txtPort.Text = "" + ConfigObj.Defaults().Port;
        }

        public Rank[] rankList;
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
                UseDefaults();
            }
            finally
            {
                try
                {
                    RankConfig.Load();
                    rankList = RankConfig.GetRanks();
                    ResetRankList();
                }
                catch (Exception)
                {
                    UseRankDefaults();
                }
            }
        }

        void UseRankDefaults()
        {
            rankList = new Rank[]
            {
                getDefaultRanks(0),
                getDefaultRanks(1),
                getDefaultRanks(2),
                getDefaultRanks(3)
            };
            foreach (Rank r in rankList)
            {
                listOfRanks.Items.Add(r);
            }
        }

        Rank GetRank(int ID)
        {
            Rank desiredRank = null;
            foreach (Rank r in rankList)
            {
                if (r.ID == ID)
                {
                    desiredRank = r;
                }
            }
            return desiredRank;
        }

        Rank getDefaultRanks(int Power)
        {
            Power++; //I didn't feel like updating the integer in the switch
            Rank myNewRank = null;
            switch (Power)
            {
                case 1:
                    myNewRank = new Rank()
                    {
                        Name = "Owner",
                        DrawLimit = false,
                        GriefDetection = false,
                        ID = 0,
                        KickIfIdle = false,
                        ReservePlayerSpot = false,
                        RankColor = Color.Black
                    };
                    break;
                case 2:
                    myNewRank = new Rank()
                    {
                        Name = "Op",
                        DrawLimit = false,
                        GriefDetection = false,
                        ID = 1,
                        KickIfIdle = false,
                        ReservePlayerSpot = false,
                        RankColor = Color.Maroon
                    };
                    break;
                case 3:
                    myNewRank = new Rank()
                    {
                        Name = "Builder",
                        DrawLimit = false,
                        GriefDetection = false,
                        ID = 2,
                        KickIfIdle = false,
                        ReservePlayerSpot = false,
                        RankColor = Color.Yellow
                    };
                    break;
                case 4:
                    myNewRank = new Rank()
                    {
                        Name = "Guest",
                        DrawLimit = false,
                        GriefDetection = false,
                        ID = 3,
                        KickIfIdle = false,
                        ReservePlayerSpot = false,
                        RankColor = Color.White
                    };
                    break;
            }
            return myNewRank;
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

        private bool addingNewRank = false;
        private void btnAddRank_Click(object sender, EventArgs e)
        {
            addingNewRank = true;
            ClearRankForm();
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
            if (listOfRanks.SelectedIndex < 0)
            {
                MessageBox.Show("You need to select a rank before you attempt to delete one!");
            }
            else
            {
                Rank badRank = GetRank(listOfRanks.SelectedIndex);
                rankList = rankList.Where(w => w != badRank).ToArray();
                ResetRankIDs();
                ResetRankList();
            }
        }

        void ResetRankIDs()
        {
            int loopCount = -1;
            foreach (Rank r in rankList)
            {
                if (loopCount < rankList.Length + 1)
                {
                    rankList[loopCount + 1].ID = loopCount + 1;
                    loopCount++;
                }
            }
        }
        void ResetRankList()
        {
            listOfRanks.Items.Clear();
            foreach (Rank r in rankList)
            {
                listOfRanks.Items.Add(r.Name);
            }
        }
        private void listOfRanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rank selectedRank = GetRank(listOfRanks.SelectedIndex);
            tRankName.Text = selectedRank.Name;
            xReserveSlot.Checked = selectedRank.ReservePlayerSpot;
            bColorRank.BackColor = selectedRank.RankColor;
            xKickIdle.Checked = selectedRank.KickIfIdle;
            if (xKickIdle.Checked)
            {
                nKickIdle.Enabled = true;
                nKickIdle.Value = selectedRank.KickIfIdleTime;
            }
            xAntiGrief.Checked = selectedRank.GriefDetection;
            if (xAntiGrief.Checked)
            {
                nAntiGriefBlocks.Enabled = true;
                nAntiGriefBlocks.Value = selectedRank.GriefDetectionBlocks;
                nAntiGriefSeconds.Enabled = true;
                nAntiGriefSeconds.Value = selectedRank.GriefDetectionTimeInSecs;
            }
            xDrawLimit.Checked = selectedRank.DrawLimit;
            if (xDrawLimit.Checked)
            {
                nDrawLimit.Enabled = true;
                nDrawLimit.Value = selectedRank.DrawLimitAmount;
            }
            MessageBox.Show("SelectedID is " + selectedRank.ID);
        }

        private void btnSaveRank_Click(object sender, EventArgs e)
        {
            if (addingNewRank)
            {
                Rank theNewRank = new Rank();
                theNewRank.Name = tRankName.Text;
                theNewRank.ID = listOfRanks.Items.Count; //Count is not 0 based
                theNewRank.ReservePlayerSpot = xReserveSlot.Checked;
                theNewRank.RankColor = bColorRank.BackColor;
                theNewRank.KickIfIdle = xKickIdle.Checked;
                if (xKickIdle.Checked)
                {
                    theNewRank.KickIfIdleTime = (int) nKickIdle.Value;
                }
                theNewRank.GriefDetection = xAntiGrief.Checked;
                if (xAntiGrief.Checked)
                {
                    theNewRank.GriefDetectionBlocks = (int) nAntiGriefBlocks.Value;
                    theNewRank.GriefDetectionTimeInSecs = (int) nAntiGriefSeconds.Value;
                }
                theNewRank.DrawLimit = xDrawLimit.Checked;
                if (xDrawLimit.Checked)
                {
                    theNewRank.DrawLimitAmount = (int) nDrawLimit.Value;
                }
                Rank[] oldArray = rankList;
                // array to list
                List<Rank> itemsList = oldArray.ToList<Rank>();
                itemsList.Add(theNewRank);
                rankList = itemsList.ToArray();
                ResetRankList();
                ResetRankIDs();
            }
            else
            {
                //practically just save to the rank array
                Rank selected = GetRank(listOfRanks.SelectedIndex);
                int chosenItem = selected.ID;
                //We have the selected ID, now let's reassign
                selected = new Rank();
                selected.Name = tRankName.Text;
                selected.ID = chosenItem; //Count is not 0 based
                selected.ReservePlayerSpot = xReserveSlot.Checked;
                selected.RankColor = bColorRank.BackColor;
                selected.KickIfIdle = xKickIdle.Checked;
                if (xKickIdle.Checked)
                {
                    selected.KickIfIdleTime = (int)nKickIdle.Value;
                }
                selected.GriefDetection = xAntiGrief.Checked;
                if (xAntiGrief.Checked)
                {
                    selected.GriefDetectionBlocks = (int)nAntiGriefBlocks.Value;
                    selected.GriefDetectionTimeInSecs = (int)nAntiGriefSeconds.Value;
                }
                selected.DrawLimit = xDrawLimit.Checked;
                if (xDrawLimit.Checked)
                {
                    selected.DrawLimitAmount = (int)nDrawLimit.Value;
                }
                rankList[chosenItem] = selected;
            }
            ResetRankList();
        }

        private void bColorRank_Click(object sender, EventArgs e)
        {
            ColorPicker picker = new ColorPicker("Rank Color", bColorRank.BackColor);
            picker.ShowDialog();
            bColorRank.BackColor = picker.SelectedColor;
        }

        void OrganizeByID(Rank[] newRanks)
        {
            //TODO - Organize from lowest to highest ID
            Rank[] newRankList = newRanks;
            int CurrentItem = 0;
            foreach (Rank r in newRankList)
            {
                if (r.ID == CurrentItem)
                {
                    rankList[CurrentItem] = r;
                }
                else
                {
                    foreach (Rank r2 in newRankList)
                    {
                        if (r2.ID == CurrentItem)
                        {
                            rankList[CurrentItem] = r2;
                        }
                    }
                }
                CurrentItem++;
            }
            ResetRankList();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            Rank[] oldArrayRanks = rankList;
            int SelectedItem = listOfRanks.SelectedIndex;
            if (SelectedItem < 0)
            {
                MessageBox.Show("You have to select a rank before moving one!");
            }
            else
            {
                Rank[] oldArray = rankList;
                Rank selectedRank = GetRank(SelectedItem);
                Rank prevRank = GetRank(SelectedItem - 1);
                selectedRank.ID -= 1;
                prevRank.ID += 1;
                oldArray[SelectedItem] = prevRank;
                oldArray[SelectedItem - 1] = selectedRank;
                rankList = oldArray;
                ResetRankList();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Rank[] oldArrayRanks = rankList;
            int SelectedItem = listOfRanks.SelectedIndex;
            if (SelectedItem < 0)
            {
                MessageBox.Show("You have to select a rank before moving one!");
            }
            else
            {
                Rank[] oldArray = rankList;
                Rank selectedRank = GetRank(SelectedItem);
                Rank prevRank = GetRank(SelectedItem + 1);
                selectedRank.ID += 1;
                prevRank.ID -= 1;
                oldArray[SelectedItem] = prevRank;
                oldArray[SelectedItem + 1] = selectedRank;
                rankList = oldArray;
                ResetRankList();
            }
        }
    }
}