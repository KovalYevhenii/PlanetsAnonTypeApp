using System.Text.Json;

namespace PlanetsAnonTypeApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogOfPlanets catalog = new();
            catalog.GetPlanet("the earth");
            Console.WriteLine("--------");
            catalog.GetPlanet("Lemonia");
            Console.WriteLine("--------");
            catalog.GetPlanet("mars");
            Console.WriteLine("--------");
            catalog.GetPlanet("mars");
        }
    }
}