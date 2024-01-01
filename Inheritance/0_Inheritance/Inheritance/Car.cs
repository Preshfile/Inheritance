using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Car
    {
        public int HP { get; set; }
        public string Wheel { get; set; }
        public string Windows { get; set; }

        public Car( int hp, string wheel, string windows)
        {
            HP = hp;
            Wheel = wheel;
            Windows = windows;
        }

        public void Drive()
        {
            Console.WriteLine("The car is driving");
        } 
        public void Honk()
        {
            Console.WriteLine("The car is honking");
        }
    }

}
