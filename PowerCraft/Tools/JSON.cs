using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace PowerCraft.Tools
{
    public class JSONWriter
    {
        public static void SaveConfig(ConfigObj cObj)
        {
            String text = JsonConvert.SerializeObject(cObj);
            Writer textWriter = new Writer(text);
            textWriter.WriteToTextFile("config.json");
        }
    }

    public class JSONReader
    {
        public static ConfigObj cObj()
        {
            string json = File.ReadAllText(@"config.json");
            return JsonConvert.DeserializeObject<ConfigObj>(json);
        }
    }
}
