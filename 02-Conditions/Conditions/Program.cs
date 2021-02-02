using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;                    //  CTRL + K + C  --> adds comments
            if (num == 1)                   //  CRTL + K + U --> removes comments
            {
                Console.WriteLine("1");
            }
            // python elif == c# else if
            else if (num == 2)
            {
                Console.WriteLine("2");
            }

            else
            {
                Console.WriteLine("some number");
            }

            if (num != 4)
            {
                Console.WriteLine("not four");
            }

            // bool a = true;
            // bool b = false;

            // // python and == &&
            // if (a == true && b == true)
            // {
            //     Console.WriteLine("both are true");
            // }

            // // python or == ||
            // if (a == true || b == true)
            // {
            //     Console.WriteLine("either one is true");
            // }
        }
    }
}
