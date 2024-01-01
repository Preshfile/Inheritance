using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_And_Using_YourOwn_Interfaces
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        //Default constructor where values are set to default
        public Furniture()
        {
            Color = "Grey";
            Material = "Wood";
        }
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
