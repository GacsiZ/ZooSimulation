using System;

namespace ZooApp
{
    class Elephant : Animal
    {
        public string Type;
        private double Amount;
        private double Water;
        public Elephant(string name, bool danger, string food, bool needWater)
       : base(name, danger, food, needWater)
        {
            Type = "Elefánt";
            Amount = (gen.NextDouble() * (35.0 - 20.0)) + 20.0;
            Water = (gen.NextDouble() * (20.0 - 15.0)) + 15.0; ;
        }
        public override void Eat(double giveFood)
        {
            Console.WriteLine( this.Name + " eszik " + giveFood.ToString() + " " + this.Food + "-t");
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
