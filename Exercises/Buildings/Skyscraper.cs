using System;

namespace Buildings
{
    class Skyscraper : Building
    {
        public string Address {get; set;} = "No address set";

        public Skyscraper()
        {
            this.Roof = true;
            this.Walls = 4;
            this.Windows = 80;
            this.Floors = 30;
            this.Doors = 1;
        }







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
