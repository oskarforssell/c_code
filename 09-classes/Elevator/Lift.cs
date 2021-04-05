using System;
using System.Collections.Generic;
namespace Elevator
{
    class Lift
    {
        //public int stories = 5;
        public int[] floors = new int[5] {1,2,3,4,5};

        public int CurrentFloor { get; private set; }
        public bool Moving { get; private set; }
        public void TargetFloor(int target)
        {
            Moving = true;
            CurrentFloor = target;
        }

        public void PrintPosition()
        {
            tagIndex = CurrentFloor - 1;
            


            for (int i=0; i<5; i++)
            {
                Console.Write((floors[i])+" ");
            }
            Console.WriteLine();
        }

    }
}
