using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class RaceCar : Car
    {
        public string Turbo { get; set; }

        public RaceCar(int hp, string wheel, string window) : base(hp, wheel, window)
        {
            
        }

        public void Racing()
        {
            Console.WriteLine("\nThe race car is racing");
        }
    }
}
