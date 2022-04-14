using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace supershop.utils
{
    public class CairoFontDownloader
    {
        

            // Declaring a dll import is nothing more than copy/pasting the next method declaration in your code. 
            // You can call the method from your own code, that way you can call native 
            // methods, in this case, install a font into windows.
            [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
            public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                     string lpFileName);

            // This is a unit test sample, which just executes the native method and shows
            // you how to handle the result and get a potential error.

            public void InstallFont()
            {

            //@"C:\Users\lenovo\source\repos\Testing\Cairo.ttf"
            string full = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Resources\Cairo.ttf";
            // Try install the font.
            var result = AddFontResource(full);
                var error = Marshal.GetLastWin32Error();
                if (error != 0)
                {
                    Console.WriteLine(new Win32Exception(error).Message);
                }
            }
        }
    }

    

    

