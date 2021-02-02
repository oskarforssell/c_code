using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

            Console.WriteLine("The days of the week {6}, {5}, {4}, {3}, {2}, {1}, {0}",
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday);
            
            if (today == DayOfWeek.Monday || today == DayOfWeek.Tuesday) {
                Console.WriteLine("Working time!!!");
            }

        }
    }
}
