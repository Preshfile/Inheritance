using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Creating_And_Using_YourOwn_Interfaces
{
    internal class Car : Vehicle, IDestroyable
    {
        //Implement the interface property
        public string DestructionSound { get; set; }


        /* Creating a new property to store the destroyable objects nearby
         When a car gets destroyed, it should also destroy the nearby object
         This list is of type IDestroyable which means it can store an object 
         that implements this interface and we can only access the properties 
         and methods in this interface*/

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color) : base(speed, color)
        { 
            this.Speed = speed;
            this.Color = color;

            //Initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            
            //initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();


        }
        //Implement the interface method
        public void Destroy()
        {
            //When a car gets destroyed, play the destruction sound
            //and create the fire effect
            Console.WriteLine("Playing the destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire.");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
