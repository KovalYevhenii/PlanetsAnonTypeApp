using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsAnonTypeApp3
{
    public class Planet
    {
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public double EquatorLength { get; set; }

        public Planet(string name, int orderNumber, double equatorLength)
        {
            Name = name;
            OrderNumber = orderNumber;
            EquatorLength = equatorLength;
        }
    }
}
