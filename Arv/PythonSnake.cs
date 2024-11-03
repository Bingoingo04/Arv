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
            Console.WriteLine($"{Name} är en Pyton Orm");
            base.InformationAbout();
            Console.WriteLine($"Längd: {Length}cm");
        }

        public void ShedSkin()
        {
            Console.WriteLine($"Tryck Enter för att {Name} ska byta sitt skal.");
            Console.ReadKey();

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
