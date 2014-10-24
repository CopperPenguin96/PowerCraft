using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerCraft.Tools
{
    public class Updater
    {
        public static String VersionString()
        {
            return "PowerCraft " + versionNumber();
        }
        public static String versionNumber()
        {
            return "1.0.0.0";
        }
    }
}
