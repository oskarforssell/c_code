using System;

namespace ReadingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            string input = Console.ReadLine();

            Console.WriteLine(input);

            int inputInt = int.Parse(input);  //convert string to int
            
            Console.WriteLine(inputInt * 2);

            Console.Write("Give a number: ");
            string input2 = Console.ReadLine();

            double inputDouble = double.Parse(input2); //convert string to double

            int d2 = (int)7.2;

            Console.WriteLine(d2);
        }
    }
}
