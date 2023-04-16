
using System;
using System.Net.WebSockets;

namespace PlanetsAnonTypeApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogOfPlanets catalog = new();
      
            catalog.GetPlanet("Mars", planetName =>
            {
                if (planetName.ToLower() == "Limonia")
                {
                    return "Vorbidden planet";
                }
                if (catalog.Counter > 3)
                {
                    return "Error";
                }
                else
                {
                    return null;
                }
            });
            Console.WriteLine("\n");
            catalog.GetPlanet("Limonia", planetName =>
            {
                if (planetName == "Limonia")
                {
                    return "Vorbidden planet";
                }
                if (catalog.Counter > 3)
                {
                    return "Error";
                }
                else
                {
                    return null;
                }
            });
            Console.WriteLine("\n");
            catalog.GetPlanet("the Earth", planetName =>
            {
                if (planetName == "Limonia")
                {
                    return "Vorbidden planet";
                }
                if (catalog.Counter > 3)
                {
                    return "Error";
                }
                else
                {
                    return null;
                }
            });
            Console.WriteLine("\n");
            catalog.GetPlanet("mars", planetName =>
            {
                if (planetName.ToLower() == "Limonia")
                {
                    return "Vorbidden planet";

                }
                if (catalog.Counter > 3)
                {
                    return "Error";
                }
                else
                {
                    return null;
                }
            });
        }

    }
}