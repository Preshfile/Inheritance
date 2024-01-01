using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_MultiLevelInheritance
{
    internal class SportsCar : Car
    {
        // Additional properties
    public bool Convertible { get; set; }

        // Constructor
        public SportsCar(string brand, int year, int doors, bool convertible) : base(brand, year, doors)
        {
            Convertible = convertible;
        }

        // Additional method
        public void Accelerate()
        {
            Console.WriteLine($"The sports car is accelerating! Convertible: {Convertible}");
        }
    }
}
