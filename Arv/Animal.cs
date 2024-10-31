using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Animal
    {
        public string Name { get; set; } = "Unnamed";
        public int Age { get; set; } = 0;
        public int Legs { get; set; } = 0;
        public int Lifespan { get; set; } = 100;
        public bool HasFurr { get; set; } = false;
        public bool IsLandAnimal { get; set; } = false;

        public virtual void MakeSound()
        {
            Console.WriteLine("Detta djuret gör inget ljud");
        }

        public virtual void InformationAbout()
        {
            Console.WriteLine($"Namn: {Name}\n" +
                $"Ålder: {Age}\n" +
                $"Antal Ben: {Legs}\n" +
                $"Djuret har päls: {HasFurr}\n" +
                $"Djuret är ett landdjur: {IsLandAnimal}");
        }

        public void AgeUp()
        {
            Age += 1;
        }

        public void RemainingLifespan()
        {
            int remaining = Lifespan - Age;
            Console.WriteLine($"Återstående livslängd för {Name}: {remaining} år.");
        }
    }
}
