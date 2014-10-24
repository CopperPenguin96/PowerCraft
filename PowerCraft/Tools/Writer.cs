using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PowerCraft.Tools
{
    
    public enum LogType
    {
        Normal,
        Warning,
        Serious
    }
    public class WriterAdapter
    {
        private static String Time()
        {
            return "<" + DateTime.Now.ToString("h:mm:ss tt") + ">";
        }
        public static String PreviousLine = null;
        public static String MostRecentLine = "---------";
        public static int lineCount = 0;
        public static String[] lines = new String[lineCount];
        public static void AddTo(String text)
        {
            lineCount++;
            String[] OldArray = lines;
            String[] NewArray = new String[lineCount + 1];
            for (int lin = 0; lin < lineCount; lin++)
            {
                try
                {
                    NewArray[lin] = OldArray[lin];
                }
                catch (IndexOutOfRangeException ex)
                {

                }
            }
            PreviousLine = MostRecentLine;
            NewArray[lineCount] = "\n" + Time() + " " + text;
            MostRecentLine = NewArray[lineCount];
        }
    }
    public class Writer
    {
        private String text;
        public Writer(String textTobeWritten)
        {
            text = textTobeWritten;
        }
        public void WriteToTextFile(String filePath)
        {
            if (File.Exists(filePath)) File.Delete(filePath);
            StreamWriter sWriter = File.CreateText(filePath);
            sWriter.Write(text);
        }
        public void WriteToConsole(LogType lType)
        {
            WriterAdapter.AddTo(text);
        }
    }
}
