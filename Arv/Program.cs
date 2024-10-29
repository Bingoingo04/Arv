using System.Net.Cache;

namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leopard leopard1 = new Leopard("Leo", 12);
            leopard1.InformationAbout();
            leopard1.Hunt();

            Console.WriteLine("\n----------------\n");

            BlueWhale blueWhale1 = new BlueWhale("Bert", 60);
            blueWhale1.InformationAbout();
            blueWhale1.Dive(500);

            Console.WriteLine("\n----------------\n");

            PythonSnake pythonSnake1 = new PythonSnake("Paul", 23);
            pythonSnake1.InformationAbout();
            pythonSnake1.RemainingLifespan();
            pythonSnake1.ShedSkin();
        }
    }

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

    public class Leopard : Animal
    {
        public int TopSpeed { get; set; } = 58;

        public Leopard(string name, int age)
        {
            Name = name;
            Age = age;
            Legs = 4;
            Lifespan = 15;
            HasFurr = true;
            IsLandAnimal = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("GRHHHHHHH");
        }

        public override void InformationAbout()
        {
            base.InformationAbout();
            Console.WriteLine($"Topfart: {TopSpeed}km/h");
        }

        public void Hunt()
        {
            Random rand = new Random();
            bool success = rand.Next(2) == 0;

            if (success)
            {
                Console.WriteLine($"{Name} jagar framgångsrikt sitt byte!");
            }
            else
            {
                Console.WriteLine($"{Name} misslyckas med jakten.");
            }
        }
    }

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

            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");


            Console.WriteLine($"{Name} känner sig ny och fräsch efter att ha bytt skal!");
        }

    }
}
