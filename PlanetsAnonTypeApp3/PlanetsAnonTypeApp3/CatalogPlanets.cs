
namespace PlanetsAnonTypeApp3
{
    public delegate string? PlanetValidator(string planetName,int counter);
    public class CatalogOfPlanets
    {
        private List<Planet> Planets { get; set; }
        private int Counter { get; set; }
        public CatalogOfPlanets()
        {
            Planets = new List<Planet>
            {
                new Planet ("Venus",2, 380.25),
                new Planet ("The Earth", 3, 40.075, new Planet("Venus",2, 380.25)),
                new Planet ("Mars", 4, 21.3444, new Planet ("The Earth", 3, 40.075))
            };
        }
        public void GetPlanet(string planetName, PlanetValidator planetValidator)
        {
           Counter++;  
            var planet = Planets.FirstOrDefault(p => p.Name.Equals(planetName, StringComparison.OrdinalIgnoreCase));

            if (planetValidator(planetName,Counter) == "forbidden planet")
            {
                Console.WriteLine("this is forbidden planet");
            }
            else if (planetValidator(planetName,Counter) == "Error")
            {
                Console.WriteLine("You ask too often");
                Counter = 0;
            }
            else if (planet != null)
            {
                Console.WriteLine($"OrdinalNumber : {planet.OrderNumber}\n Equator length: {planet.EquatorLength}");
            }
            else
            {
                Console.WriteLine($"{planetName} Can not be find");
            }
        }
    }
}
