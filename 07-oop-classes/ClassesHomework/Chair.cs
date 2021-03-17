namespace ClassesHomework
{
    class Chair
    {

        int legs = 4;
        string color = "blue";
        string maxWeight = "100kg";

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string MaxWeight 
        {
            get { return maxWeight; }
        }
        public bool IsSitting { get; set; }
    }
}
