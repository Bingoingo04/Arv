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
}
