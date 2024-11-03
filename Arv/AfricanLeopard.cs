namespace Arv
{
    public class AfricanLeopard : Leopard
    {
        public bool CanTolerateHeat { get; set; } = true;

        public AfricanLeopard(string name, int age) : base(name, age)
        {
        }

        public override void InformationAbout()
        {
            Console.WriteLine($"{Name} är en Afrikansk Leopard");
            base.InformationAbout();
            Console.WriteLine($"Kan tolerera höga temperaturer: {CanTolerateHeat}");
        }

        public void HuntInSavannah()
        {
            Console.WriteLine($"{Name} smyger sig fram genom gräset för att överraska sitt byte.");
        }
    }

}
