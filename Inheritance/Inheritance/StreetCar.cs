using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StreetCar : Car
    {
        public bool Comfort { get; set; }

        public StreetCar(int hp, string wheel, string windows, bool comfort) : base(hp, wheel, windows)
        {
            Comfort = comfort;
        }

        public void StreetRide()
        {
            if(Comfort != true)
            {
                 Console.WriteLine("\nThe street car with:\n     Hp of: {0},\n     Wheel of: {1}\n     and\n     window of: {2}\n                is on a street ride with minimum comfort.\n", HP, Wheel, Windows);
            }
            else
            {
                 Console.WriteLine("\nThe street car with:\n     Hp of: {0},\n     Wheel of: {1}\n     and\n     window of: {2}\n                is on a street ride with maximum comfort.\n", HP, Wheel, Windows);

            }
        }
    }
}
