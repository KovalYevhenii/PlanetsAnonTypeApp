
namespace PlanetsAnonTypeApp2
{
    public class Planet
    {
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public double EquatorLength { get; set; }
        public Planet? Previous { get; set; }
        public Planet(string name, int orderNumber, double equatorLength, Planet? previousPlanet = null)
        {
            Name = name;
            OrderNumber = orderNumber;
            EquatorLength = equatorLength;
            Previous = previousPlanet;
        }
    }
}
