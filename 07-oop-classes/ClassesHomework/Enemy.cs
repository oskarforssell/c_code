namespace ClassesHomework
{
    class Enemy
    {
        string name = "Timothy";
        int healtPoints = 100;
        bool alive = true;
        public string Name { 
            get { return name; } 
        }
        public int HealtPoints
        {
            get { return healtPoints; }
        }
        public bool Alive
        {
            get { return alive; }
        }

        public void Hit(int reduceHP)
        {
            healtPoints = healtPoints - reduceHP;
            if (healtPoints < 0) {
                alive = false;
            }
        }
    }
}