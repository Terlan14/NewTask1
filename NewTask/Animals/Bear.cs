using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask.Animals
{
    public class Bear : Animal
    {
        public Bear(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
        {
            IsPredator = true;
            Biom = Biom.tundra;
            Foods = new List<food>() { food.fish, food.meat};
            Area = 700;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"Bear {Name} goes, Moskau Moskau");
        }
    }

}
