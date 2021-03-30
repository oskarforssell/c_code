using System;

namespace ClassMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal(4);
            // dog.MakeSound();
            Console.WriteLine(Animal.Count);

            Animal spider = new Animal(8, 8);
            // spider.MakeSound();
            Console.WriteLine(Animal.Count);

            Animal.StaticAnimal();

            Console.WriteLine(AnimalStats.CalculateEyesToLegsRatio(dog));
        }
    }

    static class AnimalStats
    {
        // doesn't work because instance member. Works if private static int count = 0;
        //private int count = 0;
        public static float CalculateEyesToLegsRatio(Animal animal)
        {
            return (float)animal.EyeCount / animal.LegCount;
        }
    }
    class Animal
    {
        // instance members
        public int LegCount { get; private set; }
        public int EyeCount { get; private set; }

        // class member
        public static int Count { get; private set; } = 0;

        public Animal(int legs, int eyes = 2)
        {
            LegCount = legs;
            EyeCount = eyes;
            Count++;
        }

        public void MakeSound()
        {
            Console.WriteLine("Animal sounds!");
        }

        public static void StaticAnimal()
        {
            Console.WriteLine("StaticAnimal() called");
        }
    }
}
