using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class BlueWhale : Animal
    {
        public int Weight { get; set; } = 140;

        public BlueWhale(string name, int age)
        {
            Name = name;
            Age = age;
            Legs = 0;
            Lifespan = 90;
            HasFurr = false;
            IsLandAnimal = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("ÅÅÅÅÅÅAAAAAAOOOOOOO");
        }

        public override void InformationAbout()
        {
            base.InformationAbout();
            Console.WriteLine($"Vikt: {Weight}ton");
        }

        public void Dive(int depth)
        {
            if (depth > 0)
            {
                Console.WriteLine($"{Name} dyker ner till {depth} meter.");
            }
            else
            {
                Console.WriteLine($"{Name} kan inte dyka till ett negativt djup!");
            }
        }
    }
}
