using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask.Animals
{
    public class Chimpanzee : Animal
    {
        public Chimpanzee(string name, double amountOfFood, int age) : base(name, amountOfFood, age)
        {
            IsPredator=false;
            Biom = Biom.tropic;
            Foods = new List<food>() { food.hay , food.bugs};
            Area = 200;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"Chimpanzee {Name} Made huhahahuha chimping noises");
        }
    }
}
