using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PlanetsAnonTypeApp3
{
    
    public class CatalogOfPlanets
    {
        private List<Planet> Planets { get; set; }
       public int Counter { get; set; }
        public CatalogOfPlanets()
        {
            Planets = new List<Planet>
            {
                new Planet ("Venus",2, 380.25),
                new Planet ("The Earth", 3, 40.075),
                new Planet ("Mars", 4, 21.3444)
            };   
        }
        public void GetPlanet(string planetName,Func<string,string> planetValidator)
        {
            Counter++;
            var planet = Planets.FirstOrDefault(p => p.Name.Equals(planetName, StringComparison.OrdinalIgnoreCase));
          
            if(planetValidator(planetName) == "Error")
            {
                Console.WriteLine("You ask too often");
                Environment.Exit(0);
            }
            if (planet != null)
            {
                Console.WriteLine($"OrdinalNumber : {planet.OrderNumber}\n Equator length: {planet.EquatorLength}");
            }
            else
            {
                Console.WriteLine($"{planetName} is not in catalog");
            }
        }

    }
}
