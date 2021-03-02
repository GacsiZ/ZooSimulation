using System;

namespace ZooApp
{
    class Neat : Animal
    {
        public string Type;
        private double Amount;
        public Neat(string name, bool danger, string food, bool needWater)
       : base(name, danger, food, needWater)
        {
            Type = "Szarvasmarha";
            Amount = (gen.NextDouble() * (20.0 - 15.0)) + 15.0;
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
