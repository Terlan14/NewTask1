using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask.Animals
{
    public class Lion : Animal
    {
        public Lion(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
        {
            IsPredator = true;
            Biom = Biom.savanna;
            Foods = new List<food>() { food.meat };
            Area = 400;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"Lion {Name}, goes I like to move it");
        }
    }
}
