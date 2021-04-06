namespace InhertanceAnimals
{
    static class AnimalStats
    {
        public static float CalculateEyesToLegsRatio(Animal animal)
        {
            return (float)animal.EyeCount / animal.LegCount;
        }
    }
}