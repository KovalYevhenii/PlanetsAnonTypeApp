
namespace PlanetsAnonTypeApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogOfPlanets catalog = new();
      
            catalog.GetPlanet("Mars", (planetName,counter) =>
            {
                if (planetName.Equals("Limonia"))
                {
                    return "forbidden planet";
                }
                if (counter % 3 == 0)
                    return "Error";
                    return null;
            });
            Console.WriteLine("\n");
            catalog.GetPlanet("Limonia", (planetName, counter) =>
            {
                if (planetName.Equals("Limonia"))
                {
                    return "forbidden planet";
                }
                if (counter % 3 == 0)
                    return "Error";
                      return null;
            });
            Console.WriteLine("\n");
            catalog.GetPlanet("venus", (planetName, counter) =>
            {
                if (planetName.Equals("Limonia"))
                {
                    return "forbidden planet";
                }
                if (counter % 3 == 0)
                    return "Error";
                    return null;
            });
            Console.WriteLine("\n");
            catalog.GetPlanet("Mars", (planetName, counter) =>
            {
                if (planetName.Equals("Limonia"))
                {
                    return "forbidden planet";
                }
                if (counter % 3 == 0)
                    return "Error";
                    return null;
            });
        }
    }
}