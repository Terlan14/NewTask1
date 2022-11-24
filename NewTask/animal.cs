using System.Collections.Generic;

namespace NewTask
{
    public abstract class Animal
    {
        public enum food
        {
            fish, meat, hay
        }
        public Biom Biom { get; set; }
        public List<food> Foods { get; set; }
        public int Area { get; set; }
        public bool IsPredator;
        public Animal(string name, double amountOfFood, int age, bool isPredator)
        {
            Age = age;
            AmountOfFood = amountOfFood;
            Name = name;
            IsPredator = isPredator;
        }
        public  string Name { get; set; }
        public  double AmountOfFood { get; set; }
        public  int Age { get; set; }
        public abstract void MakeNoise();

    }
}
