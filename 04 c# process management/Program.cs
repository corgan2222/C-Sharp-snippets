using System;

namespace _04_c__process_management
{
    class Program
    {


        static bool checkIfProcressIsRunning(string proc)
        {
                Console.WriteLine(proc);
                return true;
        }        

        static bool runProcress(string proc)
        {
                Console.WriteLine(proc);
                return true;
        }        

        static bool killProcress(string proc)
        {
                Console.WriteLine(proc);
                return true;
        }        



        static void Main(string[] args)
        {
            // The Length property provides the number of array elements.
            Console.WriteLine($"parameter count = {args.Length}");

            if (args.Length > 1)
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
                Console.WriteLine(args[2]);

                bool result = checkIfProcressIsRunning(args[1]);
            }
        }


    }
}
