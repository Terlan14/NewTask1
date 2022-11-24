using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask.Animals
{
    public class Zebra : Animal
    {
        public Zebra(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
        {
            IsPredator = false;
            Biom = Biom.savanna;
            Foods = new List<food>() { food.hay };
            Area = 300;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"Zebra {Name} says, neigh neighhh");
        }
    }
}
