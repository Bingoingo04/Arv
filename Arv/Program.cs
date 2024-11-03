namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leopard leopard = new Leopard("Leo", 12);
            leopard.InformationAbout();
            leopard.Hunt();
            leopard.MakeSound();

            Console.WriteLine("\n----------------\n");

            SnowLeopard snowLeopard = new SnowLeopard("Johan", 8);
            snowLeopard.InformationAbout();
            snowLeopard.ClimbSteepTerrain();
            snowLeopard.RemainingLifespan();

            Console.WriteLine("\n----------------\n");
            AfricanLeopard africanLeopard = new AfricanLeopard("Johan", 8);
            africanLeopard.InformationAbout();
            africanLeopard.HuntInSavannah();

            Console.WriteLine("\n----------------\n");

            BlueWhale blueWhale = new BlueWhale("Bert", 60);
            blueWhale.AgeUp();
            blueWhale.InformationAbout();
            blueWhale.Dive(500);
            blueWhale.MakeSound();

            Console.WriteLine("\n----------------\n");

            PythonSnake pythonSnake = new PythonSnake("Paul", 23);
            pythonSnake.InformationAbout();
            pythonSnake.RemainingLifespan();
            pythonSnake.ShedSkin();
            pythonSnake.MakeSound();
        }
    }
}
