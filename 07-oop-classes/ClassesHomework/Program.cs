using System;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THE CHAIR");

            Chair officeChair = new Chair();
            Console.WriteLine($"Our {officeChair.Color} office chair has {officeChair.Legs} legs");
            Console.WriteLine($"Is someone sitting on it now: {officeChair.IsSitting}");
            officeChair.Legs = 2;
            officeChair.Color = "red";
            officeChair.IsSitting = true;
            Console.WriteLine($"Cut some legs to have {officeChair.Legs} legs, and paint it to make it {officeChair.Color}.");
            Console.WriteLine($"Is someone sitting on it now: {officeChair.IsSitting}");
            Console.WriteLine($"But it can only handle: {officeChair.MaxWeight}");

            Console.WriteLine("-----\nTHE SUPERHERO");

            Superhero boy = new Superhero();
            Console.WriteLine($"My superhero name: {boy.HeroName}, superpower: {boy.HeroAbility}");
            Console.WriteLine($"I'm: {boy.GetAge} sun rotations old and human: {boy.HumanOrNot}");
            boy.HeroName = "SpongeBob";
            boy.HeroAbility = "Super fast floor mopper!";
            Console.WriteLine($"My superhero name: {boy.HeroName}, superpower: {boy.HeroAbility}");
            Console.WriteLine($"I'm: {boy.GetAge} sun rotations old and human: {boy.HumanOrNot}");

            Console.WriteLine("-----\nTHE ENEMY");
            Enemy tim = new Enemy();
            Console.WriteLine($"Name: {tim.Name}, HP: {tim.HealtPoints}, Alive: {tim.Alive}");
            tim.Hit(5);
            Console.WriteLine($"Name: {tim.Name}, HP: {tim.HealtPoints}, Alive: {tim.Alive}");
            tim.Hit(96);
            Console.WriteLine($"Name: {tim.Name}, HP: {tim.HealtPoints}, Alive: {tim.Alive}");

        }
    }
}
