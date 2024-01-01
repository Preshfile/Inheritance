using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Inheritance_And_Interface
{
    internal class Gun : Weapon, IShootable
    {
        public Gun()
        {
            
        }
        public Gun(string name) : base(name)
        {
            
        }

        public void Shoot()
        {
            Console.WriteLine("BANG!");
        }
    }
}
