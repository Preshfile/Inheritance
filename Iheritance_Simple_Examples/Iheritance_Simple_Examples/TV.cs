using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Simple_Examples
{
    //The TV class is also a child class inheriting from the parent ElectricalDevices
    internal class TV : ElectricalDevice
    {

        public TV (bool on, string brand) : base(on, brand)
        {
          
        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("TV is On and you're Watching TV.");
            }
            else
            {
                Console.WriteLine("TV is off, you cant TV.");
            }
        }
    }
}
