using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Virtual_And_Override_Keywords
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        //This method is made virtual so it can be overridden by classes that inherit from this animal class
        //This is necessary because the sound an animal make is peculiar to that type of animal. All animals don't make same sound
        public virtual void MakeSound() 
        {

        }

        // virtual is necessary so that subclasses can override this method
        public virtual void Eat()
        {
            //Check if animal is hungry
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
