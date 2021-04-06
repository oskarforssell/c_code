using System;

namespace InhertanceAnimals
{

    public class Animal
    {
        public int LegCount { get; protected set; }
        public int EyeCount { get; protected set; }

        public static int Count { get; private set; } = 0;

        public Animal() {}
        public Animal(int legs, int eyes = 2)
        {
            LegCount = legs;
            EyeCount = eyes;
            Count++;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sounds!");
        }

        public static void StaticAnimal()
        {
            Console.WriteLine("StaticAnimal() called");
        }
    }
}
