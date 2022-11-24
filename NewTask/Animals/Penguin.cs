using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class Penguin : Animal
    {
        public Penguin(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
        {
            IsPredator=false;
            Biom = Biom.tundra;
            Foods = new List<food>() { food.fish };
            Area = 100;
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"NOoot NOoot said, penguin {Name}");
        }

    }

}
