using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_MultiLevelInheritance
{
    internal class Vehicle
    {

        // Properties
    public string Brand { get; set; }
        public int Year { get; set; }

        // Constructor
        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Year} {Brand}");
        }
    }
}
