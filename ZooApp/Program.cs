using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tender gondozo = new Tender("Tamás");
            Animal[] animalArray = new Animal[6];
            animalArray[0] = new Tiger("Sirkán", true, "Hús", true);
            animalArray[1] = new Elephant("Dumbo", false, "Növény", true);
            animalArray[2] = new Neat("Boris", false, "Növény", false);
            animalArray[3] = new Hourse("Sanyi", false, "Növény", false);
            animalArray[4] = new Lion("Szimba", true, "Hús", true);
            animalArray[5] = new Fox("Vuk", true, "Hús", false);

            for (int i = 0; i < 20; i++)
            {
                Random gen = new Random();
                int animal = gen.Next(0, animalArray.Length);
                Console.WriteLine(animalArray[animal].Name + " Eszik vagy iszik");
                if (animalArray[animal].Danger)
                {
                    Console.WriteLine(animalArray[animal].Name + "-t be kellet zárni");
                    Thread.Sleep(2000);                    
                }
                double food = gondozo.AddOrWaterFood();
                if (food == 0.0)
                {
                    Console.WriteLine(gondozo.Name + " visszamegy a Raktárba és hoz még élelmet vagy vízet!");
                    Thread.Sleep(3000);
                    gondozo.FillIn();
                }
                else
                {
                    animalArray[animal].Eat(food);

                    if (animalArray[animal].IsDead())
                    {
                        Console.WriteLine(animalArray[animal].Name + " meghalt....");
                        Thread.Sleep(2000);
                        Environment.Exit(-1);
                    }
                }
                if (animalArray[animal].NeedWater)
                {
                    double water = gondozo.AddOrWaterFood();
                    if (water == 0.0)
                    {
                        Console.WriteLine(gondozo.Name + " visszamegy a Raktárba és hoz még élelmet vagy vízet!");
                        Thread.Sleep(3000);
                        gondozo.FillIn();
                    }
                    else
                    {
                        animalArray[animal].Drink(water);

                        if (animalArray[animal].IsDead())
                        {
                            Console.WriteLine(animalArray[animal].Name + " meghalt....");
                            Thread.Sleep(5000);
                            Environment.Exit(-1);
                        }
                    }
                }
                if (animalArray[animal].Danger)
                {
                    Console.WriteLine(animalArray[animal].Name + "-t ki kell engedni");
                    Thread.Sleep(2000);
                }
            }
            Console.ReadLine();
        }
    }
}
