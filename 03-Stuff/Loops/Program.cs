using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // // i++ ==  (i = i + 1)
            // // for (init variable ; condition ; change) 
            // // in python: for i in range(0, 5)
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // // in python: for i in range(0, end, 2)
            // for (int i = 0; i < 5; i = i + 2)
            // {
            //     Console.WriteLine(i);
            // }

            int rounds = 0;
            while (rounds < 4)
            {
                Console.WriteLine("while " + rounds.ToString());
                rounds++;
            }
            Console.WriteLine("after while");

            rounds = 0;
            // with do-while it will be executed at least once, because the condition is checked after the execution
            do 
            {
                Console.WriteLine("do-while " + rounds.ToString());
                rounds++;
            } while (rounds < 4);
        }
    }
}
