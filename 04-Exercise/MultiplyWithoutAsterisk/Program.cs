using System;

namespace MultiplyWithoutAsterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            string uno = Console.ReadLine();
            Console.Write("Now time that by (another number): ");
            string dos = Console.ReadLine();

            int eka = int.Parse(uno);
            int toka = int.Parse(dos);
            Console.WriteLine(MultiplyWierd(eka, toka));

            static int MultiplyWierd(int firstGiven, int secondGiven)
            {
                int result = 0;
                for (int i=0; i<firstGiven; i++)
                {
                    result += secondGiven;
                }
                return result;
            }
        }
    }
}
