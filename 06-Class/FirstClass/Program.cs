using System;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Greet("Oskar");

            MyClass dod = new MyClass();
            dod.Greet("table");

        }
    }

    class MyClass
    {
        public void Greet(string str)
        {
            Console.WriteLine("Hello " + str);
        }
    }
}
