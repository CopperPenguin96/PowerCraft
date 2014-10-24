using PowerCraft.Network;
using PowerCraft.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace PowerCraft
{
    public class Config
    {
        #region ServerName
        private static String ServerName;
        public static String GetServerName()
        {
            return ServerName;
        }
        public static void SetServerName(String s)
        {
            ServerName = s;
        }
        #endregion

        #region HeartbeatURL
        private static HeartbeatLocation hbLocation;
        public static HeartbeatLocation GetHBLocation()
        {
            return hbLocation;
        }
        public static void SetHeartBeatLocation(HeartbeatLocation hb)
        {
            hbLocation = hb;
        }
        public static String heartbeatURL()
        {
            switch (GetHBLocation())
            {
                case HeartbeatLocation.ClassiCube:
                    return "http://www.classicube.net/heartbeat.jsp";
                default:
                    return "https://minecraft.net/heartbeat.jsp";
            }
        }
        #endregion

        #region Privacy
        private static bool Privacy = false;
        public static bool GetPrivacy()
        {
            return Privacy;
        }
        public static void SetPrivacy(bool priv)
        {
            Privacy = priv;
        }
        #endregion

        #region MaxPlayers
        private static int MaxPlayers;
        public static int GetMaxPlayers()
        {
            return MaxPlayers;
        }
        public static void SetMaxPlayers(int i)
        {
            MaxPlayers = i;
        }
        #endregion

        #region Port
        private static int Port;
        public static int GetPort()
        {
            return Port;
        }
        public static void SetPort(int i)
        {
            Port = i;
        }
        #endregion

        #region IP
        public static String GetIP()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://ifconfig.me");
            request.UserAgent = "curl"; // this simulate curl linux command
            string publicIPAddress;
            request.Method = "GET";
            using (WebResponse response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    publicIPAddress = reader.ReadToEnd();
                }
            }
            return publicIPAddress.Replace("\n", "");
        }
        #endregion

        #region Saving/Loading
        public static void Save()
        {
            ConfigObj cObj = new ConfigObj
            {
                ServerName = GetServerName(),
                HeartBeatURL = heartbeatURL(),
                Privacy = GetPrivacy(),
                MaxPlayers = GetMaxPlayers(),
                Port = GetPort(),
                IP = GetIP()
            };
            JSONWriter.SaveConfig(cObj);
        }
        static HeartbeatLocation ToHBEnumObj(String url)
        {
            switch (url)
            {
                case "http://www.classicube.net/heartbeat.jsp":
                    return HeartbeatLocation.ClassiCube;
                default:
                    return HeartbeatLocation.MinecraftNet;
            }
        }
        public static void Load()
        {
            ConfigObj cObj = JSONReader.cObj();
            SetHeartBeatLocation(ToHBEnumObj(cObj.HeartBeatURL));
            SetMaxPlayers(cObj.MaxPlayers);
            SetPort(cObj.Port);
            SetPrivacy(cObj.Privacy);
            SetServerName(cObj.ServerName);
        }
        #endregion
    }

    public class ConfigObj
    {
        public String ServerName;
        public String HeartBeatURL;
        public bool Privacy;
        public int MaxPlayers;
        public int Port;
        public String IP;
    }
}
