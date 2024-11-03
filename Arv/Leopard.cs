namespace Arv
{
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
            // Kontrollera om objektet är exakt av typen Leopard
            if (this.GetType() == typeof(Leopard))
            {
                Console.WriteLine($"{Name} är en Leopard");
            }
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
}
