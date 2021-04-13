using System;

namespace PeopleApp
{
    public class Adult : People
    {
        public string Car { get; set; }
        
        public Adult(string name ="Jeff", int age = 18, string car ="Audi")
        {
            Name = name;
            Age = age;
            Car = car;
        }
        public void AdultPrint()
        {
            Console.WriteLine($"{Name}, age {Age}, car: {Car}");
        }
    }
}
