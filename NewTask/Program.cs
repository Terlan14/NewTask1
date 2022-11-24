using NewTask.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aviary place = new Aviary("Baku Zoo", Biom.savanna, 12000);
            Animal Marty = new Zebra("Marty", 7, 6);
            Animal Dumbo = new Elephant("Dumbo", 45, 10);
            Animal Alex = new Lion("Alex", 30, 5);
            place.AddAnimal(Marty);
            place.AddAnimal(Dumbo);
            place.AddAnimal(Alex);
            place.HungryAnimals();
            place.PourFood(food.hay, 30);
            place.LeftFood();
            place.HungryAnimals();
            place.LeftFood();
            place.MakeSound();
        }
    }
}
