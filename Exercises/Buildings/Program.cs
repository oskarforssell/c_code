using System;

namespace Buildings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Building.HowManyHouses();
            Building condo = new Building();
            Building.HowManyHouses();
            Building condo1 = new Building();
            Building.HowManyHouses();
            Building condo2 = new Building();
            Building.HowManyHouses();
            Building condo3 = new Building();
            Building.HowManyHouses();
            Building condollo = new Building();
            Building.HowManyHouses();
            Building house = new Building(1,4,1);

            Skyscraper tower = new Skyscraper();
            Skyscraper tower1 = new Skyscraper();

            Console.WriteLine(tower.Doors);
            Console.WriteLine(tower1.Windows);


            // Console.WriteLine($"Walls: {house.Walls}");
            // Console.WriteLine($"Roof: {house.Roof}");
            // Console.WriteLine($"Windows: {house.Windows}");
            // Console.WriteLine($"Doors: {house.Doors}");
            // Console.WriteLine($"How many floors: {house.Floors}");

            // Skyscraper tower = new Skyscraper();
            // Console.WriteLine(tower.Doors);
            
            // Console.WriteLine($"How many houses: {Building.Count}");
        }
    }
}