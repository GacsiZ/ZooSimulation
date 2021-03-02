using System;

namespace ZooApp
{
    abstract class Animal
    {
        public string Name { get; set; }
        public bool Danger { get; set; }
        public string Food { get; set; }
        public bool NeedWater { get; set; }

        public Random gen = new Random();
        public Animal(string name, bool danger, string food, bool needWater)
        {
            this.Name = name;
            this.Danger = danger;
            this.Food = food;
            this.NeedWater = needWater;
        }
       
        abstract public void Eat(double giveFood);

        abstract public void Drink(double giveWater);

        abstract public bool IsDead();
    }
}
