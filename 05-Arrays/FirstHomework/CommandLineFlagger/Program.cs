using System;

namespace CommandLineFlagger
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFlags(args);
        }
        public static void CheckFlags(string[] argsInputs)
        {
            bool fFlagFound = false;
            bool vFlagFound = false;
            string fileName = "";
            // determine filename and if -f or -v are present
            for (int i = 0; i < argsInputs.Length; i++)
            {
                if ("-f" == argsInputs[i])
                {
                    fFlagFound = true;
                }
                if ("-v" == argsInputs[i])
                {
                    vFlagFound = true;
                }
                if (argsInputs[i].Contains("."))
                {
                    fileName = argsInputs[i];
                }
            }
            // output conditions
            if (fFlagFound == false)   // -f missing
            {
                Console.WriteLine("No file specified! (use the -f argument)");
            }
            else if (fFlagFound == true && vFlagFound == false)   // -f present, -v missing
            {
                Console.WriteLine($"{fileName}");
            }
            else if (fFlagFound == true && vFlagFound == true)   // -f & -v present
            {
                Console.WriteLine(fileName.Split('.')[0]);
            }
        }
    }
}
