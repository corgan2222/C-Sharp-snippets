using System;
using System.Diagnostics;
using System.ComponentModel;


namespace _03_c__kill_process
{
    class Program
    {
        static void Main(string[] args)
        {
            

            foreach(System.Diagnostics.Process myProc in System.Diagnostics.Process.GetProcesses())
            {
                if (myProc.ProcessName == "nsfminer")
                {
                    myProc.Kill();
                    Console.WriteLine("nsfminer killed");
                }
            }
        }
    }
}
