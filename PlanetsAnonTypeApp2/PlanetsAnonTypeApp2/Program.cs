
namespace PlanetsAnonTypeApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogOfPlanets catalog = new();
            catalog.GetPlanet("null");
            Console.WriteLine("--------");
            catalog.GetPlanet("Lemonia");
            Console.WriteLine("--------");
            catalog.GetPlanet("mars");
            Console.WriteLine("--------");
            catalog.GetPlanet("venus");
            Console.WriteLine("--------");
            catalog.GetPlanet("mars");
            Console.WriteLine("--------");
            catalog.GetPlanet("the earth");
        }
    }
}