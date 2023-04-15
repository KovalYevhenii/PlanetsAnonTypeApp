
using System;
using System.Net.WebSockets;

namespace PlanetsAnonTypeApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogOfPlanets catalog = new();

            catalog.GetPlanet("Mars", countValidation =>
            {
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
            catalog.GetPlanet("the Earth", countValidation =>
            {
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
            catalog.GetPlanet("Venus", countValidation =>
            {
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
            catalog.GetPlanet("mars", countValidation =>
            {
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