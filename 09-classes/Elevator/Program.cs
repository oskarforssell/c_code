using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Lift elevator = new Lift(5);
            Console.WriteLine(elevator.CurrentFloor);

            elevator.Start(5);
            elevator.Start(3);

        }
    }
}
