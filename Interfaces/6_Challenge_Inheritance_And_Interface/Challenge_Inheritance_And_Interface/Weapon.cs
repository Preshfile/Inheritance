using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Inheritance_And_Interface
{
    internal class Weapon
    {

        public string Name { get; set; }

        public Weapon()
        {
            Name = "Gun";
        }

        public Weapon(string name)
        {
            Name = name;
        }


        public void Label()
        {
            Console.WriteLine("This is a {0}!", Name);
        }
    }
}
