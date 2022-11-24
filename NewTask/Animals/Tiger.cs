using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class Tiger : Animal
    {
        public Tiger(string name, double amountOfFood, int age) :base(name,amountOfFood,age)
        {
            IsPredator=true;
            Biom = Biom.tropic;
            Foods= new List<food>() {food.meat};
            Area = 400;
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"RRrrrrrr said, tiger {Name}");
        }
    }
}
