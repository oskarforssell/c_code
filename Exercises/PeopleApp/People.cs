using System;

namespace PeopleApp
{
    public class People
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string Type { get; protected set; }




        public People() { }

        public static void Greeting()
        {
            Console.WriteLine("\n*** Welcome to PeopleApp! ***\n");
        }
        public static void Commands()
        {
            Console.WriteLine(" ________________________ ");
            Console.WriteLine("| Command library:       |");
            Console.WriteLine("| add : add new person   |");
            Console.WriteLine("| all : list all persons |");
            Console.WriteLine("| lc : list all children |");
            Console.WriteLine("| la : list all adults   |");
            Console.WriteLine("| exit/quit : quit       |");
            Console.WriteLine("|________________________|\n");
            Console.Write("What would you like to do? ");
        }

        public static void Run()
        {
            string exit = "a";
            while (exit != "q")
            {
                Child[] kidArray = new Child[0];
                Adult[] adultArray = new Adult[0];
                int adultEntries = 0;
                int kidEntries = 0;
                Commands();
                string userInput = Console.ReadLine();
                if (userInput == "exit" || userInput == "quit")
                {
                    exit = "q";
                }

                if (userInput == "add")
                {
                    Console.Write("Name? ");
                    string userName = Console.ReadLine();
                    Console.Write("Age? ");
                    int userAge = Int16.Parse(Console.ReadLine());

                    if (userAge < 18)
                    {
                        Console.Write("Favourite bike? ");
                        string userBike = Console.ReadLine();
                        Child underAged = new Child(userName, userAge, userBike);
                        kidEntries++;
                        Array.Resize(ref kidArray, kidEntries);
                        kidArray[kidEntries - 1] = underAged; 
                    }
                    else if (userAge > 17)
                    {
                        Console.Write("Favourite car? ");
                        string userCar = Console.ReadLine();
                        Adult legalAged = new Adult(userName, userAge, userCar);
                        adultEntries++;
                        Array.Resize(ref adultArray, adultEntries);
                        adultArray[adultEntries - 1] = legalAged; 
                    }
                }
                // if (userInput == "lc")
                // {
                //     for (int i=0; i<kidEntries; i++)
                //     {
                //         Child kiddo = kidArray[i];
                //         Console.WriteLine(kiddo);
                //     }
                // }
            }
        }
    }
}
