
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
                new Planet ("The Earth", 3, 40.075,new Planet("Venus",2, 380.25)),
                new Planet ("Mars", 4, 21.3444,new Planet("The Earth", 3, 40.075))
            };
        }
        public void GetPlanet(string planetName)
        {
            ++_getPlanetCount;
          var planet = Planets.FirstOrDefault(p => p.Name.Equals(planetName, StringComparison.OrdinalIgnoreCase));

            if(_getPlanetCount % 3 == 0)
            {
                Console.WriteLine("You are trying too often.");
                _getPlanetCount = 0;
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
            
        }
    }
}
