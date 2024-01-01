using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Simple_Examples
{
    //The Radio class is a child class inheriting from the parent ElectricalDevices
    internal class Radio : ElectricalDevice //Radio is inheriting from ElectricalDevice
    {
       

        public Radio(bool on, string brand) : base(on, brand)
        { //pass on the "on" and "brand" from this constructor to that of the ElectricalDevices
 
        }

       
        public void ListenToRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Radio is On! You're listening to radio");
            }
            else
            {
                Console.WriteLine("Radio is off! You cant listen to radio");
            }
        }
    }
}
