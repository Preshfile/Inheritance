using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_And_Using_YourOwn_Interfaces
{
    internal interface IDestroyable
    {
        //Property to store the audio file of the destruction sound
        public string DestructionSound { get; set; }

        //Method to destroy an object
        void Destroy();
    }
}
