namespace Arv
{
    public class SnowLeopard : Leopard
    {
        public int PreferredAltitude { get; set; } = 3000;

        public SnowLeopard(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
            Legs = 4;
            Lifespan = 15;
            HasFurr = true;
            IsLandAnimal = true;
        }

        public override void InformationAbout()
        {
            Console.WriteLine($"{Name} är en Snö Leopard");
            base.InformationAbout();
            Console.WriteLine($"Föredragen höjd: {PreferredAltitude} meter över havet");
        }

        public void ClimbSteepTerrain()
        {
            Console.WriteLine($"{Name} klättrar på en brant bergsvägg!");
        }
    }

}
