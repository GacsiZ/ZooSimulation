using System;

namespace ZooApp
{
    class Tiger : Animal
    {
        public string Type;       
        private double Amount;
        private double Water;
        public Tiger(string name, bool danger, string food, bool needWater)
        : base(name, danger, food, needWater)
        {
            Type = "Tigris";
            Amount = (gen.NextDouble() * (30.0 - 20.0)) + 20.0;
            Water = (gen.NextDouble() * (2.0 - 1.0)) + 1.0;            
        }
        public override void Eat(double giveFood)
        {
            Console.WriteLine("Tigris eszik..." + giveFood.ToString() + " " + this.Food + "-t");
            Amount -= giveFood;
        }
        public override void Drink(double giveWater)
        {
            Console.WriteLine(this.Name + " iszik " + giveWater.ToString() + " vízet");
            Amount -= giveWater;
        }

        public override bool IsDead()
        {
            if (0.0 >= Amount)
            {
                return true;
            }
            else if (0.0 >= Water)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
