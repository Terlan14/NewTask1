using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class Elephant : Animal
    {
        public Elephant(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
        {
            IsPredator=false;
            Biom = Biom.savanna;
            Foods = new List<food>() { food.hay };
            Area = 500;
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"Siuuu said, elephant {Name}");
        }
    }
}
