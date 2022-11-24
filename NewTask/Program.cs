using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aviary nese = new Aviary("Saray", Biom.tundra, 43500);
            Animal pengu = new Penguin("Pengu", 5, 70);
            Animal penguin = new Penguin("Pingi", 15, 20);
            Elephant elif = new Elephant("Elif", 30, 45);
            nese.AddAnimal(elif);
            nese.AddAnimal(pengu);
            nese.AddAnimal(penguin);
            nese.MakeSound();
        }
    }
}
