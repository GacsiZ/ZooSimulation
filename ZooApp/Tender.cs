using System;

namespace ZooApp
{
    class Tender
    {
        public string Name;
        private double maxFoodAndWater = 10.0;
        public Tender(string name)
        {
            Name = name;
        }
        public double AddOrWaterFood()
        {
            if (maxFoodAndWater >0)
            {
                Random rnd = new Random();
                double addfood = (rnd.NextDouble() * (maxFoodAndWater - 1.0)) + 1.0;
                maxFoodAndWater =maxFoodAndWater - addfood;
                return addfood;
            }
            else
            {
                return 0;
            }
        }

        public void FillIn()
        {
            maxFoodAndWater = 10;
        }
    }
}
