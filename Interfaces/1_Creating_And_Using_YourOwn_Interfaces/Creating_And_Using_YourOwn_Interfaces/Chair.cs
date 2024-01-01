using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_And_Using_YourOwn_Interfaces
{
    internal class Chair : Furniture, IDestroyable
    {
        //Implement the interface property
        public string DestructionSound { get; set; }


        public Chair(string color, string material) 
        {
            this.Color = color;
            this.Material = material;

            // Initialize the interface's property 
            DestructionSound = "ChairExplosionSound.mp3";   
        }

        public void Destroy()
        {
            //When a chair gets destroyed, play the destruction sound
            //and spawn the destroy chair parts
            Console.WriteLine($"The {Color} chair was destroyed.");
            Console.WriteLine($"Playing the destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts.");

           
        }
    }
}
