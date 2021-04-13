using System;

namespace Buildings
{
    class Building
    {
        public bool Roof { get; protected set; } 
        public int Walls { get; protected set; }
        public int Doors { get; protected set; }
        public int Windows { get; protected set; }
        public int Floors { get; protected set; } = 1;

        public static int Count { get; private set; } = 0;

        public Building() { Count++; }

        public Building(int doors, int windows, int floors=1, int walls=4, bool roof=true)
        {
            Doors = doors;
            Windows = windows;
            Floors = floors;
            Walls = walls;
            Roof = roof;
            Count++;
        }
        public static void HowManyHouses()
        {
            if (Building.Count == 0)
            {
                Console.WriteLine($"No buildings constructed! Get to work!");
            }
            else if (Building.Count < 3)
            {
                Console.WriteLine($"Just {Building.Count} building.. build more!");
            }

            else { Console.WriteLine($"Well done! {Building.Count} buildings constructed!"); }
        }

        // ADDRESS???

        // All buildings have walls, a roof, 
        // Variable ammount in: 
        // windows
        // doors
        // ventialtion
        // electricity
        // pluming
        // heating
    }
}
