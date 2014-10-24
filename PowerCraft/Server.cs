using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerCraft
{
    public class Server
    {
        #region PlayerList
        private static Player[] playerList;
        public static Player[] GetPlayerList()
        {
            return playerList;
        }
        public static void SetPlayerList(Player[] pList)
        {
            playerList = pList;
        }
        #endregion
    }
}
