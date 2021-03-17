namespace ClassesHomework
{
    class Superhero
    {
        string heroName = "Maybe Later Man";
        string heroAbility = "procrastination";
        int age = 29;

        public string HeroName {
            get { return heroName; }
            set { heroName = value; }
        }
        public string HeroAbility { 
            get { return heroAbility; }
            set { heroAbility = value; }
        }
        public bool HumanOrNot { get; set; }
        public int GetAge { 
            get { return age; }
        }


    }
}