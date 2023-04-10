using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsAnonTypeApp2
{
    public class CatalogOfPlanets
    {
       private List<Planet> Planets { get; set; }
        private int _getPlanetCount;

        public CatalogOfPlanets()
        {
            Planets  = new List<Planet>
            {
                new Planet ("Venus",2, 380.25),
                new Planet ("The Earth", 3, 40.075),
                new Planet ("Mars", 4, 21.3444)
            };
            _getPlanetCount = 0;
        }
        public void GetPlanet(string planetName)
        {
          var planet = Planets.FirstOrDefault(p => p.Name.Equals(planetName, StringComparison.OrdinalIgnoreCase));

            if(_getPlanetCount>= 3)
            {
                Console.WriteLine("You have reached the maximum number of calls to the GetPlanet method.");
                return;
            }
            if(planet != null)
            {
                Console.WriteLine($"OrdinalNumber : {planet.OrderNumber}");
                Console.WriteLine($"Equator length: {planet.EquatorLength }");
            }
            else
            {
                Console.WriteLine($"Planet {planetName} not found");
            }
            _getPlanetCount++;
            
        }
    }
}
