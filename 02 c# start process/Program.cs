﻿using System;
using System.Diagnostics;
using System.ComponentModel;

namespace _02_c__start_process
{
    class Program
    {
        public static void Main()
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = "C:\\Windows\\Explorer.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    // This code assumes the process you are starting will terminate itself.
                    // Given that it is started without a window so you cannot terminate it
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            
    }
}
