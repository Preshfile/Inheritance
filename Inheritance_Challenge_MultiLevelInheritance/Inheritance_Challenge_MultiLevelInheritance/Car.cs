using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_MultiLevelInheritance
{
    internal class Car : Vehicle
    {
        // Additional properties
        public int NumberOfDoors { get; set; }

        // Constructor
        public Car(string brand, int year, int doors) : base(brand, year)
        {
            NumberOfDoors = doors;
        }

        // Additional method
        public void Start()
        {
            Console.WriteLine($"The car with {NumberOfDoors} doors is starting.");
        }
    }
}
