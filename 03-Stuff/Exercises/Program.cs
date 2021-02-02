using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            Console.WriteLine("Task 1. Check if variable is 42");
            int funnyNumber = 42;

            if (funnyNumber == 42)
            {
                Console.WriteLine("the value is 42");
            }
            else
            {
                Console.WriteLine("funny value");
            }

            //TASK 2
            Console.WriteLine("Task 2. Your name");
            Console.Write("What is you name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hi {userName}, nice to meet you!");
            
            //TASK 3
            Console.WriteLine("Task 3. Even or odd");
            Console.Write("Give a number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else {
                Console.WriteLine("The number is odd");
            }

            // TASK 4
            Console.WriteLine("Task 4. Number under 10, 20 or over 20");
            Console.Write("Give a number: ");
            string userAns = Console.ReadLine();
            int userAnsInt = int.Parse(userAns);
            if (userAnsInt < 10)
            {
                Console.WriteLine("the number is smaller than 10");
            }
            else if (userAnsInt >= 10 && userAnsInt < 20)
            {
                Console.WriteLine("the number is less than 20");
            }
            else
            {
                Console.WriteLine("the number is greater than 20"); 
            }

            // TASK 5
            Console.WriteLine("Task 5. Input 10, 20, 30 or 40");
            Console.Write("Give a number, one of: 10, 20, 30 or 40: ");
            int userInte = Convert.ToInt32(Console.ReadLine()); 
            switch (userInte)
            {
                case 10:
                    Console.WriteLine(10 * 10);
                    break;
                case 20:
                    Console.WriteLine(20 / 2.5);
                    break;
                case 30:
                case 40:
                    Console.WriteLine("Great number!");
                    break;
            }

            // TASK 6
            Console.WriteLine("Task 6. Your name and length");
            Console.Write("What is you name? ");
            string givenName = Console.ReadLine();
            Console.WriteLine($"Hi {givenName}, nice to meet you!");
            int givenNameLength = givenName.Length;
            Console.WriteLine($"Your name has {givenNameLength} characters..");
        }
    }
}
