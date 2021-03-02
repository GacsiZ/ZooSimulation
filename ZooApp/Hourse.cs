using System;

namespace ZooApp
{
    class Hourse : Animal
    {
        public string Type;
        private double Amount;
        public Hourse(string name, bool danger, string food, bool needWater)
       : base(name, danger, food, needWater)
        {
            Type = "Ló";
            Amount = (gen.NextDouble() * (8.0 - 5.0)) + 5.0;
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
            if (0 >= Amount)
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
