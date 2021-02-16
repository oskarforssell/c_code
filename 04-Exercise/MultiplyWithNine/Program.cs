using System;

namespace MultiplyWithNine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number between 1-9: ");

            string answer = Console.ReadLine();
            int ans = int.Parse(answer);
            
            Console.WriteLine(Multiplier(ans));

            static string Multiplier(int givenNumber) 
            {
                int numberNine = 9;
                int firstDigit = (givenNumber - 1);
                int secondDigit = (numberNine - firstDigit);

                string given = Convert.ToString(givenNumber);
                string firstPart = Convert.ToString(firstDigit);
                string secondPart = Convert.ToString(secondDigit);

                string result = string.Concat(firstPart, secondPart);

                Console.WriteLine($"{given}");
                return $"{given} * 9 == '({given}-1)' + '(9-{firstPart})' == '{firstPart}' + '{secondPart}' == '{result}' ";
            }
        }
    }
}
