using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public abstract class Animal
    {
        public enum biom
        {
            tropic,tundra,desert
        }
        public enum food
        {
            fish,meat,hay
        }
        public abstract biom Biom { get; set; }
        public abstract List<food> Foods { get; set; }
        public abstract int Area { get; set; }
        public Animal(string name,double amountOfFood, int age)
        {
            Age=age;
            AmountOfFood=amountOfFood;
            Name=name;
        }
        public abstract string Name { get; set; }
        public abstract double AmountOfFood { get; set; }
        public abstract int Age { get; set; }
        public abstract void MakeNoise();
      public static void Main() {
            Penguin penguin1 = new Penguin("Simba",12,5);
            penguin1.MakeNoise();
        }
    }
}
