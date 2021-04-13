using System;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            People.Greeting();
            People.Run();


            Child kid = new Child("Troy", 14, "Trekker");
            kid.ChildPrint();
            Child kido = new Child();
            kido.ChildPrint();

            Adult man = new Adult();
            man.AdultPrint();
            
        }
    }
}
