using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConfigGUI
{
    public class Font
    {
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                         string lpFileName);
        public static void downloadFontIfNeeded()
        {
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;
            List<string> fonts = new List<string>();
            //Install the font.
            int result = AddFontResource("http://powercraftdl.weebly.com/uploads/3/8/7/5/38754049/grudge.ttf");
            int error = Marshal.GetLastWin32Error();
            if (error != 0)
            {
                Console.WriteLine(new Win32Exception(error).Message);
            }
            else
            {
                Console.WriteLine((result == 0) ? "Font is already installed." :
                                                  "Font installed successfully.");
            }                
        }
    }
}
