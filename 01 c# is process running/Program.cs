using System;
using System.Diagnostics;
using System.ComponentModel;

// https://blog.mwpreston.net/2018/09/24/how-to-run-c-sharp-in-visual-studio-code/
// dotnet new console
// dotnet build 
// dotnet run

namespace _01_c__is_process_running
{
    class Program
    {
        static void Main(string[] args)
        {


            //itterate through open processes
            Process[] processlist = Process.GetProcesses();
            foreach(Process theprocess in processlist)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }


            //single check
            Process[] pname = Process.GetProcessesByName("notepad");
            if (pname.Length > 0)
            {
                Console.WriteLine("Notepad is running");
            }
            else
            {
                Console.WriteLine("Notepad is not running");
            }


        }
    }
}
