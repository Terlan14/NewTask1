using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class Elephant : Animal
    {
        public override biom Biom { get ; set ; }
        public override List<food> Foods { get ; set ; }
        public override int Area { get  ; set ; }
        public override string Name { get ; set ; }
        public override double AmountOfFood { get ; set ; }
        public override int Age { get ; set ; }
        public Elephant(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
        {
            Biom = biom.desert;
            Foods = new List<food>() { food.hay };
            Area = 500;
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"Siuuu said, elephant {Name}");
        }
    }
}
