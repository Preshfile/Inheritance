using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IEnumerator_IEnumerable
{
    internal class Dog
    {
        //properties
        public string Name { get; set; }
        public bool IsNaughty { get; set; }

        //constructor
        public Dog(string name, bool naughty)
        {
            this.Name = name;
            this.IsNaughty = naughty;
        }

        //method to print how many treats the dog received
        public void GiveTreat(int numberOfTreats)
        {
            //Print a message containing the name of the dog and number of treats
            //Hint: Good dogs get more treats than naughty dogs
            Console.WriteLine("Dog: {0} saids woof {1} times", Name, numberOfTreats);
        }
    }
}
