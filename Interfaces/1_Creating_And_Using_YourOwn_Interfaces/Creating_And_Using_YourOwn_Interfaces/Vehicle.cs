using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_And_Using_YourOwn_Interfaces
{
    internal class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }
        public Vehicle()
        {
            Speed = 120f;
            Color = "red";
        }
        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
