using System;

namespace ZooApp
{
    class Fox : Animal
    {
        public string Type;
        private double Amount;

        public Fox(string name, bool danger, string food, bool needWater)
     : base(name, danger, food, needWater)
        {
            Type = "Róka";
            Amount = (gen.NextDouble() * (1.0 - 0.0)) + 0.0;
        }

        public override void Eat(double giveFood)
        {
            Console.WriteLine(this.Name +" eszik..." + giveFood.ToString() + " " + this.Food + "-t");
            Amount -= giveFood;
        }
        public override void Drink(double giveWater)
        {
        }

        public override bool IsDead()
        {
            if (0.0 >= Amount)
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
