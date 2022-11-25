using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class Aviary
    {
        public Aviary(string name, Biom biom, int square)
        {
            Name = name;
            Biom = biom;
            Square = square;
            Feeders = new Dictionary<food, double>();
        }
        public Dictionary<food, double> Feeders;
        public string Name;
        public Biom Biom;
        public int Square;
        protected List<Animal> Animals = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            bool CanLiveHere=false;
            if (animal.Biom == Biom && Square>animal.Area) 
            {
                if (Animals.Count != 0)
                {
                    if (Animals.ElementAt(0).IsPredator==false && animal.IsPredator==false)
                    {
                        Animals.Add(animal); 
                        CanLiveHere=true;
                        Square -= animal.Area;
                    }
                    if (Animals.ElementAt(0).IsPredator == true && animal.GetType() == Animals.ElementAt(0).GetType())
                    {
                        Animals.Add(animal); 
                        CanLiveHere = true;
                        Square -= animal.Area;
                    }
                }
                else
                {
                    Animals.Add(animal);
                    CanLiveHere = true;
                    Square -= animal.Area;
                }
            } 
            if(!CanLiveHere)
            Console.WriteLine($"{animal.Name} Can't live here");
        }
        public void MakeSound()
        {
            foreach(Animal a in Animals)
            {
                a.MakeNoise();
            }
        }
        public void PourFood(food Food, double amount)
        {
            foreach(Animal A in Animals)
            {
                if (A.Foods.Contains(Food))
                {
                    if (amount > A.AmountOfFood)
                    {
                        amount -= A.AmountOfFood;
                        A.Hunger = 0;
                    }
                    else
                    {
                        A.Hunger = A.AmountOfFood - amount;
                        amount = 0;
                        break;
                    }
                }
            }
            if (Feeders.ContainsKey(Food)) Feeders[Food] += amount;
            else Feeders.Add(Food, amount);
        }
        public void HungryAnimals()
        {
            foreach(Animal a in Animals) 
                if (a.Hunger > 0) Console.WriteLine($"{a.Name} is Hungry ): . Please, Feed him{a.Foods} in {a.Hunger} amount.");   
        }
        public void LeftFood()
        {
            if(Feeders.Count > 0)
            {
                foreach (KeyValuePair<food, double> pair in Feeders)
                    Console.WriteLine($"Amount of {pair.Key} is left in feeders is {pair.Value}");
            }
        }
    }
}
