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
            Animals= new List<Animal>();
        }

        public string Name { get; set; }
        public Biom Biom { get; set; }
        public int Square { get; set; }
        public List<Animal> Animals { get; protected set; }
        public void AddAnimal(Animal animal)
        {
            if (animal.Biom == Biom) 
            {
                if (Animals.Count != 0)
                {
                    if (Animals.ElementAt(0).IsPredator==false && animal.IsPredator==false) Animals.Add(animal);
                    if (Animals.ElementAt(0).IsPredator == true && animal.GetType() == Animals.ElementAt(0).GetType()) Animals.Add(animal);
                }
                else Animals.Add(animal);
            } 

            else Console.WriteLine($"{animal.Name} Can't live here");
        }
        public void MakeSound()
        {
            foreach(Animal a in Animals)
            {
                a.MakeNoise();
            }
        }
    }
}
