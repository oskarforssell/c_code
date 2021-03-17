using System;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'chair experience'!");

            Chair officeChair = new Chair();
            Console.WriteLine($"Our {officeChair.Color} office chair has {officeChair.Legs} legs");
            Console.WriteLine($"Is someone sitting on it now: {officeChair.IsSitting}");
            officeChair.Legs = 2;
            officeChair.Color = "red";
            officeChair.IsSitting = true;
            Console.WriteLine($"Cut some legs to have {officeChair.Legs} legs, and paint it to make it {officeChair.Color}.");
            Console.WriteLine($"Is someone sitting on it now: {officeChair.IsSitting}");
            Console.WriteLine($"But it can only handle: {officeChair.MaxWeight}");


    
        }
    }
}
