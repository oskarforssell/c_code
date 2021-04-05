using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Lift hissi = new Lift();
            hissi.TargetFloor(3);

            hissi.PrintPosition();
        }
    }
}
