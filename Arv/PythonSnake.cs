using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class PythonSnake : Animal
    {
        public int Length { get; set; } = 500;

        public PythonSnake(string name, int age)
        {
            Name = name;
            Age = age;
            Legs = 0;
            Lifespan = 30;
            HasFurr = false;
            IsLandAnimal = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("SSSSHSHSHHSHSHSHSH");
        }

        public override void InformationAbout()
        {
            base.InformationAbout();
            Console.WriteLine($"Längd: {Length}cm");
        }

        public void ShedSkin()
        {
            Console.WriteLine($"{Name} byter sitt skal.");

            Thread.Sleep(750);
            Console.Write(".");
            Thread.Sleep(750);
            Console.Write(".");
            Thread.Sleep(750);
            Console.Write(".");
            Thread.Sleep(750);
            Console.Write(".");
            Thread.Sleep(750);
            Console.WriteLine(".");


            Console.WriteLine($"{Name} känner sig ny och fräsch efter att ha bytt skal!");
        }

    }
}
