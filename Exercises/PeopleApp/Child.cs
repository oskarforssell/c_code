using System;

namespace PeopleApp
{
    public class Child : People
    {
        public string Bike { get; set; }
        
        public Child(string name ="Bob", int age = 12, string bike ="Kona")
        {
            this.Name = name;
            this.Age = age;
            Bike = bike;
        }
        public void ChildPrint()
        {
            Console.WriteLine($"{Name}, age {Age}, bike: {Bike}");
        }
    }
}
