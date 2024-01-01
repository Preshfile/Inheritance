using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Virtual_And_Override_Keywords
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            //Calling the Eat method from the base class
            base.Eat();
        }

        public override void MakeSound()
        {
            //Since every animal makes different sound, each animal will have to implement its own sound
            Console.WriteLine($"{Name} is making sound Woof! Woo! Woof! ...");
        }

        public override void Play()
        {
            if(IsHappy)
            {
                base.Play(); //can implement other things here, not necessarily calling the play method from the base
            }
        }
    }
}
