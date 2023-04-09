namespace PlanetsAnonTypeApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var planetM = new
            {
                Name = "Mars",
                OrdinalNum = 4,
                EquatorLength = 21.3444
            };
            var planetE = new
            {
                Name = "The Earth",
                OrdinalNum = 3,
                EquatorLength = 40.075,
                PreviousPlanet = planetM
            };
            var planetV = new
            {
                Name = "Venus",
                OrdinalNum = 2,
                EquatorLength = 380.25,
                PreviousPlanet = planetE
            };

            var planetV_2 = new
            {
                Name = "Venus",
                OrdinalNum = 2,
                EquatorLength = 380.25,
                PreviousPlanet = planetE
            };
            Console.WriteLine($"Planet: {planetM},\n Equivalent to Venus = {planetM.Equals(planetV)}\n");
            Console.WriteLine("\n");
            Console.WriteLine($"Planet: {planetE},\n Equivalent to Venus = {planetE.Equals(planetV)}\n");
            Console.WriteLine("\n");
            Console.WriteLine($"Planet: {planetV},\n  Equivalent to Venus = {planetV.Equals(planetV_2)}\n");
            Console.WriteLine("\n");

        }
    }


}

