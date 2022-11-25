using System.Collections.Generic;

namespace NewTask
{
    public abstract class Animal
    {
        public Biom Biom;
        public List<food> Foods;
        public int Area;
        public bool IsPredator;
        public Animal(string name, double amountOfFood, int age)
        {
            Age = age;
            AmountOfFood = amountOfFood;
            Name = name;
            Hunger=amountOfFood;
        }
        public  string Name { get; set; }
        public  double AmountOfFood { get; set; }
        public  int Age { get; set; }
        public double Hunger;
        public abstract void MakeNoise();
    }
}